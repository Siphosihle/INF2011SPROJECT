using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    class GuestController
    {
        #region Members
        private string name;
        private string surname;
        private int ID;
        private DateTime date;
        private bool status;
        #endregion
        #region Properties
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
        public int GuestID
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
        #endregion

        public bool CheckStatus()
        {
            // check the status of a guest, wheter its a new or existing guest
            return true;
        }
        public void CreateGuest(string name, string surname, int id, string email, int phoneNo, string address)
        {
            if(CheckStatus() == true)
            {
               // move to the payment form
            }
            else
            {
                //create a new guest
                new Guest(name, surname, id, email, phoneNo, address);
            }
        }
        public override string ToString()
        {
            return name + "\n" + surname + "\n" + ID;
        }
    }
}
