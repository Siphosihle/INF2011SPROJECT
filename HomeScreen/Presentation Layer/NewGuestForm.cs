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
        private ListForm lvForm;

        private Guest guest;
        private Booking booking;
        private Hotel hotel;

        private GuestController guestController;

        public NewGuestForm(Booking bking, Hotel htl, long gstID)
        {
            InitializeComponent();
            guestController = new GuestController();

            txtboxID.Text = gstID.ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //CustomerInformationForm cif = new CustomerInformationForm(booking, guest, hotel);
            this.Hide();
            //cif.ShowDialog();
            this.Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            
            try
            {
                PopulateObject();
                MessageBox.Show("To be submitted to the Database!");
                guestController.DataMaintenance(guest, DB.DBOperation.Add);
                guestController.FinalizeChanges(guest);
                ClearAll();

                lvForm = new ListForm("guest", "update", booking, guest, hotel);
                lvForm.MdiParent = this.MdiParent;
                lvForm.StartPosition = FormStartPosition.CenterParent;
                this.Hide();
                lvForm.Show();
                this.Close();

            }
            catch
            {
                MessageBox.Show("Please Fill in valid data");
            }
            



        }

        private void ShowAll(bool v)
        {
            throw new NotImplementedException();
        }

        private void ClearAll()
        {
            txtboxID.Clear();
            txtboxAddress.Clear();
            txtboxCellphone.Clear();
            txtboxEmail.Clear();
            txtboxFirstName.Clear();
            txtboxSurname.Clear();
        }

        private void PopulateObject()
        {
            guest = new Guest();
            guest.GuestID = Int32.Parse(txtboxID.Text);
            guest.Name = Convert.ToString(txtboxID.Text);
            guest.Surname = Convert.ToString(txtboxID.Text);
            guest.PhoneNumber = Convert.ToString(txtboxID.Text);
            guest.Address = Convert.ToString(txtboxID.Text);
            guest.Email = Convert.ToString(txtboxID.Text);
            guest.Status = Convert.ToString(txtboxID.Text);

            

        }

    }
}
