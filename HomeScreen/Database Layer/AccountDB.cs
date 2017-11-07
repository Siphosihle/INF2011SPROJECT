using System;
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
    public class AccountDB: DB
    {

        private string table1 = "Accounts";
        private string sqlLocal1 = "SELECT * FROM Accounts";

        private Collection<Account> accounts;



        public AccountDB(): base()
        {
            accounts = new Collection<Account>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
        }

        #region Properties

        public Collection<Account> AllAccounts
        {
            get { return accounts; }
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

            Account anAccount;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    anAccount = new Account();
                    anAccount.AccountID = Convert.ToInt32(myRow["AccountID"]);
                    anAccount.GuestID = Convert.ToInt32(myRow["GuestID"]);
                    anAccount.Balance = Convert.ToDecimal(myRow["Balance"]);
                    accounts.Add(anAccount);
                }
            }

        }




        }
}
