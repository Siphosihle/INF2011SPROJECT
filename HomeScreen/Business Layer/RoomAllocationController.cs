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

        public delegate void AvailRoomsInstEventHandler(Collection<Room> availrms);
        public event AvailRoomsInstEventHandler AvailRoomsInst;

        private RoomAllocationDB roomAllocationDB;
        private Collection<RoomAllocation> roomAllocations;   //***W3

        private RoomController roomcontroller;
        private BookingController bookingController;

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

            roomcontroller = new RoomController();
            bookingController = new BookingController();
        }

        public Collection<Booking> FindBookingsByRoom(Collection<Booking> bkings, Hotel htl)
        {
            Collection<Booking> matches = new Collection<Booking>();

            Collection<Room> hotelRooms = roomcontroller.FindByHotel(roomcontroller.AllRooms, htl.HotelID);

            //room1 A1
            //room1 A2



            
                for (int h = 0; h < hotelRooms.Count;h++)
                {

                    int roomID = hotelRooms[h].RoomID;
                    if (roomAllocations[h].RoomID == roomID)
                    {

                        for (int j = 0; j < roomAllocations.Count; j++)
                        {
                            if (roomAllocations[j].ReservationNumber.Equals(bkings[j].ReservationNumber))
                            {

                                matches.Add(bkings[j]);
                            }
                        }
                    }

                }

            

            return matches;

        }

        public Collection<Room> FindRoomsByBooking(Collection<Room> rms, int resNo)
        {
            Collection<Room> matches = new Collection<Room>();

            for (int i = 0; i < roomAllocations.Count; i++)
            {
                if (roomAllocations[i].ReservationNumber == resNo)
                {
                    for (int j = 0; j < roomAllocations.Count; i++)
                    {
                        if (roomAllocations[i].RoomID == rms[i].RoomID)
                        {
                            matches.Add(rms[i]);
                        }
                    }
                }
            }

            return matches;
        }

        public bool CheckAvailability(Hotel hotel, DateTime startDate, DateTime endDate, int roomsNeeded)
        {
            Collection<Room> matches = new Collection<Room>();

            Collection<Booking> hotelRoomBookings = FindBookingsByRoom(bookingController.AllBookings, hotel);
            if (hotelRoomBookings.Count < 1)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < roomcontroller.FindByHotel(roomcontroller.AllRooms, hotel.HotelID).Count; i++)
                {
                    bool roomAvailable = true;


                    {
                        for (int j = 0; j < hotelRoomBookings.Count; j++)
                        {
                            if ((startDate < hotelRoomBookings[j].EndDate || endDate > hotelRoomBookings[j].StartDate))
                            {
                                roomAvailable = false;
                            }
                        }
                        if (roomAvailable == true)
                        {
                            matches.Add(roomcontroller.AllRooms[i]);
                        }
                    }

                }



                if (matches.Count > roomsNeeded - 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }


        public Collection<Room> AvailableRooms(Hotel hotel, DateTime startDate, DateTime endDate)
        {

            //for each room in HotelRooms

            Collection<Room> matches = new Collection<Room>();
            Collection<Room> hotelRooms = roomcontroller.FindByHotel(hotel.HotelID);
            
            for (int i = 0; i < hotelRooms.Count;i++)
            {
                Collection<bool> roomAvailable = new Collection<bool>();
                Collection<Booking> roomBookings = bookingController.FindByRoom("rooms", hotelRooms[i].RoomID.ToString());
                for (int j = 0; j < roomBookings.Count; j++)
                {
                    if ((startDate < roomBookings[j].EndDate || endDate > roomBookings[j].StartDate))
                    {
                        roomAvailable[i] = false;
                    }
                }
                if (roomAvailable[i] == true)
                {
                    matches.Add(hotelRooms[i]);
                }
            }

            return matches;


            /*


            Collection<Room> htlRooms = roomcontroller.FindByHotel(hotel.HotelID);  //all rooms in hotel

            for (int i = 0; i < bookings.Count; i++)
            {
                if ()
            }

            //assuming 1 person per room
            //for each booking in rooms.bookings

            //for each room in hotel

            //if startdate is earlier than end date of abooking
            //or enddate is later than the startdate of abooking
            //where abooking.bookingID = rAll.bookingID
            //and where the room.roomID = rAll.roomID
            //and 

            /* room1
             *      
             * room2
             * room3
             * room4

            for (int i = 0; i < roomAllocations.Count; i++)
            {

            }

            Collection<Booking> bkngs = rAllController.FindBookingsByRoom();

            for (int i = 0; i < )



                while ((roomsAvail < roomsNeeded) && (x < hotel.Rooms.Count))
                {
                    while ((y < bookings.Count) && (bOccupied == false))
                    {
                        if ((startDate < bookings[y].EndDate || endDate > bookings[y].StartDate))
                        {
                            bOccupied = true;
                        }
                        y++;
                    }
                    if (bOccupied == false)
                    {
                        availableRooms[x] = x + 1;
                        roomsAvail++;
                    }
                    x++;
                }

            return (roomsAvail >= roomsNeeded);

            
             */

        }
        
        protected virtual void OnAvailRoomsInst(Collection<Room> availrms)
        {
            if(AvailRoomsInst != null)
            {
                AvailRoomsInst(availrms);
            }
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
