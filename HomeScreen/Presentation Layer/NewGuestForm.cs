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
using HomeScreen.Database_Layer;

namespace HomeScreen.Presentation_Layer
{
    public partial class NewGuestForm : Form
    {
        public NewGuestForm()
        {
            InitializeComponent();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //CustomerInformationForm cif = new CustomerInformationForm(booking, guest, hotel);
            this.Hide();
            //cif.ShowDialog();
            this.Close();
        }
    }
}
