using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class Account
    {
        //businesslayerformat
        //variables
        //properties
        //constructors

        private string accountID;
        private string guestID;
        private decimal balance;

        #region Properties

        public string AccountID
        {
            get
            {
                return accountID;
            }
            set
            {
                accountID = value;
            }
        }
        public string GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        #endregion

        public Account()
        {

        }




    }
}
