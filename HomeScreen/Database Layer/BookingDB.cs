using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Xml;
//namespaces
using HomeScreen.Business_Layer;


namespace HomeScreen.Database_Layer
{
    public class BookingDB: DB
    {

        private string table1 = "Bookings";
        private string sqlLocal1 = "SELECT * FROM Bookings";

        private string paymentQuery =   "SELECT Bookings.* FROM Bookings INNER JOIN BookingPayments ON Bookings.ReservationNumber = BookingPayments.ReservationNumber WHERE BookingPayments.InvoiceNumber = ";
        private string guestQuery =     "SELECT * FROM Bookings WHERE GuestID = ";
        private string roomQuery =      "SELECT Bookings.* FROM Bookings INNER JOIN RoomAllocation ON Bookings.ReservationNumber = RoomAllocation.ReservationNumber WHERE RoomAllocation.RoomID = ";

        private Collection<Booking> bookings;



        public BookingDB(string tbl, string searchBy): base()
        {
            bookings = new Collection<Booking>();

            switch(tbl)
            {
                case "all":
                    FillDataSet(sqlLocal1, table1);
                    Add2Collection(table1);
                    break;
                case "payments":
                    FillDataSet(paymentQuery+ searchBy, table1);
                    Add2Collection(table1);
                    break;
                case "guest":
                    FillDataSet(guestQuery + searchBy, table1);
                    Add2Collection(table1);
                    break;
                case "rooms":
                    FillDataSet(roomQuery + searchBy, table1);
                    Add2Collection(table1);
                    break;

            }
            
        }

        #region Properties

        public Collection<Booking> AllBookings
        {
            get { return bookings; }
        }

