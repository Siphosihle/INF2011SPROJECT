using HomeScreen.Database_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class GuestController
    {
        GuestDB guestDB;
        Collection<Guest> guest;
        public GuestController()
        {
            guestDB = new GuestDB();
            guest = guestDB.AllGuests;
        }
        public void DataMaintenance(Guest gst, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in memory; 
            guestDB.DataSetChange(gst, operation);
            //perform operations on the collection
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the employee to the Collection
                    guest.Add(gst);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(gst);
                    guest[index] = gst;  // replace employee at this index with the updated employee
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(gst);  // find the index of the specific employee in collection
                    guest.RemoveAt(index);  // remove that employee form the collection
                    break;
            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Guest gst)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return guestDB.UpdateDataSource(gst);
        }


        #region Search Methods
        //This method  (function) searched through all the employess to finds onlly those with the required role
        public Collection<Guest> FindByGuestID(Collection<Guest> coll, Guest gst)
        {
            Collection<Guest> matches = new Collection<Guest>();

            foreach (Guest gstt in coll)
            {
                if (guestDB.AllGuests.Equals(gst))
                {
                    matches.Add(gstt);
                }
            }
            return matches;
        }

        public Collection<Guest> FindByGuestID(Guest gst)
        {
            Collection<Guest> matches = new Collection<Guest>();

            foreach (Guest gstt in guest)
            {
                if (guestDB.AllGuests.Equals(gst))
                {
                    matches.Add(gstt);
                }
            }
            return matches;
        }
        //This method receives a employee ID as a parameter; finds the employee object in the collection of employees and then returns this object
        public Guest Find(string ID)
        {
            int index = 0;
            bool found = (guest[index].GuestID == ID);  //check if it is the first student
            int count = guest.Count;
            while (!(found) && (index < guest.Count - 1))  //if not "this" student and you are not at the end of the list 
            {
                index = index + 1;
                found = (guest[index].GuestID == ID);   // this will be TRUE if found
            }
            return guest[index];  // this is the one!  
        }

        public int FindIndex(Guest gst)
        {
            int counter = 0;
            bool found = false;
            found = (gst.GuestID == guest[counter].GuestID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < guest.Count - 1)
            {
                counter += 1;
                found = (gst.GuestID == guest[counter].GuestID);
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
