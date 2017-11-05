using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class Booking
    {
        int reservationNumber, noOfRooms;
        DateTime startDate, endDate;
        bool sentConfirmation, receivedDeposit, isCancelled;

        public virtual ICollection<Room> rooms { get; set}


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
