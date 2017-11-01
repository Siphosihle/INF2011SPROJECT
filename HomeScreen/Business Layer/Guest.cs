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
        private string guestID;
        private bool status = false;
        public Type type; 
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
        #endregion
        public Guest(Type.GuestType typeValue)
        {
            switch (typeValue)
            {
                case Type.GuestType.ExistingGuest:
                    type = new Type(name, surname, guestID);
                    break;
                case Type.GuestType.NewGuest:
                    type = new Type(name, surname, guestID, phoneNo, email, address);
                    break;
            }
        }

        public void NewGuest(string email, int phoneNo, string address)
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
