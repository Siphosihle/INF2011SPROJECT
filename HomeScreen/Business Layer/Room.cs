using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class Room
    {

        //businesslayerformat
        //variables
        //properties
        //constructors

        private int roomID;
        private int hotelID;
        private int roomNo;
        private Collection<Booking> bookings;

        public Room()
        {
        }

        #region Properties
        
        public int RoomID
        {
            get
            {
                return roomID;
            }
            set
            {
                roomID = value;
            }
        }

            public int HotelID
        {
            get
            {
                return hotelID;
            }
            set
            {
                hotelID = value;
            }
        }

        public int RoomNo
        {
            get
            {
                return roomNo;
            }
            set
            {
                roomNo = value;
            }
        }
    }



        #endregion

        //public bool RoomAvailability(string roomNo, Date startDate, Date endDate)
        //{

        //}
    }

