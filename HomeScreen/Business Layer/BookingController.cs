using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeScreen.Database_Layer;

namespace HomeScreen.Business_Layer
{
    public class BookingController
    {
        RestEasyDB bookingDB;
        

        Collection<Booking> bookings;
        Collection<Room> rooms;

        #region Properties
        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        #endregion

        public BookingController()
        {
            bookingDB = new RestEasyDB();
            bookings = bookingDB.AllBookings;
        }

        internal void CheckAvailability()
        {

            throw new NotImplementedException();
        }

        internal void CalculateDeposit()
        {
            throw new NotImplementedException();
        }

        /*
        #region Database Communication
        public void DataMaintenance(Booking aBooking, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            bookingDB.DataSetChange(aBooking, operation);
            //perform operations on the collection
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the employee to the Collection
                    bookings.Add(aBooking);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aBooking);
                    bookings[index] = aBooking;  // replace employee at this index with the updated employee
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(aBooking);  // find the index of the specific employee in collection
                    bookings.RemoveAt(index);  // remove that employee form the collection
                    break;
            }
        }
        */

        public double CalculateNoOfRooms(double noOfGuests)
        {
            if (noOfGuests <= 4)
            {
                return 1;
            }
            else if (noOfGuests > 4)
            {
                return Math.Ceiling(noOfGuests / 4);
            }
            else return 0;

        }

        internal int GenerateReferenceNumber()
        {
            throw new NotImplementedException();
        }

        /*
        //***Commit the changes to the database
        public bool FinalizeChanges(Booking employee)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return employeeDB.UpdateDataSource(employee);
        }
        #endregion

        #region Search Methods
        //This method  (function) searched through all the employess to finds onlly those with the required role
        public Collection<Booking> FindByRole(Collection<Booking> emps, Role.RoleType roleVal)
        {
            Collection<Booking> matches = new Collection<Booking>();

            foreach (Booking emp in emps)
            {
                if (emp.role.RoleValue == roleVal)
                {
                    matches.Add(emp);
                }
            }
            return matches;
        }

        
        //This method receives a employee ID as a parameter; finds the employee object in the collection of employees and then returns this object
        public Booking Find(string ID)
        {
            int index = 0;
            bool found = (bookings[index].ID == ID);  //check if it is the first student
            int count = bookings.Count;
            while (!(found) && (index < bookings.Count - 1))  //if not "this" student and you are not at the end of the list 
            {
                index = index + 1;
                found = (bookings[index].ID == ID);   // this will be TRUE if found
            }
            return bookings[index];  // this is the one!  
        }

        public int FindIndex(Booking aBooking)
        {
            int counter = 0;
            bool found = false;
            found = (anEmp.ID == bookings[counter].ID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < bookings.Count - 1)
            {
                counter += 1;
                found = (anEmp.ID == bookings[counter].ID);
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
    #endregion */

    }
}
