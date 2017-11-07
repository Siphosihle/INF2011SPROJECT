using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class RoomAllocation
    {

        //businesslayerformat
        //variables
        //properties
        //constructors

        private int roomID;
        private int bookingID;

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
        public int BookingID
        {
            get
            {
                return bookingID;
            }
            set
            {
                bookingID = value;
            }
        }
        #endregion

        public RoomAllocation()
        {

        }


    }
}
