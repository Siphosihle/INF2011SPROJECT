﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Xml;
//namespaces
using HomeScreen.Business_Layer;
using HomeScreen.Database_Layer;

namespace HomeScreen.Database_Layer
{
    public class AdminDB: DB
    {
        private string table1 = "Admins";
        private string sqlLocal1 = "SELECT * FROM Admins";

        private Collection<Admin> admins;
        

        public AdminDB(): base()
        {
            admins = new Collection<Admin>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);

        }

        public Collection<Admin> AllAdmins
        {
            get
            {
                return admins;
            }
        }
        public DataSet GetDataSet()
        {
            return dsMain;
        }

        #region Utility Methods
        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;
            Admin anAdmin;
            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {

                    anAdmin = new Admin();
                    anAdmin.Username = Convert.ToString(myRow["Username"]).TrimEnd();
                    anAdmin.Password = Convert.ToString(myRow["Password"]).TrimEnd();

                    admins.Add(anAdmin);
                }
            }
        }
        private void FillRow(DataRow aRow, Admin anAdmin, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["Username"] = anAdmin.Username;  //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["Password"] = anAdmin.Password;

        }

        private int FindRow(Admin anAdmin, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                //Ignore rows marked as deleted in dataset
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //In c# there is no item property (but we use the 2-dim array) it is automatically known to the compiler when used as below
                    if (anAdmin.Username == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["Username"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }
        #endregion


    }
}
