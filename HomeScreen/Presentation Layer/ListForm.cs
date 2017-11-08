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
        private string formstate;

        ListViewItem bookingDetails;

        private BookingController bookingcontroller;
        private Booking booking;
        private Collection<Booking> bookings;

        public ListForm(string frmstate)
        {
            InitializeComponent();

            bookingcontroller = new BookingController();
            bookings = bookingcontroller.AllBookings;

            this.Activated += ListForm_Activated;

            formstate = frmstate;

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

            ListViewItem bookingdetails;
            Booking bking;
            listView1.Clear();

            listView1.Columns.Insert(0, "ReservationNumber", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(0, "GuestID", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(0, "NoOfRooms", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(0, "NoOfPeople", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(0, "StartDate", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(0, "EndDate", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(0, "SentConfirmation", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(0, "ReceivedConfirmation", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(0, "IsCancelled", 120, HorizontalAlignment.Left);


            Collection<Booking> bookings = null;
            switch (formstate)
            {
                case "Enquiry":
                case "Update":
                case "Delete":
                    bookings = bookingcontroller.AllBookings;
                    break;
            }
            
            foreach(Booking booking in bookings)
            {
                bookingDetails = new ListViewItem();
                bookingdetails.Text = booking.GuestID.ToString();
                bookingdetails.SubItems.Add(booking.GuestID.ToString());
                bookingdetails.SubItems.Add(booking.NoOfRooms.ToString());
                bookingdetails.SubItems.Add(booking.NoOfPeople.ToString());
                bookingdetails.SubItems.Add(booking.StartDate.ToString());
                bookingdetails.SubItems.Add(booking.EndDate.ToString());
                bookingdetails.SubItems.Add(booking.SentConfirmation.ToString());
                bookingdetails.SubItems.Add(booking.RecievedDeposit.ToString());
                bookingdetails.SubItems.Add(booking.IsCancelled.ToString());




                
                listView1.Items.Add(bookingdetails);



            }

            listView1.Refresh();
            listView1.GridLines = true;


        }



    

        private void ShowAll(bool v)
        {
            label1.Visible = v;
            label2.Visible = v;
            label3.Visible = v;
            label4.Visible = v;
            label5.Visible = v;
            label6.Visible = v;
            label7.Visible = v;
            label8.Visible = v;
            label9.Visible = v;

            if(formstate == "Update")
            {
                btnDelete.Enabled = false;
            }
            if(formstate == "Delete")
            {
                btnUpdate.Enabled = false;
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PopulateObject();
            bookingcontroller.DataMaintenance(booking, Database_Layer.DB.DBOperation.Edit);
        }

        private void PopulateObject()
        {
            booking = new Booking();
            /*booking.ReservationNumber = txtResNo.text;
            booking.GuestID = txtIsCancelled.Text;
            booking.NoOfPeople = txtNoOfPeople.Text;
            booking.StartDate */
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bookingcontroller.DataMaintenance(booking, Database_Layer.DB.DBOperation.Delete);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
