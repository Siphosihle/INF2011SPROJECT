using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    class Date
    {
        private string ID;
        private DateTime checkInDate;
        private DateTime checkOutDate;

        public bool IsAvailable(DateTime inDate, DateTime outDate)
        {
            return true;
        }
    }

}
