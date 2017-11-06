using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class Payment
    {

        //businesslayerformat
        //variables
        //properties
        //constructors

        private int invoiceNumber;
        private string cCID;
        private int guestID;
        private int accountID;
        private int reservationNumber;
        private decimal amount;

        #region Properties

        public int InvoiceNumber
        {
            get { return invoiceNumber; }
            set { invoiceNumber = value; }
        }

        public string CCID
        {
            get { return cCID; }
            set { cCID = value; }
        }
        public int AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }
        public int ReservationNumber
        {
            get { return reservationNumber; }
            set { reservationNumber = value; }
        }
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public int GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }

        #endregion

    }
}
