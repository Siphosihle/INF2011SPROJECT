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

namespace HomeScreen.Presentation_Layer
{
    public partial class AvailableRoomsForm : Form
    {
        private RestEasyMDIParent mdiParent;
        private HomeScreenForm homescreenform;
        private CustomerInformationForm custInfoForm;

        public bool availableRoomsFormClosed = false;
        private BookingDetailsForm bookingDetails;
        private Collection<Room> availableRooms;
        private Hotel hotel;


        public AvailableRoomsForm(Collection<Room> availrooms, Hotel htl)
        {
            InitializeComponent();
            this.FormClosed += AvailableRoomsForm_Closed;

            availableRooms = availrooms;
            hotel = htl;
        }

        private void AvailableRoomsForm_Closed(object sender, FormClosedEventArgs e)
        {
            availableRoomsFormClosed = true;
        }

        private void rtbAvailableRooms_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            BookingDetailsForm hs = new BookingDetailsForm();
            this.Hide();
            hs.Show();
            hs.MdiParent = this;
            hs.StartPosition = FormStartPosition.CenterParent;
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CustomerInformationForm hs = new CustomerInformationForm();
            this.Hide();
            hs.Show();
            hs.MdiParent = mdiParent;
            hs.StartPosition = FormStartPosition.CenterParent;
            this.Close();
        }

        private void AvailableRoomsForm_Load(object sender, EventArgs e)
        {
            string sAvailRoom = "The following rooms are available for " + hotel.HotelName ;
            for(int i = 0; i < availableRooms.Count;i++)
            {
                sAvailRoom += "Room No " + availableRooms[i].RoomNo + "\n";
            }
            rtbAvailableRooms.Text = sAvailRoom;
        }

        private void lblAvailableRooms_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();

            homescreenform = new HomeScreenForm();
            homescreenform.MdiParent = this.MdiParent;
            homescreenform.StartPosition = FormStartPosition.CenterParent;
            homescreenform.Show();
        }
    }
}
