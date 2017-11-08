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

        private string paymentQuery = "SELECT * FROM Bookings WHERE InvoiceNummber = ";
        private string guestQuery = "SELECT * FROM Bookings WHERE GuestID = ";
        private string roomQuery = "SELECT * FROM Bookings WHERE RoomID = ";

        private Collection<Booking> bookings;



        public BookingDB(string field, string searchBy): base()
        {
            bookings = new Collection<Booking>();

            switch(field)
            {
                case "All":
                    FillDataSet(sqlLocal1, table1);
                    Add2Collection(table1);
                    break;
                case "payment":
                    FillDataSet(paymentQuery+searchBy, table1);
                    Add2Collection(table1);
                    break;
                case "guest":
                    FillDataSet(guestQuery + searchBy, table1);
                    Add2Collection(table1);
                    break;
                case "room":
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
                    aBooking.RecievedDeposit = Convert.ToBoolean(myRow["ReceiveDeposit"]);
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
            aRow["RecievedDeposit"] = aBooking.RecievedDeposit;
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
                    if (aBooking.ReservationNumber == Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["ReservationNumber"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }
        #endregion

        private void SearchByRoom()
        {

        }


    }
}
