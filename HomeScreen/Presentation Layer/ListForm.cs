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

        #region Data Members

        private PaymentForm pf;
        private HomeScreenForm hsf;

        public bool confirmFormClosed = false;

        private GuestController guestController;
        private BookingController bookingController;
        private AccountController accountcontroller;
        private AdminController admincontroller;
        private HotelController hotelcontroller;
        private PaymentController paymentcontroller;
        private RoomController roomcontroller;

        private Guest guest;
        private Guest nguest;
        private Booking booking;
        private Hotel hotel;
        private Account account;


        private Collection<Guest> guests;
        private Collection<Booking> bookings;

        private FormStates state;

        private string table;
        private HotelController hotelController;
        private PaymentController paymentController;
        private RoomController roomController;

        #endregion

        #region Constructor

        public ListForm(GuestController aController)
        {
            InitializeComponent();

            guestController = new GuestController();
            bookingController = new BookingController();
            bookings = bookingController.AllBookings;
            guests = guestController.AllGuests;

            //Set up Event Handlers for some form events in code rather than trhough the designer
            this.Load += ListForm_Load;
            this.Activated += ListForm_Activated;
            this.FormClosed += ListForm_FormClosed;
            state = FormStates.View;
        }

        public ListForm(Booking bking, Guest gst, Hotel htl)
        {
            InitializeComponent();

            guestController = new GuestController();
            bookingController = new BookingController();
            bookings = bookingController.AllBookings;
            guests = guestController.AllGuests;

            booking = bking;
            guest = gst;
            hotel = htl;

            //Set up Event Handlers for some form events in code rather than trhough the designer
            this.Load += ListForm_Load;
            this.Activated += ListForm_Activated;
            this.FormClosed += ListForm_FormClosed;
            state = FormStates.View;
        }

        public ListForm(string tbl, string crudFunction, Booking bking, Guest gst, Hotel htl)
        {
            InitializeComponent();

            table = tbl;

            switch (table)
            {
                case "booking":
                    bookingController = new BookingController();
                    bookings = bookingController.AllBookings;
                    break;
                case "guest":
                    guestController = new GuestController();
                    guests = guestController.AllGuests;
                    break;
                case "nguest":
                    guestController = new GuestController();
                    guests = guestController.AllGuests;
                    nguest = gst;
                    break;

                case "account":
                    accountcontroller = new AccountController();
                    break;
                case "admin":
                    admincontroller = new AdminController();
                    break;
                case "hotel":
                    hotelController = new HotelController();
                    break;
                case "payment":
                    paymentController = new PaymentController();
                    break;
                case "room":
                    roomController = new RoomController();
                    break;

            }

            booking = bking;
            hotel = htl;

            

            //Set up Event Handlers for some form events in code rather than trhough the designer
            this.Load += ListForm_Load;
            this.Activated += ListForm_Activated;
            this.FormClosed += ListForm_FormClosed;
            state = FormStates.View;
        }

        #endregion

        #region Form Events

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

        #endregion

        #region GUI

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll1(true, table);
            state = FormStates.View;
            ShowAll2(false, table);
            if (listView1.SelectedItems.Count > 0)   // if you selected an item 
            {
                switch (table)
                {
                    case "booking":
                        booking = bookingController.Find(Convert.ToInt32(listView1.SelectedItems[0].Text));  //selected student becoms current student
                        break;
                    case "guest":
                        guest = guestController.Find(Convert.ToInt32(listView1.SelectedItems[0].Text));
                        break;
                    case "nguest":
                        guest = guestController.Find(Convert.ToInt32(listView1.SelectedItems[0].Text));
                        break;
                }


            
            // Show the details of the selected student in the controls
            PopulateTextBoxes(guest, booking);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
                state = FormStates.Edit;
                ShowAll2(true, table);
           
        }

        #endregion

        #region Methods

        private void setUpListView()
        {

            ListViewItem sDetails;
            listView1.Clear();


            switch (table)
            {
                #region Guest Setup
                case "guest":
                    listView1.Columns.Insert(0, "GuestID", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(1, "Name", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(2, "Surname", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(3, "PhoneNo", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(4, "Address", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(5, "Email", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(6, "Status", 120, HorizontalAlignment.Left);

                    
                    listView1.Text = "Showing Guest Details";

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

                case "nguest":
                    listView1.Columns.Insert(0, "GuestID", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(1, "Name", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(2, "Surname", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(3, "PhoneNo", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(4, "Address", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(5, "Email", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(6, "Status", 120, HorizontalAlignment.Left);


                    listView1.Text = "Showing Guest Details";

                    
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
                        sDetails.SubItems.Add(booking.RecieveDeposit.ToString());
                        sDetails.SubItems.Add(booking.IsCancelled.ToString());
                        listView1.Items.Add(sDetails);
                    }

                    break;

                    #endregion

            }


            listView1.Refresh();
            listView1.GridLines = true;
        }

        private void ShowAll1(bool value, string tbl)
        {

            lbl1.Visible = value;
            lbl2.Visible = value;
            lbl3.Visible = value;
            lbl4.Visible = value;
            lbl5.Visible = value;
            lbl6.Visible = value;
            lbl7.Visible = value;
            lbl8.Visible = value;
            lbl9.Visible = value;

            i1.Visible = value;
            i2.Visible = value;
            i2.Visible = value;
            i3.Visible = value;
            i4.Visible = value;
            i5.Visible = value;
            i6.Visible = value;
            i7.Visible = value;
            i8.Visible = value;
            i9.Visible = value;

            if ((state == FormStates.Edit) && value)
            {

                i1.Enabled = !value;
                //do the same for all buttons & textboxes
                switch (table)
                {
                    case "booking":
                        i2.Enabled = !value;
                        break;
                    case "guest":
                    case "nguest":
                        i2.Enabled = value;
                        break;
                }


            }
            else
            {
                i1.Enabled = value;
                i1.Enabled = value;
            }



            if (state == FormStates.Delete)
            {
                btnContinue.Visible = !value;
                btnSubmit.Visible = !value;
            }
            else
            {
                btnContinue.Visible = value;
                btnSubmit.Visible = value;
            }

            switch (tbl)
            {
                case "nguest":
                case "guest":
                    lbl1.Text = "GuestID";
                    lbl2.Text = "Name";
                    lbl3.Text = "Surname";
                    lbl4.Text = "Phone Number";
                    lbl7.Text = "Address";
                    lbl8.Text = "Email";
                    lbl9.Text = "Status";
                    break;
                case "booking":
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
                    case "guest":
                    case "nguest":
                        i1.Enabled = !value;
                        break;
                }

            }
            else
            {
                i1.Enabled = value;
                i2.Enabled = value;
            }
            i3.Enabled = value;
            i4.Enabled = value;
            i5.Enabled = value;
            i6.Enabled = value;
            i7.Enabled = value;
            i8.Enabled = value;
            i9.Enabled = value;



            if (state == FormStates.Delete)
            {

                btnContinue.Visible = !value;
                btnSubmit.Visible = !value;
            }
            else
            {
                btnContinue.Visible = value;
                btnSubmit.Visible = value;
            }
        }

        private void PopulateObject(string table)
        {
            switch (table)
            {
                case "booking":
                    booking = new Booking();
                    booking.ReservationNumber = Convert.ToInt32(i1.Text);
                    booking.GuestID = Convert.ToInt32(i2.Text);
                    booking.NoOfRooms = Convert.ToInt32(i3.Text);
                    booking.NoOfPeople = Convert.ToInt32(i4.Text);
                    booking.StartDate = Convert.ToDateTime(i5.Value);
                    booking.EndDate = Convert.ToDateTime(i6.Value);
                    booking.SentConfirmation = Convert.ToBoolean(i7.Text);
                    booking.RecieveDeposit = Convert.ToBoolean(i8.Text);
                    booking.IsCancelled = Convert.ToBoolean(i9.Text);

                    break;
                case "guest":
                    guest = new Guest();
                    guest.GuestID = Convert.ToInt32(i1.Text);
                    guest.Name = Convert.ToString(i2.Text);
                    guest.Surname = Convert.ToString(i3.Text);
                    guest.PhoneNumber = Convert.ToString(i4.Text);
                    guest.Address = Convert.ToString(i7.Text);
                    guest.Email = Convert.ToString(i8.Text);
                    guest.Status = Convert.ToString(i9.Text);
                    break;
                case "nguest":
                    guest.GuestID = Convert.ToInt32(i1.Text);
                    guest.Name = Convert.ToString(i2.Text);
                    guest.Surname = Convert.ToString(i3.Text);
                    guest.PhoneNumber = Convert.ToString(i4.Text);
                    guest.Address = Convert.ToString(i7.Text);
                    guest.Email = Convert.ToString(i8.Text);
                    guest.Status = Convert.ToString(i9.Text);
                    break;
            }

        }
        private void PopulateTextBoxes(Guest gst, Booking bkg)
        {

            switch (table)
            {
                case "nguest":
                case "guest":
                    i1.Text = Convert.ToString(gst.GuestID);
                    i2.Text = Convert.ToString(gst.Name);
                    i3.Text = Convert.ToString(gst.Surname);
                    i4.Text = Convert.ToString(gst.PhoneNumber);
                    i7.Text = Convert.ToString(gst.Address);
                    i8.Text = Convert.ToString(gst.Email);
                    i9.Text = Convert.ToString(gst.Status);
                    break;
                case "booking":
                    i1.Text = Convert.ToString(bkg.ReservationNumber);
                    i2.Text = Convert.ToString(bkg.GuestID);
                    i3.Text = Convert.ToString(bkg.NoOfRooms);
                    i4.Text = Convert.ToString(bkg.NoOfPeople);
                    i5.Value = Convert.ToDateTime(bkg.StartDate);
                    i6.Value = Convert.ToDateTime(bkg.EndDate);
                    i7.Text = Convert.ToString(bkg.SentConfirmation);
                    i8.Text = Convert.ToString(bkg.RecieveDeposit);
                    i9.Text = Convert.ToString(bkg.IsCancelled);
                    break;
            }


        }

        private void ClearAll()
        {
            i1.Text = "";
            i2.Text = "";
            i3.Text = "";
            i4.Text = "";
            i5.Value = DateTime.Today;
            i6.Value = DateTime.Today.AddDays(1);
            i7.Text = "";
            i8.Text = "";
            i9.Text = "";
        }


        #endregion

        

        private void submitButton_Click(object sender, EventArgs e)
        {
            switch(table)
            {
                case "booking":
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
                    break;
                case "guest":
                case "nguest":
                    if (state == FormStates.Edit)
                    {
                        PopulateObject(table);
                        guestController.DataMaintenance(guest, DB.DBOperation.Edit);
                    }
                    else
                    {
                        guestController.DataMaintenance(guest, DB.DBOperation.Delete);
                    }
                    guestController.FinalizeChanges(guest);
                    break;

            }
            
            ClearAll();
            state = FormStates.View;
            ShowAll1(false, table);
            setUpListView();   //refresh List View
            booking = null;

        }

        

        private void CreateNewForm(string tbl)
        {
            switch(tbl)
            {
                case "nguest":
                    pf = new PaymentForm();
                    pf.MdiParent = this.MdiParent;
                    pf.StartPosition = FormStartPosition.CenterParent;
                    break;
                case "guest":
                case "booking":
                    hsf = new HomeScreenForm();
                    hsf.MdiParent = this.MdiParent;
                    hsf.StartPosition = FormStartPosition.CenterParent;
                    break;
            }
            
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            state = FormStates.Delete;
            ShowAll2(false, table);
            MessageBox.Show("This record is about to be deleted");
            btnDelete.Enabled = false;
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            switch (table)
            {

                case "nguest":
                    if (pf == null)
                    {
                        CreateNewForm(table);
                    }
                    if (pf.confirmFormClosed)
                    {
                        CreateNewForm(table);
                    }
                    this.Hide();
                    pf.Show();
                    this.Close();
                    break;
                case "booking":
                case "guest":
                    if (hsf == null)
                    {
                        CreateNewForm(table);
                    }
                    if (hsf.confirmFormClosed)
                    {
                        CreateNewForm(table);
                    }
                    this.Hide();
                    hsf.Show();
                    this.Close();
                    break;
            }
            }

        private void i1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

