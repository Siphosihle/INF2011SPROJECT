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

        private RestEasyMDIParent mdiParent;
        private HomeScreenForm hsf;

        private Collection<Admin> admins;
        private Admin admin;
        private AdminController adminController;
        private string name;
        private string password;
        public bool confirmFormClosed = false;

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
        public AdminLoginForm(RestEasyMDIParent prntfrm)
        {
            InitializeComponent();

            mdiParent = prntfrm;

            adminController = new AdminController();
            this.FormClosed += AdminLoginForm_Closed;
        }

        private void AdminLoginForm_Closed(object sender, FormClosedEventArgs e)
        {
            confirmFormClosed = true;
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

                mdiParent.frmState = RestEasyMDIParent.FormState.LoggedOn;


                if (hsf == null)
                {
                    CreateNewHSF();
                }
                if (hsf.confirmFormClosed)
                {
                    CreateNewHSF();
                }
                this.Hide();
                hsf.Show();
                this.Close();
                


            }
            if (bFound==false)
            {
                MessageBox.Show("The login details entered are not correct, please try again.");

            }

        }

        private void CreateNewHSF( )
        {
            hsf = new HomeScreenForm();
            hsf.MdiParent = this.MdiParent;
            hsf.StartPosition = FormStartPosition.CenterParent;
        }

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
