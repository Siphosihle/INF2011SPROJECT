using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class Type
    {
        public enum GuestType
        {
            ExistingGuest = 0,
            NewGuest = 1
        }
        protected GuestType typevalue;
        protected string description;
        private string surname;
        private string address;
        private string email;
        private string name;
        private int phoneNo;
        private string guestID;
        private bool status = false;
        public Type type;
        private GuestType guestType;

        #region Properties
        public GuestType TypeValue
        {
            get
            {
                return typevalue;
            }
            set
            {
                typevalue = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        #endregion

        public Type(string name, string surname, string id)
        {
            typevalue = GuestType.ExistingGuest;
            description = "Existing Guest";
        }
        public Type(string name, string surname, string id, int phone, string email, string address)
        {
            typevalue = GuestType.NewGuest;
            description = "New Guest";
        }

        public Type(GuestType guestType)
        {
            this.guestType = guestType;
        }
    }
}
