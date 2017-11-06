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
        public string surname;
        public string address;
        public string email;
        public string name;
        public string phoneNo;
        public string guestID;
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
        public Guest()
        {
            name = "";
            surname = "";
            guestID = "";
        }

        public void NewGuest(string email, int phoneNo, string address)
        {

        }
        public string PaymentMethod(string type)
        {
            return type;
        }
        
    }
}
