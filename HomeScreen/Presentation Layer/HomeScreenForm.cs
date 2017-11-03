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
    public partial class HomeScreenForm : Form
    {
        public HomeScreenForm()
        {
            InitializeComponent();
        }

        private void btnMakeaBooking_Click(object sender, EventArgs e)
        {
            AvailableRooms hs = new AvailableRooms();
            this.Hide();
            hs.ShowDialog();
            this.Close();
        }
    }
}
