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

        private int accountID;
        private int guestID;
        private decimal balance;

        #region Properties

        public int AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }
        public int GuestID
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
