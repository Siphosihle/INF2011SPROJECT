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
using HomeScreen.Presentation_Layer;

namespace HomeScreen
{
    public partial class CustomerInformationForm : Form
    {
        private string name;
        private string surname;
        private string id;
        private bool status;

        private ConfirmGuestForm cgf;

        private GuestController guestController;
        private Collection<Guest> guests;
        private Guest gst;
        private Booking booking;
        private Hotel hotel;

        public bool confirmFormClosed = false;


        #region Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public bool Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        #endregion
        public CustomerInformationForm(Booking bking, Guest gst, Hotel htl)
        {
            InitializeComponent();
            guestController = new GuestController();
            gst = new Guest();
            booking = bking;
            hotel = htl;

            this.FormClosed += Form_Closed;

        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            confirmFormClosed = true;
        }

        public CustomerInformationForm()
        {

        }
        public void CheckGuest()
        {
            
        }
        private void txtboxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            int count = 0;
            bool bFound = false;
            guests = guestController.AllGuests;
            foreach (Guest guest in guests)
            {
                if (txtboxID.Text == guest.GuestID)
                {
                    bFound = true;
                    count++;
                }
            }

            if ((bFound == true))
            {

                gst = guestController.Find(txtboxID.Text);

                MessageBox.Show("Existing Guest");
                ListForm lf = new ListForm(guestController);
                this.Hide();
                lf.Show();
                this.Close();
                //confirm.ShowData(); 
            }
            if ((bFound == false) && (count == 1))
            {
                MessageBox.Show("New Guest");
                NewGuestForm ngf = new NewGuestForm();
                this.Hide();
                ngf.ShowDialog();
                this.Close();
            }
            if(count == 0)
            {
                MessageBox.Show("Please enter all the details");
            }

        }

        private void lblGuestDetails_Click(object sender, EventArgs e)
        {

        }

        private void txtboxFirstName_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    
}
