using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeScreen.Business_Layer;
using HomeScreen.Database_Layer;

namespace HomeScreen.Business_Layer
{
    public class Hotel
    {

        //businesslayerformat
        //variables
        //properties
        //constructors

        private int hotelID;
        private string hotelName;
        private string address;
        private int noOfRooms;
        

        #region Properties

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

        public Hotel()
        {
            
        }
        public string SelectHotelName(string name)
        {
            return name;
        }   
        public void HotelDetails(string address, int id)
        {
            
        }

    }
}
