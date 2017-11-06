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

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            bool bFound = false;
            admins = adminController.AllAdmins;
            foreach (Admin admin in admins)
            {
                if (txtboxUsername.Text == admin.Username && txtboxPassword.Text == admin.Password)
                {
                    bFound = true;
                }
            }

            if (bFound==true)
            {
                HomeScreenForm hsm = new HomeScreenForm();
                this.Hide();
                hsm.ShowDialog();
                this.Close();
            }
            if (bFound==false)
            {
                MessageBox.Show("The login details entered are not correct, please try again.");

            }

        }
    }
}
