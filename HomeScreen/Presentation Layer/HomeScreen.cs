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

namespace HomeScreen
{
    public partial class HomeScreen : Form
    {

        private class NumberOfRooms
        {
            private List<int> list = new List<int>();
            private string Number;

            public NumberOfRooms(string number)
            {
                Number = number;
            }
            public override string ToString()
            {
                return Number;
            }
        }
        public HomeScreen()
        {
            InitializeComponent();
            cmbNumberOfRooms.Items.Add(new NumberOfRooms("1"));
            cmbNumberOfGuests.Items.Add(new NumberOfRooms("1"));
        }

        private void cmbNumberofRooms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNumberOfGuests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
