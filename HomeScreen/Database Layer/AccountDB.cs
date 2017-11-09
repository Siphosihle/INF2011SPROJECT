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
    public class AccountDB : DB
    {

        private string table1 = "Accounts";
        private string sqlLocal1 = "SELECT * FROM Accounts";

        private Collection<Account> accounts;


        public struct ColumnAttribs
        {
            public string myName;
            public SqlDbType myType;
            public int mySize;
        }
        public AccountDB() : base()
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
        #region Database Operations CRUD --- Add the object's values to the database
        public void DataSetChange(Account acc, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, acc, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(acc, dataTable)];
                    FillRow(aRow, acc, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(acc, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Methods
        private int FindRow(Account acc, string dataTable)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table1].Rows)
            {
                myRow = myRow_loopVariable;
                //Ignore rows marked as deleted in dataset
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //In c# there is no item property (but we use the 2-dim array) it is automatically known to the compiler when used as below
                    if (acc.AccountID == Convert.ToString(dsMain.Tables[table1].Rows[rowIndex]["AccountID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }

        private void FillRow(DataRow aRow, Account acc, DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["AccountID"] = acc.AccountID;
                aRow["GuestID"] = acc.GuestID;                //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["Balance"] = acc.Balance;
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
                    anAccount.AccountID = Convert.ToString(myRow["AccountID"]);
                    anAccount.GuestID = Convert.ToString(myRow["GuestID"]);
                    anAccount.Balance = Convert.ToDecimal(myRow["Balance"]);
                    accounts.Add(anAccount);
                }
            }
        }
        #endregion
        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Account acc)
        {
            //Create Parameters to communicate with SQL INSERT
            //https://www.google.co.za/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=size+in+bytes+of+Int+in+SQL
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@AccountID", SqlDbType.NVarChar, 15, "AccountID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 10, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@Balance", SqlDbType.NVarChar, 100, "Balance");
            daMain.InsertCommand.Parameters.Add(param);
            //***https://msdn.microsoft.com/en-za/library/ms179882.aspx
        }

        private void Build_UPDATE_Parameters(Account acc)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 100, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Balance", SqlDbType.NVarChar, 100, "Balance");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters()
        {
            //--Create Parameters to communicate with SQL DELETE
            SqlParameter param;
            param = new SqlParameter("@AccountID", SqlDbType.NVarChar, 15, "AccountID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }
        private void Create_INSERT_Command(Account acc)
        {
            //Create the command that must be used to insert values into the Books table..
            daMain.InsertCommand = new SqlCommand("INSERT into Accounts (AccountID, GuestID, Balance) VALUES (@AccountID, @GuestID, @Balance)", cnMain);
            Build_INSERT_Parameters(acc);
        }

        private void Create_UPDATE_Command(Account acc)
        {
            //Create the command that must be used to insert values into one of the three tables
            //Assumption is that the ID and EMPID cannot be changed
            daMain.UpdateCommand = new SqlCommand("UPDATE Accounts SET Balance =@Balance, " + "WHERE AccountID = @Original_ID", cnMain);
            Build_UPDATE_Parameters(acc);
        }

        private string Create_DELETE_Command(Account acc)
        {
            string errorString = null;
            //Create the command that must be used to delete values from the the appropriate table
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Accounts WHERE AccountID = @AccountID", cnMain);
            try
            {
                Build_DELETE_Parameters();
            }
            catch (Exception errObj)
            {
                errorString = errObj.Message + "  " + errObj.StackTrace;
            }
            return errorString;
        }
        public bool UpdateDataSource(Account acc)
        {
            bool success = true;
            Create_INSERT_Command(acc);
            Create_UPDATE_Command(acc);
            Create_DELETE_Command(acc);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }
        #endregion
    }
}
