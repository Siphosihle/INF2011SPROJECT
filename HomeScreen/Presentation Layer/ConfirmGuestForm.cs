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
    public partial class ConfirmGuestForm : Form
    {
        private RestEasyMDIParent mdiParent;

        private Guest gst;
        private Booking booking;
        private Hotel hotel;

        private Collection<Guest> guests;
        private GuestController guestController;
        CustomerInformationForm cust;

        public ConfirmGuestForm(Guest guest, Booking bking, Hotel htl)
        {
            InitializeComponent();
            guestController = new GuestController();
            guests = guestController.AllGuests;

            gst = guest;
            booking = bking;
            hotel = htl;

        }
        public void ShowData()
        {
            foreach (Guest guest in guests)
            {
                txtboxGuestID.Text = guest.GuestID;
            }             
        }

        private void ConfirmGuestForm_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerInformationForm cif = new CustomerInformationForm(booking, gst, hotel);
            this.Hide();
            cif.ShowDialog();
            this.Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            NewBooking nb = new NewBooking(gst, booking);
            this.Hide();
            nb.MdiParent = mdiParent;
            nb.StartPosition = FormStartPosition.CenterParent;
            nb.ShowDialog();
            this.Close();
        }
    }
}
