using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeScreen.Database_Layer;

namespace HomeScreen.Business_Layer
{
    public class RoomAllocationController
    {

        private RoomAllocationDB roomAllocationDB;
        private Collection<RoomAllocation> roomAllocations;   //***W3

        #region Properties
        public Collection<RoomAllocation> AllRoomAllocations
        {
            get
            {
                return roomAllocations;
            }
        }

        #endregion

        public RoomAllocationController()
        {
            //***instantiate the EmployeeDB object to communicate with the database
            roomAllocationDB = new RoomAllocationDB();
            roomAllocations = roomAllocationDB.AllRoomAllocations;
        }



        /*public RoomAllocation Find(string htlName)
        {
            int index = 0;
            bool found = (public RoomAllocation Find(string htlName)[index].HotelName == htlName);  //check if it is the first student
            int count = hotels.Count;
            while (!(found) && (index < hotels.Count - 1))  //if not "this" student and you are not at the end of the list 
            {
                index = index + 1;
                found = (hotels[index].HotelName == htlName);   // this will be TRUE if found
            }
            return hotels[index];  // this is the one!  
        }

        public int FindIndex(Hotel aHotel)
        {
            int counter = 0;
            bool found = false;
            found = (aHotel.HotelID == hotels[counter].HotelID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < hotels.Count - 1)
            {
                counter += 1;
                found = (aHotel.HotelID == hotels[counter].HotelID);
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
        */
        

    }
}
