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

        private Collection<Booking> bookings;



        public BookingDB(string field): base()
        {
            bookings = new Collection<Booking>();

            //switch(field)
            //{
            //    case "All":
            //        FillDataSet(sqlLocal1, table1);
            //        Add2Collection(table1);
            //        break;
            //    case ""

            //}
            
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
        public void DataSetChange(Guest gst, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;
            //***In this case the dataset change refers to adding to a database table
            //***We now have  3 tables.. once they are placed in an array .. this becomes easier 
            //switch (gst.role.RoleValue)
            //{
            //    case Role.RoleType.Headwaiter:
            //        dataTable = table1;
            //        break;
            //    case Role.RoleType.Waiter:
            //        dataTable = table2;
            //        break;
            //    case Role.RoleType.Runner:
            //        dataTable = table3;
            //        break;
            //}
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, gst, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(gst, dataTable)];
                    FillRow(aRow, gst, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(gst, dataTable)];
                    aRow.Delete();
                    break;
            }
        }

        private int FindRow(Guest gst, string dataTable)
        {
            throw new NotImplementedException();
        }

        private void FillRow(DataRow aRow, Guest gst, DBOperation operation)
        {
            throw new NotImplementedException();
        }
        #endregion
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

                    aBooking.ReservationNumber = Convert.ToString(myRow["ReservationNumber"]);
                    aBooking.GuestID = Convert.ToString(myRow["GuestID"]);
                    aBooking.NoOfRooms = Convert.ToString(myRow["NoOfRooms"]);
                    aBooking.NoOfPeople = Convert.ToString(myRow["NoOfPeople"]);
                    aBooking.StartDate = Convert.ToDateTime(myRow["StartDate"]);
                    aBooking.EndDate = Convert.ToDateTime(myRow["EndDate"]);
                    aBooking.SentConfirmation = Convert.ToBoolean(myRow["SentConfirmation"]);
                    aBooking.RecievedDeposit = Convert.ToBoolean(myRow["ReceiveDeposit"]);
                    aBooking.IsCancelled = Convert.ToBoolean(myRow["IsCancelled"]);

                    bookings.Add(aBooking);


                }
            }

        }

        private void SearchByRoom()
        {

        }


    }
}
