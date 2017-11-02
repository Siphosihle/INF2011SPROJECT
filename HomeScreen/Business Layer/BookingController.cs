using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeScreen.Database_Layer;

namespace HomeScreen.Business_Layer
{
    public class BookingController
    {
        BookingDB bookingDB;
        Collection<Booking> bookings;

        #region Properties
        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        #endregion

        public BookingController()
        {

        }


    }
}
