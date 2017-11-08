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

            switch(field)
            {
                case "All":
                    FillDataSet(sqlLocal1, table1);
                    Add2Collection(table1);
                    break;
                case ""

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

        private void SearchByRoom()
        {

        }


    }
}
