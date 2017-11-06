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
        string guestID;
        int reservationNumber, noOfRooms, noOfPeople, invoiceNumber;
        DateTime startDate, endDate;
        bool sentConfirmation, receivedDeposit, isCancelled;

        public virtual ICollection<Room> rooms { get; set; }

        private Calendar myCal = CultureInfo.InvariantCulture.Calendar;
        private DateTime date;


        #region Properties

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

        public int InvoiceNumber
        {
            get
            {
                return invoiceNumber;
            }
            set
            {
                invoiceNumber = value;
            }
        }

        public string GuestID
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
            this.rooms = new HashSet<Room>();
        }

        #endregion

        #region Methods
        #endregion

    }
}
