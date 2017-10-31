using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    class Guest
    {
        #region Members
        private string surname;
        private string address;
        private string email;
        private string name;
        private int phoneNo;
        private int guestID;
        private bool status = false;
        #endregion
        #region Properties
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
        public int PhoneNumber
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
        public int GuestID
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
        #endregion
        public Guest(string name, string surname, int id, string email, int phone, string address)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.address = address;
            phoneNo = phone;
            guestID = id;
        }
        public void GuestDetails()
        {

        }
        public string PaymentMethod(string type)
        {
            return type;
        }
        public bool CheckSatus()
        {
            return status;
        }
    }
}
