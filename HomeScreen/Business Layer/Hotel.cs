using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class Hotel
    {
        private int hotelID;
        private string hotelName;

        private Collection<Room> rooms;

        #region Properties

        public Collection<Room> Rooms
        {
            get
            {
                return rooms;
            }
            set
            {
                rooms = value;
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

        public string HotelName
        {
            get
            {
                return hotelName;
            }
            set
            {
                hotelName = value;
            }
        }

        #endregion


    }
}
