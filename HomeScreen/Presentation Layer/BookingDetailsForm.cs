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
    }
}
