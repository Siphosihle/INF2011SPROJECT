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
        private BookingDB bookingDB;
        private Collection<Booking> bookings;
        private Collection<Room> availableRooms;
        private RoomAllocationController rAllController;

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
            bookingDB = new BookingDB("all","");
            bookings = bookingDB.AllBookings;
        }

        

        public decimal CalculateDeposit()
        {
            return 0;
        }

        
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
            else
            {
                return -1;
            }

        }

        internal int GenerateReferenceNumber(int noOfBookings)
        {
            return noOfBookings + 1;
        }




        //***Commit the changes to the database
        
        public bool FinalizeChanges(Booking booking)
        {
            return bookingDB.UpdateDataSource(booking);
        } 
        #endregion

        #region Search Methods

        public Collection<Booking> FindByRoom(string table, string searchBy)
        {
            BookingDB roomBookingDB = new BookingDB(table, searchBy);

            return roomBookingDB.AllBookings;
        }

        



        public Booking Find(int resNo)
        {
            int index = 0;
            bool found = (bookings[index].ReservationNumber.Equals(resNo));  //check if it is the first student
            int count = bookings.Count;
            while (!(found) && (index < bookings.Count - 1))  //if not "this" student and you are not at the end of the list 
            {
                index = index + 1;
                found = (bookings[index].ReservationNumber.Equals(resNo));   // this will be TRUE if found
            }
            return bookings[index];  // this is the one!  
        }

        public int FindIndex(Booking aBooking)
        {
            int counter = 0;
            bool found = false;
            found = (aBooking.ReservationNumber == bookings[counter].ReservationNumber);   //using a Boolean Expression to initialise found
            while (!(found) & counter < bookings.Count - 1)
            {
                counter += 1;
                found = (aBooking.ReservationNumber == bookings[counter].ReservationNumber);
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
