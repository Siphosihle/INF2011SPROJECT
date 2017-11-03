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
        private int count = 0;
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
            for(int i = 1; i < 6; i++)
            {
                string str = i.ToString();
                cmbNumberOfRooms.Items.Add(str);
            }
            for(int s = 1; s < 21; s++)
            {
                string strt = s.ToString();
                cmbNumberOfGuests.Items.Add(strt);
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
            int num = 0;
            int nw = 0;
            inDate = dtpCheckInDate.Text;
            outDate = dtpCheckOutDate.Text;
            roomNum = cmbNumberOfRooms.Text;
            if (roomNum != "")
            {
                num = Int32.Parse(roomNum);
            }
        
            if (num > 5)
            {
                MessageBox.Show("The hotel only have 5 rooms");
            }
            guestNum = cmbNumberOfGuests.Text;
            if (guestNum != "")
            {
                nw = Int32.Parse(guestNum);
            }
            if ((guestNum == "") && (roomNum == ""))
            {
                MessageBox.Show("Please enter the Number of Rooms and Guests before you save!");
            }
            if (nw > 20)
            {
                MessageBox.Show("Only 20 guest can be accomodated at a time");
            }
            int mlt = num * 4;
            if(nw > mlt)
            {
                MessageBox.Show("A room can only accomodate 4 guests, please re-enter the number of guests!");
            }
            if (((num <= 5) && (nw <= 20) && (nw <= mlt)) && (guestNum != "") && (roomNum != ""))
            {
                MessageBox.Show("Check-In date: " + inDate + "\n" + "Check-Out Date: " + outDate + " \n" + "Rooms Required: " + roomNum + " rooms" + "\n" + "Guests Expected: " + guestNum + " guests");
            }
            if(((roomNum != "") && (guestNum == "")) || ((roomNum == "") && (guestNum != "")))
            {
                MessageBox.Show("Please complete the empty box!");
            }
            if((roomNum != "") && (guestNum != ""))
            {
                count++;
            }
            
        }

        private void btnCheckBooking_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                AvailableRoomsForm hs = new AvailableRoomsForm();
                this.Hide();
                hs.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please save the Booking Details first before you continue!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PopulateObject();
            
        }
    }
}
