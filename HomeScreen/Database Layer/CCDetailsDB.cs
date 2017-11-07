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
    public class CCDetailsDB: DB
    {

        private string table1 = "CCDetails";
        private string sqlLocal1 = "SELECT * FROM CCDetails";

        private Collection<CC> creditCards;



        public CCDetailsDB(): base()
        {
            creditCards = new Collection<CC>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
        }

        #region Properties

        public Collection<CC> AllCCs
        {
            get { return creditCards; }
        }

        #endregion

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;

            CC aCreditCard;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aCreditCard = new CC();
                    aCreditCard.CCID = Convert.ToInt32(myRow["CCID"]);
                    aCreditCard.Name = Convert.ToString(myRow["Name"]);
                    aCreditCard.CCNo = Convert.ToString(myRow["CCNo"]);
                    aCreditCard.CVV = Convert.ToString(myRow["CVV"]);
                    aCreditCard.ExpiryDate = Convert.ToDateTime(myRow["ExpiryDate"]);

                    creditCards.Add(aCreditCard);


                }
            }

        }




    }
}
