using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class RoomCharge
    {

        private int roomChargeID;
        private DateTime startDate;
        private DateTime endDate;
        private decimal roomCharge;

        #region Properties

        public int RoomChargeID
        {
            get { return roomChargeID; }
            set { roomChargeID = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public decimal RoomCharge
        {
            get { return roomCharge; }
            set { roomCharge = value; }
        }

        #endregion

    }
}
