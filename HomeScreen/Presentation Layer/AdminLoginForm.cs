using System;
using System.Collections.Generic;
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
    public partial class AdminLoginForm : Form
    {
        private Admin obj;
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void lbCheckInDate_Click(object sender, EventArgs e)
        {

        }

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {

        }
        private void PopulateObject(string name, string password)
        {
            obj = new Admin();
            obj.username = txtboxUsername.Text;
            obj.userpassword = txtboxPassword.Text;
            obj.Login(obj.username, obj.userpassword);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Admin call = new Admin();
            if (call.accessGranted == true)
            {
                MessageBox.Show("The login details are correct");
            }
            else
            {
                MessageBox.Show("The login details are not correct");
            }
        }
    }
}
