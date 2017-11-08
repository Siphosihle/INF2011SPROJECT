using HomeScreen.Business_Layer;
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

namespace HomeScreen.Presentation_Layer
{
    public partial class ConfirmGuestForm : Form
    {
        private Guest gst;
        private Collection<Guest> guests;
        private GuestController guestController;
        CustomerInformationForm cust;
        public ConfirmGuestForm()
        {
            InitializeComponent();
            guestController = new GuestController();
            guests = guestController.AllGuests;
            cust = new CustomerInformationForm();

        }
        public void ShowData()
        {
            foreach (Guest guest in guests)
            {
                //string str = txtboxID.Text;
                lbInvisible.Text = guest.GuestID;
                //txtboxID.Text = txtboxGuestID.Text;
                //txtboxGuestID.Text = cust.MyID;
                lbInvisible.Visible = true;
                //txtboxGuestID.Text = str;
                //txtboxName.Text = cust.Name;
                //cust.MyID = txtboxGuestID.Text;
            }             
        }

        private void ConfirmGuestForm_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerInformationForm cif = new CustomerInformationForm();
            this.Hide();
            cif.ShowDialog();
            this.Close();
        }

        public void txtboxGuestID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
