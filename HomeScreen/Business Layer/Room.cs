using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class Room
    {
        private int roomID;
        private string hotelID { get; set; }
        private string roomNo { get; set; }
        public virtual ICollection<Booking> bookings { get; set; }

        public Room()
        {
            this.bookings = new HashSet<Booking>();
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

        #endregion

        //public bool RoomAvailability(string roomNo, Date startDate, Date endDate)
        //{

        //}
    }
}
