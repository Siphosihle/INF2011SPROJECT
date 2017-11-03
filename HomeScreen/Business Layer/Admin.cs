using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class Admin
    {
        public string username;
        public string password;
        public static bool accessGranted;

        #region Properties
        
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
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        #endregion

        /*public bool Login(string name, string password)
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
        }*/
    }
}
