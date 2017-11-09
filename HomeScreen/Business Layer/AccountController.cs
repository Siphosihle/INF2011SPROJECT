using HomeScreen.Database_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class AccountController
    {
        AccountDB accountDB;
        Collection<Account> accounts;

        #region Properties

        public Collection<Account> AllAccounts
        {
            get
            {
                return accounts;
            }
        }

        #endregion

        public AccountController()
        {
            accountDB = new AccountDB();
            accounts = accountDB.AllAccounts;
        }


        #region Database Communication
        public void DataMaintenance(Account anAccount, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in memory;
            accountDB.DataSetChange(anAccount, operation);
            //perform operations on the collection
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the employee to the Collection
                    accounts.Add(anAccount);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(anAccount);
                    accounts[index] = anAccount;  // replace employee at this index with the updated employee
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(anAccount);  // find the index of the specific employee in collection
                    accounts.RemoveAt(index);  // remove that employee form the collection
                    break;
            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Account acc)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return accountDB.UpdateDataSource(acc);
        }
        #endregion

        #region Search Methods
        //This method  (function) searched through all the employess to finds onlly those with the required role
        public Collection<Account> FindByAccountID(Collection<Account> collection, Account acc)
        {
            Collection<Account> matches = new Collection<Account>();

            foreach (Account act in collection)
            {
                if (accountDB.AllAccounts.Equals(acc))
                {
                    matches.Add(act);
                }
            }
            return matches;
        }

        public Collection<Account> FindByAccountID(Account acc)
        {
            Collection<Account> matches = new Collection<Account>();

            foreach (Account act in accounts)
            {
                if (accountDB.AllAccounts.Equals(acc))
                {
                    matches.Add(act);
                }
            }
            return matches;
        }
        //This method receives a employee ID as a parameter; finds the employee object in the collection of employees and then returns this object
        public Account Find(string ID)
        {
            int index = 0;
            bool found = (accounts[index].AccountID == ID);  //check if it is the first student
            int count = accounts.Count;
            while (!(found) && (index < accounts.Count - 1))  //if not "this" student and you are not at the end of the list 
            {
                index = index + 1;
                found = (accounts[index].AccountID == ID);   // this will be TRUE if found
            }
            return accounts[index];  // this is the one!  
        }

        public int FindIndex(Account anAccount)
        {
            int counter = 0;
            bool found = false;
            found = (anAccount.AccountID == accounts[counter].AccountID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < accounts.Count - 1)
            {
                counter += 1;
                found = (anAccount.AccountID == accounts[counter].AccountID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
        #endregion 
    }
}
