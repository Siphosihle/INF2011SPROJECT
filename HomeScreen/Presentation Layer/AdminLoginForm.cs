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
    public partial class AdminLoginForm : Form
    {
        private Collection<Admin> admins;
        private Admin admin;
        private AdminController adminController;
        private string name;
        private string password;
        public bool adminLoginFormClosed = false;

        #region Properties
        public new string Name
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
            adminController = new AdminController();
            this.FormClosed += AdminLoginForm_Closed;
        }

        private void AdminLoginForm_Closed(object sender, FormClosedEventArgs e)
        {
            adminLoginFormClosed = true;
        }

        private void PopulateAdmin()
        {
            admin = new Admin();
            admin.Username = txtboxUsername.Text;
            admin.Password = txtboxPassword.Text;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            PopulateAdmin();


            /*if (Admin.accessGranted == true)
            {
                HomeScreenForm hsm = new HomeScreenForm();
                this.Hide();
                hsm.ShowDialog();
                this.Close();
                
            }
            else if (Admin.accessGranted == false)
            {
                MessageBox.Show("The login details entered are not correct, please try again.");
            } */
           
        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
