using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeScreen.Database_Layer;

namespace HomeScreen.Business_Layer
{
    public class HotelController
    {

        RestEasyDB hotelDB;
        Collection<Hotel> hotels;   //***W3

        #region Properties
        public Collection<Hotel> AllHotels
        {
            get
            {
                return hotels;
            }
        }
        #endregion

        public HotelController()
        {
            //***instantiate the EmployeeDB object to communicate with the database
            hotelDB = new RestEasyDB();
            hotels = hotelDB.AllHotels;
        }

        public Hotel Find(string hotelName)
        {
            int index = 0;
            try
            {
                bool found = (hotels[index].HotelName == hotelName);  //check if it is the first student
                int count = hotels.Count;
                while (!(found) && (index < hotels.Count - 1))  //if not "this" student and you are not at the end of the list 
                {
                    index = index + 1;
                    found = (hotels[index].HotelName == hotelName);   // this will be TRUE if found
                }
                return hotels[index];  // this is the one!  
            }
            catch (Exception e)
            {
                
            }
            
        }

    }
}
