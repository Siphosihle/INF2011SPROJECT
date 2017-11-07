﻿using HomeScreen.Database_Layer;
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
        /*public void DataMaintenance(Admin anAdmin, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in memory;
            accountDB.DataSetChange(anAdmin, operation);
            //perform operations on the collection
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the employee to the Collection
                    admins.Add(anAdmin);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(anAdmin);
                    admins[index] = anAdmin;  // replace employee at this index with the updated employee
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(anAdmin);  // find the index of the specific employee in collection
                    admins.RemoveAt(index);  // remove that employee form the collection
                    break;
            }
        }

        //***Commit the changes to the database
        /*public bool FinalizeChanges(Admin admin)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return adminDB.UpdateDataSource(admin);
        }
        #endregion

        #region Search Methods
        //This method  (function) searched through all the employess to finds onlly those with the required role
        public Collection<Employee> FindByRole(Collection<Employee> emps, Role.RoleType roleVal)
        {
            Collection<Employee> matches = new Collection<Employee>();

            foreach (Employee emp in emps)
            {
                if (emp.role.RoleValue == roleVal)
                {
                    matches.Add(emp);
                }
            }
            return matches;
        }

        public Collection<Employee> FindByRole(Role.RoleType roleVal)
        {
            Collection<Employee> matches = new Collection<Employee>();

            foreach (Employee emp in employees)
            {
                if (emp.role.RoleValue == roleVal)
                {
                    matches.Add(emp);
                }
            }
            return matches;
        }
        //This method receives a employee ID as a parameter; finds the employee object in the collection of employees and then returns this object
        public Admin Find(string ID)
        {
            int index = 0;
            bool found = (employees[index].ID == ID);  //check if it is the first student
            int count = employees.Count;
            while (!(found) && (index < employees.Count - 1))  //if not "this" student and you are not at the end of the list 
            {
                index = index + 1;
                found = (employees[index].ID == ID);   // this will be TRUE if found
            }
            return employees[index];  // this is the one!  
        } */

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