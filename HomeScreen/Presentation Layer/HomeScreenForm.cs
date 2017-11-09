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

namespace HomeScreen.Presentation_Layer
{
    public partial class HomeScreenForm : Form
    {
        private GuestController guestcontroller;

        private BookingDetailsForm bdForm;
        private ListForm lvForm;

        public bool confirmFormClosed = false;

        public HomeScreenForm()
        {
            InitializeComponent();


            this.FormClosed += Form_Closed;
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            confirmFormClosed = true;
        }

        private void btnMakeaBooking_Click(object sender, EventArgs e)
        {

            if(bdForm == null)
            {
                CreateNewBDForm();
            }
            if (bdForm.confirmFormClosed)
            {
                CreateNewBDForm();
            }
            this.Hide();
            bdForm.Show();
            this.Close();

            
        }



        #region new forms
        private void CreateNewBDForm()
        {
            bdForm = new BookingDetailsForm();
            bdForm.MdiParent = this.MdiParent;
            bdForm.StartPosition = FormStartPosition.CenterParent;
        }

        private void CreateNewLVForm(string tbl)
        {
            if (lvForm == null)
            {
                lvForm = new ListForm(tbl);
                lvForm.MdiParent = this.MdiParent;
                lvForm.StartPosition = FormStartPosition.CenterParent;
            }
            if (lvForm.confirmFormClosed)
            {
                lvForm = new ListForm(tbl);
                lvForm.MdiParent = this.MdiParent;
                lvForm.StartPosition = FormStartPosition.CenterParent;
            }
            this.Hide();
            lvForm.Show();
            this.Close();
        }

        #endregion

        #region Button Events

        private void btnUpdateBooking_Click(object sender, EventArgs e)
        {
            CreateNewLVForm("Booking");
        }


        private void btnBookingEnquiry_Click(object sender, EventArgs e)
        {

            CreateNewLVForm("Guest");
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            CreateNewLVForm("Booking");

        }

        


        #endregion


    }
}
