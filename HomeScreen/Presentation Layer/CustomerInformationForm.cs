using HomeScreen.Business_Layer;
using HomeScreen.Presentation_Layer;
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

namespace HomeScreen
{
    public partial class CustomerInformationForm : Form
    {
        private string firstName;
        private string lastName;
        private string id;
        private GuestController guestController;
        private Collection<Guest> guests;
        private Guest gst;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
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
        public CustomerInformationForm()
        {
            InitializeComponent();
            guestController = new GuestController();
        }
        public void CheckGuest(string name, string surname, string id)
        {
            name = txtboxFirstName.Text;
            surname = txtboxLastName.Text;
            id = txtboxID.Text;
            if(id.Equals(guestController.Find(id)))
            {
                MessageBox.Show("The Guest Exist");
                ConfirmGuestForm cgf = new ConfirmGuestForm();
                this.Hide();
                cgf.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("This is a New Guest");
                CreateGuest();
            }
        }
        public void CreateGuest()
        {
            NewGuestForm ngf = new NewGuestForm();
            this.Hide();
            ngf.ShowDialog();
            this.Close();
        }
        private void txtboxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblGuestDetails_Click(object sender, EventArgs e)
        {

        }
    }
    
}
