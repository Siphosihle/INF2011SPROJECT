﻿using HomeScreen.Business_Layer;
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
        private string name;
        private string surname;
        private string id;
        private bool status;
        private GuestController guestController;
        private Collection<Guest> guests;
        private Guest gst;
        public ConfirmGuestForm confirm;
        public string myID;

        #region Properties
        public string MyID
        {
            get
            {
                return myID;
            }
            set
            {
                myID = value;
            }
        }

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
        public CustomerInformationForm()
        {
            InitializeComponent();
            guestController = new GuestController();
            gst = new Guest();
            name = "";
        }
        public void CheckGuest()
        {
            
        }
        //private void txtboxFirstName_TextChanged(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtboxFirstName.Text))
        //    {
        //        txtboxGuestID.Clear();
        //        return;
        //    }
        //}
        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            int count = 0;
            bool bFound = false;
            guests = guestController.AllGuests;
            
            name = txtboxFirstName.Text;
            foreach (Guest guest in guests)
            {
                if (txtboxID.Text == guest.GuestID)
                {
                    bFound = true;
                    myID = txtboxID.Text;
                    count++;
                }
            }

            if ((bFound == true))
            {
                MessageBox.Show("Existing Guest");
                ConfirmGuestForm cgf = new ConfirmGuestForm();
                this.Hide();
                cgf.ShowDialog();
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
        public override string ToString()
        {
            return name;
        }
    }
    
}
