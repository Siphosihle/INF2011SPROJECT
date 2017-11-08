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
    public partial class HomeScreenForm : Form
    {
        private RestEasyMDIParent mdiParent;

        public HomeScreenForm()
        {
            InitializeComponent();
        }

        private void btnMakeaBooking_Click(object sender, EventArgs e)
        {
            BookingDetailsForm bdf = new BookingDetailsForm();
            this.Hide();
            bdf.Show();
            bdf.MdiParent = mdiParent;
            bdf.StartPosition = FormStartPosition.CenterParent;
            this.Close();
        }

        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            ListForm bdf = new ListForm();
            this.Hide();
            bdf.Show();
            bdf.MdiParent = mdiParent;
            bdf.StartPosition = FormStartPosition.CenterParent;
            this.Close();
        }

        private void btnBookingEnquiry_Click(object sender, EventArgs e)
        {

            bool bFound = false;
            Collection<Guest> guests = adminController.AllAdmins;
            foreach (Admin admin in admins)
            {
                if (txtboxUsername.Text == admin.Username && txtboxPassword.Text == admin.Password)
                {
                    bFound = true;
                }
            }

        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            ListForm bdf = new ListForm(formstate);
            this.Hide();
            bdf.Show();
            bdf.MdiParent = mdiParent;
            bdf.StartPosition = FormStartPosition.CenterParent;
            this.Close();
        }
    }
}