        #endregion

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        #region Database Operations CRUD --- Add the object's values to the database
        public void DataSetChange(Booking aBooking, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;
            //***In this case the dataset change refers to adding to a database table
            //***We now have  3 tables.. once they are placed in an array .. this becomes easier 

            dataTable = table1;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, aBooking, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aBooking, dataTable)];
                    FillRow(aRow, aBooking, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aBooking, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion





        #region Utility Functions
        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;

            Booking aBooking;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aBooking = new Booking();

                    aBooking.ReservationNumber = Convert.ToInt32(myRow["ReservationNumber"]);
                    aBooking.GuestID = Convert.ToInt32(myRow["GuestID"]);
                    aBooking.NoOfRooms = Convert.ToInt32(myRow["NoOfRooms"]);
                    aBooking.NoOfPeople = Convert.ToInt32(myRow["NoOfPeople"]);
                    aBooking.StartDate = Convert.ToDateTime(myRow["StartDate"]);
                    aBooking.EndDate = Convert.ToDateTime(myRow["EndDate"]);
                    aBooking.SentConfirmation = Convert.ToBoolean(myRow["SentConfirmation"]);
                    aBooking.RecieveDeposit = Convert.ToBoolean(myRow["RecieveDeposit"]);
                    aBooking.IsCancelled = Convert.ToBoolean(myRow["IsCancelled"]);

                    bookings.Add(aBooking);


                }
            }

        }
        private void FillRow(DataRow aRow, Booking aBooking, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["ReservationNumber"] = aBooking.ReservationNumber;  //NOTE square brackets to indicate index of collections of fields in row.
            }

            aRow["GuestID"] = aBooking.GuestID;
            aRow["NoOfRooms"] = aBooking.NoOfRooms;
            aRow["NoOfPeople"] = aBooking.NoOfPeople;
            aRow["StartDate"] = aBooking.StartDate;
            aRow["EndDate"] = aBooking.EndDate;
            aRow["SentConfirmation"] = aBooking.SentConfirmation;
            aRow["RecieveDeposit"] = aBooking.RecieveDeposit;
            aRow["IsCancelled"] = aBooking.IsCancelled;

            
        }
        private int FindRow(Booking aBooking, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                //Ignore rows marked as deleted in dataset
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //In c# there is no item property (but we use the 2-dim array) it is automatically known to the compiler when used as below
                    if (aBooking.ReservationNumber.Equals(Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["ReservationNumber"])))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Booking bking)
        {
            //Create Parameters to communicate with SQL INSERT
            //https://www.google.co.za/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=size+in+bytes+of+Int+in+SQL
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@ReservationNumber", SqlDbType.Int, 20, "ReservationNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.Int, 20, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@NoOfRooms", SqlDbType.Int, 50, "NoOfRooms");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@NoOfPeople", SqlDbType.Int, 15, "NoOfPeople");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@StartDate", SqlDbType.DateTime, 50, "StartDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@EndDate", SqlDbType.DateTime, 50, "EndDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@SentConfirmation", SqlDbType.Bit, 50, "SentConfirmation");
            
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RecieveDeposit", SqlDbType.Bit, 50, "RecieveDeposit");

            daMain.InsertCommand.Parameters.Add(param);
            param = new SqlParameter("@IsCancelled", SqlDbType.Bit, 50, "IsCancelled");

            daMain.InsertCommand.Parameters.Add(param);
            //***https://msdn.microsoft.com/en-za/library/ms179882.aspx
        }

        private void Build_UPDATE_Parameters(Booking bking)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@GuestID", SqlDbType.Int, 20, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@NoOfRooms", SqlDbType.Int, 50, "NoOfRooms");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@NoOfPeople", SqlDbType.Int, 15, "NoOfPeople");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@StartDate", SqlDbType.DateTime, 50, "StartDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@EndDate", SqlDbType.DateTime, 50, "EndDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@SentConfirmation", SqlDbType.Bit, 50, "SentConfirmation");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@RecieveDeposit", SqlDbType.Bit, 50, "RecieveDeposit");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@IsCancelled", SqlDbType.Bit, 50, "IsCancelled");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_ReservationNumber", SqlDbType.NVarChar, 15, "ReservationNumber");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

        }

        private void Build_DELETE_Parameters()
        {
            //--Create Parameters to communicate with SQL DELETE
            SqlParameter param;
            param = new SqlParameter("@ReservationNumber", SqlDbType.Int, 20, "ReservationNumber");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }
        private void Create_INSERT_Command(Booking bking)
        {
            //Create the command that must be used to insert values into the Books table..
            daMain.InsertCommand = new SqlCommand("INSERT into Bookings (ReservationNumber, GuestID, NoOfRooms, NoOfPeople, StartDate, EndDate, SentConfirmation, RecieveDeposit, IsCancelled) VALUES (@ReservationNumber, @GuestID, @NoOfRooms, @NoOfPeople, @StartDate, @EndDate, @SentConfirmation, @RecieveDeposit, @IsCancelled)", cnMain);
            Build_INSERT_Parameters(bking);
        }

        private void Create_UPDATE_Command(Booking bking)
        {
            //Create the command that must be used to insert values into one of the three tables
            daMain.UpdateCommand = new SqlCommand("UPDATE Bookings SET GuestID =@GuestID, NoOfRooms =@NoOfRooms, NoOfPeople =@NoOfPeople, StartDate =@StartDate, EndDate=@EndDate, SentConfirmation =@SentConfirmation, RecieveDeposit =@RecieveDeposit, IsCancelled =@IsCancelled " + "WHERE ReservationNumber = @Original_ReservationNumber", cnMain);
            Build_UPDATE_Parameters(bking);
        }

        private string Create_DELETE_Command(Booking bking)
        {
            string errorString = null;
            //Create the command that must be used to delete values from the the appropriate table
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Bookings WHERE ReservationNumber = @ReservationNumber", cnMain);
            try
            {
                Build_DELETE_Parameters();
            }
            catch (Exception errObj)
            {
                errorString = errObj.Message + "  " + errObj.StackTrace;
            }
            return errorString;
        }
        public bool UpdateDataSource(Booking bking)
        {
            bool success = true;
            Create_INSERT_Command(bking);
            Create_UPDATE_Command(bking);
            Create_DELETE_Command(bking);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }
        #endregion 





    }
}
