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
        private Admin obj = new Admin();
        private string name;
        private string password;
        public bool adminLoginFormClosed = false;
        #region Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        #endregion
        public AdminLoginForm()
        {
            InitializeComponent();
            this.FormClosed += AdminLoginForm_Closed;
        }

        private void AdminLoginForm_Closed(object sender, FormClosedEventArgs e)
        {
            adminLoginFormClosed = true;
        }

        private void lbCheckInDate_Click(object sender, EventArgs e)
        {

        }

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {

        }
        private void PopulateObject(string name, string password)
        {
            name = txtboxUsername.Text;
            password = txtboxPassword.Text;
            obj.Login(name, password);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            PopulateObject(Name, Password);
            if (Admin.accessGranted == true)
            {
                HomeScreenForm hsm = new HomeScreenForm();
                this.Hide();
                hsm.ShowDialog();
                this.Close();
                
            }
            else if (Admin.accessGranted == false)
            {
                MessageBox.Show("The login details entered are not correct, please try again.");
            }
           
        }
    }
}
