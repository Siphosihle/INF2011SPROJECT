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
        private FormStates state;

        public ListForm(GuestController aController)
        {
            InitializeComponent();
            guestController = aController;
            guests = guestController.AllGuests;
            //Set up Event Handlers for some form events in code rather than trhough the designer
            this.Load += ListForm_Load;
            this.Activated += ListForm_Activated;
            this.FormClosed += ListForm_FormClosed;
            state = FormStates.View;
        }
        public ListForm()
        {

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
            ShowAll(false);
        }

        private void setUpListView()
        {

            ListViewItem bookingDetails;
            Booking booking;
            listView1.Clear();

            listView1.Columns.Insert(0, "GuestIDr", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(1, "ReservationNumber", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(2, "NoOfRooms", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(3, "NoOfPeople", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(4, "StartDate", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(5, "EndDate", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(6, "SentConfirmation", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(7, "ReceivedConfirmation", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(8, "IsCancelled", 120, HorizontalAlignment.Left);


            Collection<Guest> guests = null;

            guests = guestController.AllGuests;
            listView1.Text = "Listing of all Guests";

            foreach (Guest guest in guests)
            {
                bookingDetails = new ListViewItem();
                bookingDetails.Text = guest.GuestID.ToString();
                // Do the same for Gender, HomeLanguage, PopGroup and SA_Citizenship_Status
                bookingDetails.SubItems.Add(guest.Name);
                bookingDetails.SubItems.Add(guest.Surname);
                bookingDetails.SubItems.Add(guest.PhoneNumber);
                bookingDetails.SubItems.Add(guest.Address);
                listView1.Items.Add(bookingDetails);
            }
            listView1.Refresh();
            listView1.GridLines = true;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true);
            state = FormStates.View;
            ShowAll(false);
            if (listView1.SelectedItems.Count > 0)   // if you selected an item 
            {
                booking = bookingController.Find(Convert.ToInt32(listView1.SelectedItems[0].Text));  //selected student becoms current student
                                                                                                     // Show the details of the selected student in the controls
                PopulateTextBoxes(booking);
            }
        }
        private void ShowAll(bool value)
        {
            label1.Visible = value;
            label2.Visible = value;
            label3.Visible = value;
            label4.Visible = value;
            label5.Visible = value;
            label6.Visible = value;
            label7.Visible = value;
            label8.Visible = value;
            label9.Visible = value;
            txtResNo.Visible = value;
            txtEndDate.Visible = value;
            txtGuestID.Visible = value;
            txtIsCancelled.Visible = value;
            txtNoOfPeople.Visible = value;
            txtNoOfRooms.Visible = value;
            txtReceiveDeposit.Visible = value;
            txtStartDate.Visible = value;
            txtSentConfirmation.Visible = value;
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PopulateObject();
            bookingController.DataMaintenance(booking, Database_Layer.DB.DBOperation.Edit);
        }
        private void ClearAll()
        {
            txtEndDate.Text = "";
            txtGuestID.Text = "";
            txtIsCancelled.Text = "";
            txtNoOfPeople.Text = "";
            txtNoOfRooms.Text = "";
            txtReceiveDeposit.Text = "";
            txtResNo.Text = "";
            txtSentConfirmation.Text = "";
            txtStartDate.Text = "";
        }
        private void PopulateObject()
        {
            booking = new Booking();
            booking.ReservationNumber = Convert.ToInt32(txtResNo.Text);
            booking.GuestID = Convert.ToInt32(txtIsCancelled.Text);
            booking.NoOfPeople = Convert.ToInt32(txtNoOfPeople.Text);
            booking.StartDate = Convert.ToDateTime(txtStartDate.Text);
            booking.EndDate = Convert.ToDateTime(txtEndDate.Text);
            booking.NoOfRooms = Convert.ToInt32(txtNoOfRooms.Text);
            booking.RecievedDeposit = Convert.ToBoolean(txtReceiveDeposit.Text);
            booking.IsCancelled = Convert.ToBoolean(txtIsCancelled.Text);
            booking.SentConfirmation = Convert.ToBoolean(txtSentConfirmation.Text);
        }
        private void PopulateTextBoxes(Booking bkg)
        {
            txtGuestID.Text = Convert.ToString(bkg.GuestID);
            txtEndDate.Text = Convert.ToString(bkg.EndDate);
            txtResNo.Text = Convert.ToString(bkg.ReservationNumber);
            txtReceiveDeposit.Text = Convert.ToString(bkg.RecievedDeposit);
            txtNoOfRooms.Text = Convert.ToString(bkg.NoOfRooms);
            txtNoOfPeople.Text = Convert.ToString(bkg.NoOfPeople);
            txtSentConfirmation.Text = Convert.ToString(bkg.SentConfirmation);
            txtStartDate.Text = Convert.ToString(bkg.StartDate);
            txtIsCancelled.Text = Convert.ToString(bkg.IsCancelled);

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
            ShowAll(true);
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
            ShowAll(false);
            setUpListView();   //refresh List View
            booking = null;
        }

        private void editButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}

