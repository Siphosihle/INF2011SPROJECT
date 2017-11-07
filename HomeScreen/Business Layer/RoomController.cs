using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeScreen.Database_Layer;
using HomeScreen.Business_Layer;

namespace HomeScreen.Database_Layer
{
    class RoomController
    {
        RoomDB roomDB;
        Collection<Room> rooms;   //***W3

        #region Properties
        public Collection<Room> AllRooms
        {
            get
            {
                return rooms;
            }
        }
        #endregion

        public RoomController()
        {
            //***instantiate the EmployeeDB object to communicate with the database
            roomDB = new RoomDB();
            rooms = roomDB.AllRooms;
        }

        #region Database Communication
        /*public void DataMaintenance(Room aRoom, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            roomDB.DataSetChange(anEmp, operation);
            //perform operations on the collection
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the employee to the Collection
                    employees.Add(anEmp);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(anEmp);
                    employees[index] = anEmp;  // replace employee at this index with the updated employee
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(anEmp);  // find the index of the specific employee in collection
                    employees.RemoveAt(index);  // remove that employee form the collection
                    break;
            }
        } */

        //***Commit the changes to the database
        /*public bool FinalizeChanges(Room room)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return roomDB.UpdateDataSource(room);
        }*/
        #endregion

        #region Search Methods
        //This method  (function) searched through all the employess to finds onlly those with the required role
        public Collection<Room> FindByHotel(Collection<Room> rooms, int hotelID)
        {
            Collection<Room> matches = new Collection<Room>();

            foreach (Room room in rooms)
            {
                if (room.HotelID == hotelID)
                {
                    matches.Add(room);
                }
            }
            return matches;
        }

        public Collection<Room> FindByHotel(int hotelID)
        {
            Collection<Room> matches = new Collection<Room>();

            foreach (Room room in rooms)
            {
                if (room.HotelID == hotelID)
                {
                    matches.Add(room);
                }
            }
            return matches;
        }

        /*public Employee Find(string ID)
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
        }

        public int FindIndex(Employee anEmp)
        {
            int counter = 0;
            bool found = false;
            found = (anEmp.ID == employees[counter].ID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < employees.Count - 1)
            {
                counter += 1;
                found = (anEmp.ID == employees[counter].ID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        } */
        #endregion
    
}
}
