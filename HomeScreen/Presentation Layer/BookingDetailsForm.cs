﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeScreen.Presentation_Layer
{
    public partial class BookingDetailsForm : Form
    {
        #region Members
        private string inDate;
        private string outDate;
        private string roomNum;
        private string guestNum;
        #endregion
        private class Number
        {
            public string Num;

            public Number(string num)
            {
                Num = num;
            }
            public override string ToString()
            {
                return Num;
            }
        }
        #region Properties
        public string InDate
        {
            get
            {
                return inDate;
            }
            set
            {
                inDate = value;
            }
        }
        public string OutDate
        {
            get
            {
                return outDate;
            }
            set
            {
                outDate = value;
            }
        }
        public string RoomNum
        {
            get
            {
                return roomNum;
            }
            set
            {
                roomNum = value;
            }
        }
        public string GuestNum
        {
            get
            {
                return guestNum;
            }
            set
            {
                guestNum = value;
            }
        }
#endregion
        public BookingDetailsForm()
        {
            InitializeComponent();
            for(int i = 1; i < 20; i++)
            {
                string str = i.ToString();
                cmbNumberOfRooms.Items.Add(str);
                cmbNumberOfGuests.Items.Add(str);
            }
        }

        private void cmbNumberOfRooms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNumberOfGuests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            BookingDetailsForm hs = new BookingDetailsForm();
            this.Hide();
            hs.ShowDialog();
            this.Close();
        }
        public void PopulateObject()
        {
            inDate = dtpCheckInDate.Text;
            outDate = dtpCheckOutDate.Text;
            roomNum = cmbNumberOfRooms.Text;
            guestNum = cmbNumberOfGuests.Text;
            MessageBox.Show(inDate + " " + outDate + " " + roomNum + " " + guestNum);
        }
    }
}