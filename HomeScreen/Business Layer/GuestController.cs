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
        private GuestDB guestDB;
        private Collection<Guest> guests;

        public Collection<Guest> AllGuests
        {
            get
            {
                return guests;
            }
        }
        public GuestController()
        {
            guestDB = new GuestDB();
            guests = guestDB.AllGuests;
        }
        public void DataMaintenance(Guest gst, DB.DBOperation operation)
        {
            int index = 0;
            guestDB.DataSetChange(gst, operation);
            switch (operation)
            {
                case DB.DBOperation.Add:
                    guests.Add(gst);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(gst);
                    guests[index] = gst;  
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(gst);  
                    guests.RemoveAt(index); 
                    break;
            }
        }

        public bool FinalizeChanges(Guest gst)
        {
            return true;
        }


        #region Search Methods
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

            foreach (Guest gstt in guests)
            {
                if (guestDB.AllGuests.Equals(gst))
                {
                    matches.Add(gstt);
                }
            }
            return matches;
        }
        public Guest Find(long ID)
        {
            int index = 0;
            bool found = (guests[index].GuestID.Equals(ID));  
            int count = guests.Count;
            while (!(found) && (index < guests.Count - 1))  //if not "this" student and you are not at the end of the list 
            {
                index = index + 1;
                found = (guests[index].GuestID.Equals(ID));   // this will be TRUE if found
            }
            return guests[index];  // this is the one!  
        }

        public int FindIndex(Guest gst)
        {
            int counter = 0;
            bool found = false;
            found = (gst.GuestID == guests[counter].GuestID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < guests.Count - 1)
            {
                counter += 1;
                found = (gst.GuestID == guests[counter].GuestID);
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
