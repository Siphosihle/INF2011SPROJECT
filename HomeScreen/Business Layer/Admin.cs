﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    class Admin
    {
        public readonly string admin1 = "Siphosihle";
        public readonly string admin2 = "Hannan";
        public string adminPassword = "inf2011sproject";
        public string username;
        public string userpassword;
        public bool accessGranted;

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
        public bool Login(string name, string password)
        {
            if (name.Equals(admin1)) 
            {
                if(password.Equals(adminPassword))
                {
                    accessGranted = true;
                }
            }
            else
            {
                accessGranted =  false;
            }
            return accessGranted; 
        }
    }
}
