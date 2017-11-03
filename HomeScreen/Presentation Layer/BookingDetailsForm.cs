using System;
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
        private BookingDetailsForm bookingDetails;
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
            for(int i = 1; i < 21; i++)
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
        public void PopulateObject()
        {
            inDate = dtpCheckInDate.Text;
            outDate = dtpCheckOutDate.Text;
            roomNum = cmbNumberOfRooms.Text;
            guestNum = cmbNumberOfGuests.Text;
            MessageBox.Show("Check-In date: " + inDate + "\n" + "Check-Out Date: " + outDate + " \n" + "Rooms Required: " + roomNum + " rooms" + "\n" + "Guests Expected: " + guestNum + " guests");
        }

        private void btnCheckBooking_Click(object sender, EventArgs e)
        {
            AvailableRoomsForm hs = new AvailableRoomsForm();
            this.Hide();
            hs.ShowDialog();
            this.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            PopulateObject();
        }
    }
}
