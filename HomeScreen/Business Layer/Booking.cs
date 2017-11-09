using System;
using System.Globalization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeScreen.Business_Layer;

namespace HomeScreen.Business_Layer
{
    public class Booking
    {
        //businesslayerformat
        //variables
        //properties
        //constructors

        private int reservationNumber;
        private int guestID;
        private int noOfPeople;
        private int noOfRooms;
        private DateTime startDate;
        private DateTime endDate;
        bool sentConfirmation, receivedDeposit, isCancelled;

        private Calendar myCal = CultureInfo.InvariantCulture.Calendar;
        private DateTime date;


        #region Properties

        public int ReservationNumber
        {
            get
            {
                return reservationNumber;
            }
            set
            {
                reservationNumber = value;
            }
        }
        public int GuestID
        {
            get
            {
                return guestID;
            }
            set
            {
                guestID = value;
            }
        }
        public int NoOfPeople
        {
            get
            {
                return noOfPeople;
            }
            set
            {
                noOfPeople = value;
            }
        }
        public int NoOfRooms
        {
            get
            {
                return noOfRooms;
            }
            set
            {
                noOfRooms = value;
            }
        }
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
            }
        }
        public bool SentConfirmation
        {
            get
            {
                return sentConfirmation;
            }
            set
            {
                sentConfirmation = value;
            }
        }
        public bool RecievedDeposit
        {
            get
            {
                return receivedDeposit;
            }
            set
            {
                receivedDeposit = value;
            }
        }
        public bool IsCancelled
        {
            get
            {
                return isCancelled;
            }
            set
            {
                isCancelled = value;
            }
        }
        #endregion

        #region Constructors

        public Booking()
        {

        }

        #endregion

        #region Methods
        public void CreateBooking(DateTime start, DateTime end, string duration, int no)
        {

        }
        public double CalculateDeposit(string reservation, string refNo)
        {
            double amount = 0;
            return amount;
        }
        public bool GenerateConfirmationLetter(string refNo)
        {
            return true;
        }
        #endregion

    }
}
