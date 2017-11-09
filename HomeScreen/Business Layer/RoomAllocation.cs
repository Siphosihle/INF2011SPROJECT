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
        private int reservationNumber;

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
        #endregion

        public RoomAllocation()
        {

        }


    }
}
