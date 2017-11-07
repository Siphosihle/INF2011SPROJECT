﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class Room
    {

        //businesslayerformat
        //variables
        //properties
        //constructors

        private int roomID;
        private int hotelID;
        private int roomNo;
        private int noOfPeople;

        private Collection<Booking> bookings;

        public Room()
        {
            this.bookings = new Collection<Booking>();
        }

        #region Properties
        
        public int RoomID
        {
            get
            {
                return roomID;
            }
            set
            {
                roomID = value;
            }
        }

            public int HotelID
        {
            get
            {
                return hotelID;
            }
            set
            {
                hotelID = value;
            }
        }

        public int RoomNo
        {
            get
            {
                return roomNo;
            }
            set
            {
                roomNo = value;
            }
        }

        public int NoOfPeople
        {
            get { return noOfPeople; }
            set { noOfPeople = value; }
        }

    }



        #endregion

        //public bool RoomAvailability(string roomNo, Date startDate, Date endDate)
        //{

        //}
    }

