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
using HomeScreen.Database_Layer;

namespace HomeScreen.Database_Layer
{
    class BookingDB: DB
    {
        private string table1 = "Booking";
        private string sqlLocal1 = "SELECT * FROM Booking";

        private Collection<Booking> bookings;

        public struct ColumnAttribs
        {
            public string myName;
            public SqlDbType myType;
            public int mySize;
        }

        public BookingDB(): base()
        {
            bookings = new Collection<Booking>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);

        }

        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        public DataSet GetDataSet()
        {
            return dsMain;
        }

        #region Database Operations CRUD --- Add the object's values to the database
        public void DataSetChange(Booking aBooking, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

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

        #region Utility Methods
        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;
            Booking aBooking;
            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Employee object
                    aBooking = new Booking();
                    //Obtain each employee attribute from the specific field in the row in the table
                    aBooking.ReservationNumber = Convert.ToInt32(myRow["ReservationNumber"]);
                    aBooking.GuestID = Convert.ToString(myRow["GuestID"]);
                    aBooking.InvoiceNumber = Convert.ToInt32(myRow["InvoiceNumber"]);
                    aBooking.NoOfRooms = Convert.ToInt32(myRow["NoOfRooms"]);
                    aBooking.NoOfPeople = Convert.ToInt32(myRow["NoOfPeople"]);
                    aBooking.StartDate = Convert.ToDateTime(myRow["StartDate"]);
                    aBooking.EndDate = Convert.ToDateTime(myRow["EndDate"]);
                    aBooking.SentConfirmation = Convert.ToBoolean(myRow["SentConfirmation"]);
                    aBooking.RecievedDeposit = Convert.ToBoolean(myRow["RecievedDeposit"]);
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
            aRow["NoOfRooms"] = aBooking.NoOfRooms;
            aRow["NoOfPeople"] = aBooking.NoOfPeople;

            aRow["StartDate"] = aBooking.StartDate;
            aRow["EndDate"] = aBooking.EndDate;
            aRow["SentConfirmation"] = aBooking.SentConfirmation;
            aRow["RecievedDeposit"] = aBooking.RecievedDeposit;
            aRow["IsCancelled"] = aBooking.IsCancelled;


        }

        //The FindRow method finds the row for a specific employee(by ID)  in a specific table
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
                    if (aBooking.ReservationNumber == Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["ID"]))
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


        private void Build_INSERT_Parameters(Booking aBooking)
        {
            //Create Parameters to communicate with SQL INSERT
            //https://www.google.co.za/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=size+in+bytes+of+Int+in+SQL
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@ReservationNumber", SqlDbType.NVarChar, 15, "ReservationNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@NoOfRooms", SqlDbType.Int, 15, "NoOfRooms");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@StartDate", SqlDbType.DateTime, 15, "StartDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@EndDate", SqlDbType.DateTime, 15, "EndDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@SentConfirmation", SqlDbType.Bit, 15, "SentConfirmation");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@ReceivedDeposit", SqlDbType.Bit, 15, "ReceivedDeposit");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@isCancelled", SqlDbType.Bit, 15, "isCancelled");
            daMain.InsertCommand.Parameters.Add(param);

            
            //***https://msdn.microsoft.com/en-za/library/ms179882.aspx
        }

        private void Build_UPDATE_Parameters(Booking aBooking)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@NoOfRooms", SqlDbType.NVarChar, 50, "NoOfRooms");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //Do for all fields other than ID and EMPID as for Insert 
            param = new SqlParameter("@StartDate", SqlDbType.DateTime, "StartDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@EndDate", SqlDbType.DateTime, 1, "EndDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
           
            param = new SqlParameter("@SentConfirmation", SqlDbType.Money, 8, "SentConfirmation");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@ReceivedDeposit", SqlDbType.Money, 8, "ReceivedDeposit");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@IsCancelled", SqlDbType.Money, 8, "IsCancelled");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //testing the ID of record that needs to change with the original ID of the record
            param = new SqlParameter("@Original_ReservationNumber", SqlDbType.NVarChar, 15, "ReservationNumber");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters()
        {
            //--Create Parameters to communicate with SQL DELETE
            SqlParameter param;
            param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }
        private void Create_INSERT_Command(Booking aBooking)
        {

            daMain.InsertCommand = new SqlCommand("INSERT into Bookings (ID, EMPID, Name, Phone, Role, Salary) VALUES (@ID, @EmpID, @Name, @Phone, @Role, @Salary)", cnMain);
            Build_INSERT_Parameters(aBooking);
        }

        private void Create_UPDATE_Command(Booking aBooking)
        {
            //Create the command that must be used to insert values into one of the three tables
            //Assumption is that the ID and EMPID cannot be changed

            switch (anEmp.role.RoleValue)
            {
                case Role.RoleType.Headwaiter:
                    daMain.UpdateCommand = new SqlCommand("UPDATE HeadWaiter SET Name =@Name, Phone =@Phone, Role =@Role, Salary = @Salary " + "WHERE ID = @Original_ID", cnMain);
                    break;
                case Role.RoleType.Waiter:
                    daMain.UpdateCommand = new SqlCommand("UPDATE Waiter SET Name =@Name, Phone =@Phone, Role =@Role, Tips =@Tips, DayRate =@DayRate, NoOfShifts =@NoOfShifts " + "WHERE ID = @Original_ID", cnMain);
                    break;
                case Role.RoleType.Runner:
                    daMain.UpdateCommand = new SqlCommand("UPDATE Runner SET Name =@Name, Phone =@Phone, Role =@Role, DayRate =@DayRate, NoOfShifts =@NoOfShifts " + "WHERE ID = @Original_ID", cnMain);
                    break;
            }
            Build_UPDATE_Parameters(anEmp);
        }

        private string Create_DELETE_Command(Booking aBooking)
        {
            string errorString = null;
            //Create the command that must be used to delete values from the the appropriate table
            switch (anEmp.role.RoleValue)
            {
                case Role.RoleType.Headwaiter:
                    daMain.DeleteCommand = new SqlCommand("DELETE FROM HeadWaiter WHERE ID = @ID", cnMain);
                    break;
                case Role.RoleType.Waiter:
                    daMain.DeleteCommand = new SqlCommand("DELETE FROM Waiter WHERE ID = @ID", cnMain);
                    break;
                case Role.RoleType.Runner:
                    daMain.DeleteCommand = new SqlCommand("DELETE FROM Runner WHERE ID = @ID", cnMain);
                    break;
            }
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
        public bool UpdateDataSource(Booking aBooking)
        {
            bool success = true;
            Create_INSERT_Command(aBooking);
            Create_UPDATE_Command(aBooking);
            Create_DELETE_Command(aBooking);
            switch (anEmp.role.RoleValue)
            {
                case Role.RoleType.Headwaiter:
                    success = UpdateDataSource(sqlLocal1, table1);
                    break;
                case Role.RoleType.Waiter:
                    success = UpdateDataSource(sqlLocal2, table2);
                    break;
                case Role.RoleType.Runner:
                    success = UpdateDataSource(sqlLocal3, table3);
                    break;
            }
            return success;
        }
        #endregion 


    }
}
