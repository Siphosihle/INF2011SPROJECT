using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2011SProject.Business_Layer
{
    class GuestController
    {
        #region Members
        private string name;
        private string surname;
        private string ID;
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
        public string GuestID
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
        public GuestController(string name, string surname, string ID)
        {
            this.name = name;
            this.surname = surname;
            this.ID = ID;
        }
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
                new Type(name, surname, ID,phoneNo, email, address);
            }
        }
        public override string ToString()
        {
            return name + "\n" + surname + "\n" + ID;
        }
    }
}
