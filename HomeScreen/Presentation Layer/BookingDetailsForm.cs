using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeScreen.Business_Layer;
using HomeScreen.Database_Layer;

namespace HomeScreen.Presentation_Layer
{
    public partial class BookingDetailsForm : Form
    {

        #region Members

        public bool bookingFormClosed = false;
        private AvailableRoomsForm availableRoomsForm;

        private BookingController bookingController;
        private HotelController hotelController;
        private RoomController roomController;

        private Booking booking;
        private Hotel hotel;
        private Room room;

        private Collection<Booking> bookings;
        private Collection<Room> rooms;
        private Collection<Hotel> hotels;

        private DateTime startDate, endDate;
        private int noOfGuests, noOfRoomsNeeded;
        private string hotelName;



        #endregion

        #region Contructors
        public BookingDetailsForm()
        {
            InitializeComponent();

            bookingController = new BookingController();
            hotelController = new HotelController();
            roomController = new RoomController();

            this.FormClosed += Form_Closed;

            for (int s = 1; s < 21; s++)
            {
                string strt = s.ToString();
                cmbNoOfGuests.Items.Add(strt);
            }
        }
        #endregion

        #region Properties
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
        public int NoOfRoomsNeeded
        {
            get
            {
                return noOfRoomsNeeded;
            }
            set
            {
                noOfRoomsNeeded = value;
            }
        }
        public int NoOfGuests
        {
            get
            {
                return noOfGuests;
            }
            set
            {
                noOfGuests = value;
            }
        }
        #endregion

        #region FormEvents

        private void BookingDetailsForm_Load(object sender, EventArgs e)
        {
            PopulateForm();

        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            bookingFormClosed = true;
        }


        #endregion



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            hotelName = cmbHotelName.Text;
            startDate = dtpCheckInDate.Value;
            endDate = dtpCheckOutDate.Value;
            noOfGuests = Convert.ToInt32(cmbNoOfGuests.Text);
            noOfRoomsNeeded = noOfGuests;

            hotel = hotelController.Find(hotelName);

            if (bookingController.CheckAvailability(hotel, startDate, endDate, noOfRoomsNeeded))
            {
                MessageBox.Show("Rooms Are Available!");

                bookingFormClosed = true;
                this.Close();

                availableRoomsForm = new AvailableRoomsForm(bookingController);
                availableRoomsForm.MdiParent = this.MdiParent;
                availableRoomsForm.StartPosition = FormStartPosition.CenterParent;
        

            }
            else
            {
                MessageBox.Show("There are no rooms available for the selected dates");
            }

            ClearAll();
        }


        private void ClearAll()
        {
            throw new NotImplementedException();
        }

        public void PopulateObject()
        {



            booking = new Booking();
            booking.ReservationNumber = bookingController.GenerateReferenceNumber();
            booking.NoOfRooms = Convert.ToInt32(bookingController.CalculateNoOfRooms(Convert.ToDouble(cmbNoOfGuests.Text)));
            booking.StartDate = dtpCheckInDate.Value;
            booking.EndDate = dtpCheckOutDate.Value;
            booking.SentConfirmation = false;
            booking.RecievedDeposit = false;
            booking.IsCancelled = false;

            /*
            int num = 0;
            int nw = 0;
            inDate = dtpCheckInDate.Text;
            outDate = dtpCheckOutDate.Text;
            roomNum = cmbNumberOfRooms.Text;
            if (roomNum != "")
            {
                num = Int32.Parse(roomNum);
            }

            if (num > 5)
            {
                MessageBox.Show("The hotel only have 5 rooms");
            }
            guestNum = cmbNumberOfGuests.Text;
            if (guestNum != "")
            {
                nw = Int32.Parse(guestNum);
            }
            if ((guestNum == "") && (roomNum == ""))
            {
                MessageBox.Show("Please enter the Number of Rooms and Guests before you save!");
            }
            if (nw > 20)
            {
                MessageBox.Show("Only 20 guest can be accomodated at a time");
            }
            int mlt = num * 4;
            if (nw > mlt)
            {
                MessageBox.Show("A room can only accomodate 4 guests, please re-enter the number of guests!");
            }
            if (((num <= 5) && (nw <= 20) && (nw <= mlt)) && (guestNum != "") && (roomNum != ""))
            {
                MessageBox.Show("Check-In date: " + inDate + "\n" + "Check-Out Date: " + outDate + " \n" + "Rooms Required: " + roomNum + " rooms" + "\n" + "Guests Expected: " + guestNum + " guests");
            }
            if (((roomNum != "") && (guestNum == "")) || ((roomNum == "") && (guestNum != "")))
            {
                MessageBox.Show("Please complete the empty box!");
            }
            if ((roomNum != "") && (guestNum != ""))
            {
                count++;
            } */

        }

        public void PopulateForm()
        {
            hotels = hotelController.AllHotels;
            foreach (Hotel hotel in hotels)
            {
                string htlName = hotel.HotelName;
                cmbHotelName.Items.Add(htlName);
            }


            

            /*
            for (int s = 1; s < 21; s++)
            {
                string strt = s.ToString();
                cmbNoOfGuests.Items.Add(strt);
            }

            hotel = new Hotel();

            booking = new Booking();
            booking.ReservationNumber = bookingController.GenerateReferenceNumber();
            booking.NoOfRooms = Convert.ToInt32(bookingController.CalculateNoOfRooms(Convert.ToDouble(cmbNoOfGuests.Text)));
            booking.StartDate = dtpCheckInDate.Value;
            booking.EndDate = dtpCheckOutDate.Value;
            booking.SentConfirmation = false;
            booking.RecievedDeposit = false;
            booking.IsCancelled = false; */

        }

        private void cmbNoOfGuests_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }

        private void cmbHotelName_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbNoOfGuests.Items.Clear();

            Hotel hotel = hotelController.Find(cmbHotelName.Text);

            Collection<Room> rooms = null;
            rooms = roomController.FindByHotel(roomController.AllRooms, Convert.ToInt32(hotel.HotelID));

            int noOfHotelRooms = 0;

            foreach (Room room in rooms)
            {
                noOfHotelRooms = noOfHotelRooms + room.NoOfPeople;
            }

            for(int i=0;i<noOfHotelRooms;i++)
            {
                cmbNoOfGuests.Items.Add(i+1);
            }


        }

        private void btnCheckBooking_Click(object sender, EventArgs e)
            {

                int count = 1;
                
                if (count == 1)
                {
                    //AvailableRoomsForm hs = new AvailableRoomsForm();
                    this.Hide();
                    //hs.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please save the Booking Details first before you continue!");
                }
            }

            private void btnSave_Click(object sender, EventArgs e)
            {
                PopulateObject();

            }
        

        /*
private class Number
{
    public string Num;

    public Number(string num)
    {
        Num = num;
    }
    public override string ToString()
    {
        return Num;
    }
}
*/



    }
}
