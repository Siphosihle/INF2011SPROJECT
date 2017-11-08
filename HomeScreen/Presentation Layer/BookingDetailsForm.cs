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
        private RoomAllocationController rAllController;

        private Booking booking;
        private Hotel hotel;
        private Room room;

        private Collection<Booking> bookings;
        private Collection<Room> rooms;
        private Collection<Hotel> hotels;
        private Collection<Room> availableRooms;


        private DateTime startDate, endDate;
        private int noOfGuests, noOfRoomsNeeded;
        private string hotelName;
        private Booking bking;



        #endregion

        #region Contructors
        public BookingDetailsForm()
        {
            InitializeComponent();

            dtpCheckInDate.Enabled = false;
            dtpCheckOutDate.Enabled = false;
            cmbNoOfGuests.Enabled = false;

            bookingController = new BookingController();
            hotelController = new HotelController();
            roomController = new RoomController();
            rAllController = new RoomAllocationController();

            this.FormClosed += Form_Closed;


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

        #region GUI Events
        private void cmbNoOfGuests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbHotelName_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbNoOfGuests.Items.Clear();
            dtpCheckInDate.Enabled = true;
            dtpCheckInDate.MinDate = DateTime.Today;
            dtpCheckOutDate.Enabled = false;
            cmbNoOfGuests.Enabled = false;

            Hotel hotel = hotelController.Find(cmbHotelName.Text);

            Collection<Room> rooms = null;
            rooms = roomController.FindByHotel(roomController.AllRooms, Convert.ToInt32(hotel.HotelID));

            int noOfHotelRooms = 0;

            foreach (Room room in rooms)
            {
                noOfHotelRooms = noOfHotelRooms + room.NoOfPeople;
            }

            for (int i = 0; i < noOfHotelRooms; i++)
            {
                cmbNoOfGuests.Items.Add(i + 1);
            }


        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            hotelName = cmbHotelName.Text;
            startDate = dtpCheckInDate.Value;
            endDate = dtpCheckOutDate.Value;
            noOfGuests = Convert.ToInt32(cmbNoOfGuests.Text);
            noOfRoomsNeeded = noOfGuests;
            hotel = hotelController.Find(hotelName);

            PopulateObject();
            availableRooms = rAllController.AvailableRooms(hotel, startDate, endDate);

            if (availableRooms.Count > noOfRoomsNeeded)
            {
                MessageBox.Show("Rooms Are Available!");

                bookingFormClosed = true;
                this.Close();

                availableRoomsForm = new AvailableRoomsForm(availableRooms, hotel, booking);
                availableRoomsForm.MdiParent = this.MdiParent;
                availableRoomsForm.StartPosition = FormStartPosition.CenterParent;

                availableRoomsForm.Show();
            }
            else
            {
                MessageBox.Show("There are no rooms available for the selected dates");
                this.Close();

                availableRoomsForm = new AvailableRoomsForm(availableRooms, hotel, booking);
                availableRoomsForm.MdiParent = this.MdiParent;
                availableRoomsForm.StartPosition = FormStartPosition.CenterParent;
                availableRoomsForm.Show();
            }

            ClearAll();
        }
        #endregion

        #region Methods
        private void ClearAll()
        {
            //throw new NotImplementedException();
        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckOutDate.Enabled = true;
            dtpCheckOutDate.MinDate = dtpCheckInDate.Value.AddDays(1);
            dtpCheckOutDate.MaxDate = new DateTime(2017,12,31);
        }

        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {

        }

        public void PopulateObject()
        {



            booking = new Booking();
            booking.ReservationNumber = Convert.ToString(bookingController.GenerateReferenceNumber(bookingController.AllBookings.Count));
            booking.NoOfRooms = Convert.ToString(bookingController.CalculateNoOfRooms(Convert.ToDouble(cmbNoOfGuests.Text)));
            booking.StartDate = dtpCheckInDate.Value;
            booking.EndDate = dtpCheckOutDate.Value;
            booking.SentConfirmation = false;
            booking.RecievedDeposit = false;
            booking.IsCancelled = false;
            

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

        #endregion

        


        
        

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
