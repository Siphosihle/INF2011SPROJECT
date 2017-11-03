using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; 
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using HomeScreen.Business_Layer;


namespace HomeScreen.Database_Layer
{
    class AdminDB: DB
    {

        #region Data Members
        private string table1 = "Admin";
        private string sqlLocal1 = "SELECT * FROM Admin";

        private Collection<Admin> admins;
        #endregion



    }
}
