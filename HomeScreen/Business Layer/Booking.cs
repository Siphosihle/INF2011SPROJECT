﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeScreen.Business_Layer;

namespace HomeScreen.Business_Layer
{
    public class Booking
    {
        //businesslayerformat
        //variables
        //properties
        //constructors

        private string reservationNumber;
        private string guestID;
        private string noOfPeople;
        private string noOfRooms;
        private DateTime startDate;
        private DateTime endDate;
        bool sentConfirmation, receivedDeposit, isCancelled;

        public Collection<Room> rooms;

        private Calendar myCal = CultureInfo.InvariantCulture.Calendar;
        private DateTime date;


        #region Properties

        public Collection<Room> Rooms
        {
            get
            {
                return rooms;
            }
        }
        public string ReservationNumber
        {
            get
            {
                return reservationNumber;
            }
            set
            {
                reservationNumber = value;
            }
        }
        public string GuestID
        {
            get
            {
                return guestID;
            }
            set
            {
                guestID = value;
            }
        }
        public string NoOfPeople
        {
            get
            {
                return noOfPeople;
            }
            set
            {
                noOfPeople = value;
            }
        }
        public string NoOfRooms
        {
            get
            {
                return noOfRooms;
            }
            set
            {
                noOfRooms = value;
            }
        }
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }
        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
            }
        }
        public bool SentConfirmation
        {
            get
            {
                return sentConfirmation;
            }
            set
            {
                sentConfirmation = value;
            }
        }
        public bool RecievedDeposit
        {
            get
            {
                return receivedDeposit;
            }
            set
            {
                receivedDeposit = value;
            }
        }
        public bool IsCancelled
        {
            get
            {
                return isCancelled;
            }
            set
            {
                isCancelled = value;
            }
        }
        #endregion

        #region Constructors

        public Booking()
        {

            this.rooms = new Collection<Room>();

        }

        #endregion

        #region Methods
        public void CreateBooking(DateTime start, DateTime end, string duration, int no)
        {

        }
        public double CalculateDeposit(string reservation, string refNo)
        {
            double amount = 0;
            return amount;
        }
        public bool GenerateConfirmationLetter(string refNo)
        {
            return true;
        }
        #endregion

    }
}
