using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class Admin
    {

        //businesslayerformat
        //variables
        //properties
        //constructors

        private string username;
        private string password;

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

        public Admin()
        {

        }

        
    }
}
