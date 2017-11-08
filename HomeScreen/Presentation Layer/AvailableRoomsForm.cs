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

        public bool availableRoomsFormClosed = false;
        private BookingDetailsForm bookingDetails;
        private Collection<Room> availableRooms;


        public AvailableRoomsForm(Collection<Room> availrooms)
        {
            InitializeComponent();
            this.FormClosed += AvailableRoomsForm_Closed;

            availableRooms = availrooms;
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
            hs.ShowDialog();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CustomerInformationForm hs = new CustomerInformationForm();
            this.Hide();
            //hs.ShowDialog();
            this.Close();
        }

        private void AvailableRoomsForm_Load(object sender, EventArgs e)
        {
            string sAvailRoom;
            rtbAvailableRooms.Text = "";
        }

        private void lblAvailableRooms_Click(object sender, EventArgs e)
        {

        }
    }
}
