using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class Guest
    {

        //businesslayerformat
        //variables
        //properties
        //constructors

        #region Members
        private string guestID;
        private string name;
        private string surname;
        private string phoneNo;
        private string address;
        private string email;
        private string status;
        public Type type;
        #endregion

        #region Properties
        public string GuestID
        {
            get
            {
                return guestID;
            }
            set
            {
                guestID = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phoneNo;
            }
            set
            {
                phoneNo = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion


        public Guest()
        {
            name = "";
            surname = "";
            guestID = "";
        }

        public void CheckGuest()
        {

        }
        
    }
}
