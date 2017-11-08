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
    public partial class NewBooking : Form
    {
        private RestEasyMDIParent mdiParent;

        private Booking booking;
        private Guest guest;
        private Account account;

        public NewBooking(Guest gst, Booking bking)
        {
            InitializeComponent();
            guest = gst;
            booking = bking;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeScreenForm nb = new HomeScreenForm();
            this.Hide();
            nb.MdiParent = mdiParent;
            nb.StartPosition = FormStartPosition.CenterParent;
            nb.ShowDialog();
            this.Close();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {

            CreateBooking();
            if (CheckGuestAccount(guest.GuestID) == false)
            {
                CreateGuestAccount();
            }





            PaymentForm nb = new PaymentForm();
            this.Hide();
            nb.MdiParent = mdiParent;
            nb.StartPosition = FormStartPosition.CenterParent;
            nb.ShowDialog();
            this.Close();
        }

        private void CreateGuestAccount()
        {
            throw new NotImplementedException();
        }

        private bool CheckGuestAccount(object guestID)
        {
            throw new NotImplementedException();
        }

        private void CreateBooking()
        {

            

            throw new NotImplementedException();
        }

        private void PopulateObject(Booking bking)
        {
            booking = bking;

        }
    }
}
