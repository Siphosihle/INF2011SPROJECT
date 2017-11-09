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
    public partial class ListForm : Form
    {
        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }

        public bool confirmFormClosed = false;
        private GuestController guestController;
        private BookingController bookingController;

        private AccountController accountcontroller;
        private AdminController admincontroller;
        private HotelController hotelcontroller;
        private PaymentController paymentcontroller;
        private RoomController roomcontroller;

        private Guest guest;
        private Booking booking;

        private Collection<Guest> guests;
        private Collection<Booking> bookings;

        private FormStates state;

        private string table;

        public ListForm(GuestController aController)
        {
            InitializeComponent();

            guestController = aController;
            guests = guestController.AllGuests;
            bookingController = new BookingController();
            bookings = bookingController.AllBookings;

            //Set up Event Handlers for some form events in code rather than trhough the designer
            this.Load += ListForm_Load;
            this.Activated += ListForm_Activated;
            this.FormClosed += ListForm_FormClosed;
            state = FormStates.View;
        }

        public ListForm(Booking bking, Guest gst, Hotel htl)
        {
            InitializeComponent();

            guests = guestController.AllGuests;
            bookingController = new BookingController();
            bookings = bookingController.AllBookings;

            //Set up Event Handlers for some form events in code rather than trhough the designer
            this.Load += ListForm_Load;
            this.Activated += ListForm_Activated;
            this.FormClosed += ListForm_FormClosed;
            state = FormStates.View;
        }

        public ListForm(string tbl, string crudFunction)
        {
            InitializeComponent();

            table = tbl;



            switch (table)
            {
                case "booking":
                    bookingController = new BookingController();
                    break;
                case "guest":
                    guestController = new GuestController();
                    break;

                case "account":
                    accountcontroller = new AccountController();
                    break;
                case "admin":
                    admincontroller = new AdminController();
                    break;
                case "hotel":
                    guestController = new GuestController();
                    break;
                case "payment":
                    guestController = new GuestController();
                    break;
                case "room":
                    guestController = new GuestController();
                    break;

            }

            //Set up Event Handlers for some form events in code rather than trhough the designer
            this.Load += ListForm_Load;
            this.Activated += ListForm_Activated;
            this.FormClosed += ListForm_FormClosed;

            switch (crudFunction)
            {
                case "read":
                    state = FormStates.View;
                    break;
                case "update":
                    state = FormStates.Edit;
                    break;
                case "delete":
                    state = FormStates.Delete;
                    break;

            }
        }


        private void ListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            confirmFormClosed = true;
        }

        private void ListForm_Load(object sender, EventArgs e)
        {

        }

        private void ListForm_Activated(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            setUpListView();
            ShowAll1(false, table);
        }

        private void setUpListView()
        {

            ListViewItem sDetails;
            listView1.Clear();


            switch (table)
            {
                #region Guest Setup
                case "Guest":
                    listView1.Columns.Insert(0, "GuestID", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(1, "Name", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(2, "Surname", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(3, "PhoneNo", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(4, "Address", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(5, "Email", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(6, "Status", 120, HorizontalAlignment.Left);

                    Collection<Guest> guests = null;

                    guests = guestController.AllGuests;
                    listView1.Text = "Listing of all Guests";

                    foreach (Guest guest in guests)
                    {
                        sDetails = new ListViewItem();
                        sDetails.Text = guest.GuestID.ToString();
                        // Do the same for Gender, HomeLanguage, PopGroup and SA_Citizenship_Status
                        sDetails.SubItems.Add(guest.Name);
                        sDetails.SubItems.Add(guest.Surname);
                        sDetails.SubItems.Add(guest.PhoneNumber);
                        sDetails.SubItems.Add(guest.Address);
                        sDetails.SubItems.Add(guest.Email);
                        sDetails.SubItems.Add(guest.Status);
                        listView1.Items.Add(sDetails);
                    }

                    break;

                #endregion

                #region Booking Set Up

                case "booking":

                    listView1.Columns.Insert(0, "ReservationNumber", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(1, "GuestID", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(2, "NoOfRooms", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(3, "NoOfPeople", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(4, "StartDate", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(5, "EndDate", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(6, "SentConfirmation", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(7, "ReceivedConfirmation", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(8, "IsCancelled", 120, HorizontalAlignment.Left);

                    Collection<Booking> bookings = null;

                    bookings = bookingController.AllBookings;
                    listView1.Text = "Listing of all Bookings";

                    foreach (Booking booking in bookings)
                    {
                        sDetails = new ListViewItem();
                        sDetails.Text = booking.ReservationNumber.ToString();
                        sDetails.SubItems.Add(booking.GuestID.ToString());
                        sDetails.SubItems.Add(booking.NoOfRooms.ToString());
                        sDetails.SubItems.Add(booking.NoOfPeople.ToString());
                        sDetails.SubItems.Add(booking.StartDate.ToString());
                        sDetails.SubItems.Add(booking.EndDate.ToString());
                        sDetails.SubItems.Add(booking.SentConfirmation.ToString());
                        sDetails.SubItems.Add(booking.RecievedDeposit.ToString());
                        sDetails.SubItems.Add(booking.IsCancelled.ToString());
                        listView1.Items.Add(sDetails);
                    }

                    break;

                    #endregion

            }




            listView1.Refresh();
            listView1.GridLines = true;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll1(true, table);
            state = FormStates.View;
            ShowAll2(false, table);
            if (listView1.SelectedItems.Count > 0)   // if you selected an item 
            {
                booking = bookingController.Find(Convert.ToInt32(listView1.SelectedItems[0].Text));  //selected student becoms current student
                                                                                                     // Show the details of the selected student in the controls
                PopulateTextBoxes(guest, booking);
            }
        }
        private void ShowAll1(bool value, string tbl)
        {

            lbl1.Visible = value;
            lbl6.Visible = value;
            lbl9.Visible = value;
            lbl5.Visible = value;
            lbl8.Visible = value;
            lbl7.Visible = value;
            lbl2.Visible = value;
            lbl3.Visible = value;
            lbl4.Visible = value;

            i1.Visible = value;
            txt6.Visible = value;
            i2.Visible = value;
            txt9.Visible = value;
            txt4.Visible = value;
            txt3.Visible = value;
            txt8.Visible = value;
            txt5.Visible = value;
            txt7.Visible = value;

            if ((state == FormStates.Edit) && value)
            {
                i1.Enabled = !value;
                //do the same for all buttons & textboxes
                i2.Enabled = !value;
            }
            else
            {
                i1.Enabled = value;
                i1.Enabled = value;
            }



            if (state == FormStates.Delete)
            {
                btnCancel.Visible = !value;
                btnSubmit.Visible = !value;
            }
            else
            {
                btnCancel.Visible = value;
                btnSubmit.Visible = value;
            }

            switch (tbl)
            {
                case "guest":
                    lbl1.Text = "GuestID";
                    lbl2.Text = "Name";
                    lbl3.Text = "Surname";
                    lbl4.Text = "Phone Number";
                    lbl5.Text = "Address";
                    lbl6.Text = "Email";
                    lbl7.Text = "Status";

                    lbl8.Visible = !value;
                    txt9.Visible = !value;
                    lbl9.Visible = !value;
                    txt9.Visible = !value;

                    break;
            }





        }

        private void ShowAll2(bool value, string tbl)
        {
            if ((state == FormStates.Edit) && value)
            {
                switch (tbl)
                {
                    case "bookings":
                        i1.Enabled = !value;
                        //do the same for all buttons & textboxes
                        i2.Enabled = !value;
                        break;
                }

            }
            else
            {
                i1.Enabled = value;
                i2.Enabled = value;
            }
            txt3.Enabled = value;
            txt4.Enabled = value;
            txt5.Enabled = value;
            txt6.Enabled = value;
            txt7.Enabled = value;
            txt8.Enabled = value;
            txt9.Enabled = value;



            if (state == FormStates.Delete)
            {
                btnCancel.Visible = !value;
                btnSubmit.Visible = !value;
            }
            else
            {
                btnCancel.Visible = value;
                btnSubmit.Visible = value;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            state = FormStates.Edit;
            btnDelete.Visible = false;
            //PopulateObject();
            //bookingController.DataMaintenance(booking, Database_Layer.DB.DBOperation.Edit);
            ShowAll2(true, table);
        }
        private void ClearAll()
        {
            txt6.Text = "";
            i2.Text = "";
            txt9.Text = "";
            txt4.Text = "";
            txt3.Text = "";
            txt8.Text = "";
            i1.Text = "";
            txt7.Text = "";
            txt5.Text = "";
        }
        private void PopulateObject(string table)
        {
            switch (table)
            {
                case "booking":
                    booking = new Booking();
                    booking.ReservationNumber = Convert.ToInt32(i1.Text);
                    booking.GuestID = Convert.ToInt32(i2.Text);
                    booking.NoOfRooms = Convert.ToInt32(txt3.Text);
                    booking.NoOfPeople = Convert.ToInt32(txt4.Text);
                    booking.StartDate = Convert.ToDateTime(txt5.Text);
                    booking.EndDate = Convert.ToDateTime(txt6.Text);
                    booking.SentConfirmation = Convert.ToBoolean(txt7.Text);
                    booking.RecievedDeposit = Convert.ToBoolean(txt8.Text);
                    booking.IsCancelled = Convert.ToBoolean(txt9.Text);
                    break;
            }

        }
        private void PopulateTextBoxes(Guest gst, Booking bkg)
        {

            switch (table)
            {
                case "Guest":
                    i1.Text = Convert.ToString(gst.GuestID);
                    i2.Text = Convert.ToString(gst.Name);
                    txt3.Text = Convert.ToString(gst.Surname);
                    txt4.Text = Convert.ToString(gst.PhoneNumber);
                    txt5.Text = Convert.ToString(gst.Address);
                    txt6.Text = Convert.ToString(gst.Email);
                    txt7.Text = Convert.ToString(gst.Status);
                    break;
                case "booking":
                    i1.Text = Convert.ToString(bkg.ReservationNumber);
                    i2.Text = Convert.ToString(bkg.GuestID);
                    txt3.Text = Convert.ToString(bkg.NoOfRooms);
                    txt4.Text = Convert.ToString(bkg.NoOfPeople);
                    txt5.Text = Convert.ToString(bkg.StartDate);
                    txt6.Text = Convert.ToString(bkg.EndDate);
                    txt7.Text = Convert.ToString(bkg.SentConfirmation);
                    txt8.Text = Convert.ToString(bkg.RecievedDeposit);
                    txt9.Text = Convert.ToString(bkg.IsCancelled);
                    break;
            }


        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClearAll();
            state = FormStates.View;
            ShowAll1(false, table);
            setUpListView();
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            if (state == FormStates.Edit)
            {
                PopulateObject(table);
                bookingController.DataMaintenance(booking, DB.DBOperation.Edit);
            }
            else
            {
                bookingController.DataMaintenance(booking, DB.DBOperation.Delete);
            }
            bookingController.FinalizeChanges(booking);
            ClearAll();
            state = FormStates.View;
            ShowAll1(false, table);
            setUpListView();   //refresh List View
            booking = null;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            state = FormStates.Delete;
            btnUpdate.Visible = false;
            //call the ShowAll method
            ShowAll2(false, table);
            MessageBox.Show("This record is about to be deleted");
        }
    }
}

