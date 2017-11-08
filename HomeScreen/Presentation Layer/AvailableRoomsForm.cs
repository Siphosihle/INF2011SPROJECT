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
        private BookingDetailsForm bookingDetails; 
        public AvailableRoomsForm(Collection<Room> available rooms)
        {
            InitializeComponent();
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

        }

        private void lblAvailableRooms_Click(object sender, EventArgs e)
        {

        }
    }
}
