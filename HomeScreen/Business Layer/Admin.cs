using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class Admin
    {
        public readonly string admin1 = "sipho";
        public readonly string admin2 = "Hannan";
        public readonly string adminPassword = "inf";
        public string username;
        public string userpassword;
        public static bool accessGranted;

        #region Properties
        public string Admin1
        {
            get
            {
                return admin1;
            }
        }
        public string Admin2
        {
            get
            {
                return admin2;
            }
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string UserPassword
        {
            get
            {
                return userpassword;
            }
            set
            {
                userpassword = value;
            }
        }
        #endregion

        public bool Login(string name, string password)
        {
            if (((admin1.Equals(name)) || (admin2.Equals(name))) && (adminPassword.Equals(password)))
            {
                accessGranted = true;

            }
            else
            {
                accessGranted =  false;
            }
            return accessGranted; 
        }
    }
}
