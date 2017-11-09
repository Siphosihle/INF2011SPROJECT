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

        public bool formClosed = false;
        private GuestController guestController;
        private BookingController bookingController;

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

        public ListForm(string tbl)
        {
            InitializeComponent();

            table = tbl;

            switch (table)
            {
                case "booking":
                    bookingController = new BookingController();
                    break;
            }

            //Set up Event Handlers for some form events in code rather than trhough the designer
            this.Load += ListForm_Load;
            this.Activated += ListForm_Activated;
            this.FormClosed += ListForm_FormClosed;
            state = FormStates.View;
        }


        private void ListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            formClosed = true;
        }

        private void ListForm_Load(object sender, EventArgs e)
        {

        }

        private void ListForm_Activated(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            setUpListView();
            ShowAll(true, table);
        }

        private void setUpListView()
        {

            ListViewItem sDetails;
            listView1.Clear();


            switch(table)
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

                case "Booking":

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
            ShowAll(true, table);
            state = FormStates.View;
            ShowAll(false, table);
            if (listView1.SelectedItems.Count > 0)   // if you selected an item 
            {
                booking = bookingController.Find(Convert.ToInt32(listView1.SelectedItems[0].Text));  //selected student becoms current student
                                                                                                     // Show the details of the selected student in the controls
                PopulateTextBoxes(guest, booking);
            }
        }
        private void ShowAll(bool value, string tbl)
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

            txt1.Visible = value;
            txt6.Visible = value;
            txt2.Visible = value;
            txt9.Visible = value;
            txt4.Visible = value;
            txt3.Visible = value;
            txt8.Visible = value;
            txt5.Visible = value;
            txt7.Visible = value;
            if (state == FormStates.Delete)
            {
                cancelButton.Visible = !value;
                submitButton.Visible = !value;
                updateButton.Visible = !value;
            }
            else
            {
                cancelButton.Visible = value;
                submitButton.Visible = value;
            }
            deleteButton.Visible = value;
            editButton.Visible = value;

            switch(tbl)
            {
                case "guest":
                    lbl1.Text = "GuestID";
                    lbl2.Text = "Name";
                    lbl3.Text = "Surname";
                    lbl4.Text = "Phone Number";
                    lbl5.Text = "Address";
                    lbl6.Text = "Email";
                    lbl7.Text = "Status";

                    lbl8.Enabled = !value;
                    txt9.Enabled = !value;
                    lbl9.Enabled = !value;
                    txt9.Enabled = !value;

                    break;
            }
                




        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PopulateObject();
            bookingController.DataMaintenance(booking, Database_Layer.DB.DBOperation.Edit);
        }
        private void ClearAll()
        {
            txt6.Text = "";
            txt2.Text = "";
            txt9.Text = "";
            txt4.Text = "";
            txt3.Text = "";
            txt8.Text = "";
            txt1.Text = "";
            txt7.Text = "";
            txt5.Text = "";
        }
        private void PopulateObject()
        {
            booking = new Booking();
            booking.ReservationNumber = Convert.ToInt32(txt1.Text);
            booking.GuestID = Convert.ToInt32(txt9.Text);
            booking.NoOfPeople = Convert.ToInt32(txt4.Text);
            booking.StartDate = Convert.ToDateTime(txt5.Text);
            booking.EndDate = Convert.ToDateTime(txt6.Text);
            booking.NoOfRooms = Convert.ToInt32(txt3.Text);
            booking.RecievedDeposit = Convert.ToBoolean(txt8.Text);
            booking.IsCancelled = Convert.ToBoolean(txt9.Text);
            booking.SentConfirmation = Convert.ToBoolean(txt7.Text);
        }
        private void PopulateTextBoxes(Guest gst, Booking bkg)
        {

            switch (table)
            {
                case "Guest":
                    txt1.Text = Convert.ToString(gst.GuestID);
                    txt2.Text = Convert.ToString(gst.Name);
                    txt3.Text = Convert.ToString(gst.Surname);
                    txt4.Text = Convert.ToString(gst.PhoneNumber);
                    txt5.Text = Convert.ToString(gst.Address);
                    txt6.Text = Convert.ToString(gst.Email);
                    txt7.Text = Convert.ToString(gst.Status);
                    break;
                case "booking":
                    txt1.Text = Convert.ToString(bkg.ReservationNumber);
                    txt2.Text = Convert.ToString(bkg.GuestID);
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
            bookingController.DataMaintenance(booking, Database_Layer.DB.DBOperation.Delete);
        }

        private void txtResNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            state = FormStates.Edit;
            deleteButton.Visible = false;
            ShowAll(true, table);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (state == FormStates.Edit)
            {
                PopulateObject();
                bookingController.DataMaintenance(booking, DB.DBOperation.Edit);
            }
            else
            {
                bookingController.DataMaintenance(booking, DB.DBOperation.Delete);
            }
            bookingController.FinalizeChanges(booking);
            ClearAll();
            state = FormStates.View;
            ShowAll(false, table);
            setUpListView();   //refresh List View
            booking = null;
        }

        private void editButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}

