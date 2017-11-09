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
    public partial class PaymentForm : Form
    {
        private RestEasyMDIParent mdiParent;

        private Guest guest;
        private Booking booking;
        private Account accountObj;
        private AccountController accountController;
        private Collection<Account> accounts;
        public bool confirmFormClosed;

        public PaymentForm()
        {
            InitializeComponent();
            accountController = new AccountController();
            this.FormClosed += Form_Closed;
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            confirmFormClosed = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewBooking nb = new NewBooking(guest, booking);
            this.Hide();
            nb.MdiParent = mdiParent;
            nb.StartPosition = FormStartPosition.CenterParent;
            nb.ShowDialog();
            this.Close();
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            int count = 0;
            bool bFound = false;
            accounts = accountController.AllAccounts;
            foreach (Account account in accounts)
            {
                if (txtAccountID.Text == account.AccountID)
                {
                    bFound = true;
                    count++;
                }
            }

            if ((bFound == true))
            {

                accountObj = accountController.Find(txtAccountID.Text);

                MessageBox.Show("Existing Account");
                //ListForm lf = new ListForm(accountController);
                //this.Hide();
                //lf.Show();
                //this.Close();
                ////confirm.ShowData(); 
            }
            if ((bFound == false) && (count == 1))
            {
                MessageBox.Show("New Account");
                //NewGuestForm ngf = new NewGuestForm();
                //this.Hide();
                //ngf.ShowDialog();
                //this.Close();
            }
            if (count == 0)
            {
                MessageBox.Show("Please enter all the details");
            }
        }
    }
}
