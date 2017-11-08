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
using HomeScreen.Database_Layer;
using HomeScreen.Business_Layer;

namespace HomeScreen.Presentation_Layer
{
    public partial class RestEasyMDIParent : Form
    {
        public enum FormState
        {
            LoggedOff = 0,
            LoggedOn = 1
        }



        #region Properties
        private int childFormNumber = 0;

        private AdminLoginForm adminForm;
        private AvailableRoomsForm availableRoomsForm;
        private BookingDetailsForm bookingEnquiryForm;
        private ConfirmGuestForm confirmGuestForm;
        private ConfirmReservationForm confirmReservationForm;
        private CreditCardPaymentForm ccPaymentForm;
        private CustomerInformationForm custInfoForm;
        private HomeScreenForm homeScreenForm;
        private ListForm lstForm;
        private NewBooking newBookingForm;
        private NewGuestForm newGuestForm;
        private PaymentForm paymentForm;

        private AdminController admincontroller;
        private BookingController bookingController;
        private HotelController hotelController;

        private Collection<Room> availableRooms;

        private FormState frmState;

        #endregion

        #region Constructors
        public RestEasyMDIParent()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            admincontroller = new AdminController();
            bookingController = new BookingController();
            hotelController = new HotelController();

            availableRooms = new Collection<Room>();

            rall
            frmState = FormState.LoggedOff;
        }
        #endregion

        #region Properties

        public Collection<Room> AvailableRooms
        {
            get { return availableRooms; }
            set { availableRooms = value; }
        }

        public AdminLoginForm AdminForm
        {
            get
            {
                return adminForm;
            }

            set
            {
                adminForm = value;
            }
        }

        #endregion

        #region Form Events (MenuStrip)
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        #endregion

        #region Child Forms

        public void CreateNewAdminForm()
        {
            adminForm = new AdminLoginForm();
            adminForm.MdiParent = this;
            adminForm.StartPosition = FormStartPosition.CenterParent;
        }

        public void CreateNewAvailRoomForm()
        {
            availableRoomsForm = new AvailableRoomsForm();
            availableRoomsForm.MdiParent = this;
            availableRoomsForm.StartPosition = FormStartPosition.CenterParent;
        }

        public void CreateNewBookingEnquiryForm()
        {
            bookingEnquiryForm = new BookingDetailsForm();
            bookingEnquiryForm.MdiParent = this;
            bookingEnquiryForm.StartPosition = FormStartPosition.CenterParent;
        }

        public void CreateNewConfirmGuest()
        {
            confirmGuestForm = new ConfirmGuestForm();
            confirmGuestForm.MdiParent = this;
            confirmGuestForm.StartPosition = FormStartPosition.CenterParent;
        }
        public void CreateNewConfirmReservationForm()
        {
            confirmReservationForm = new ConfirmReservationForm();
            confirmReservationForm.MdiParent = this;
            confirmReservationForm.StartPosition = FormStartPosition.CenterParent;
        }
        public void CreateNewCreditCardPaymentForm()
        {
            ccPaymentForm = new CreditCardPaymentForm();
            ccPaymentForm.MdiParent = this;
            ccPaymentForm.StartPosition = FormStartPosition.CenterParent;
        }
        public void CreateNewCustomerInformationForm()
        {
            custInfoForm = new CustomerInformationForm();
            custInfoForm.MdiParent = this;
            custInfoForm.StartPosition = FormStartPosition.CenterParent;
        }
        public void CreateNewHomeScreenForm()
        {
            homeScreenForm = new HomeScreenForm();
            homeScreenForm.MdiParent = this;
            homeScreenForm.StartPosition = FormStartPosition.CenterParent;
        }
        public void CreateNewListForm()
        {
            adminForm = new AdminLoginForm();
            adminForm.MdiParent = this;
            adminForm.StartPosition = FormStartPosition.CenterParent;
        }
        public void CreateNewAdminForm()
        {
            adminForm = new AdminLoginForm();
            adminForm.MdiParent = this;
            adminForm.StartPosition = FormStartPosition.CenterParent;
        }
        public void CreateNewAdminForm()
        {
            adminForm = new AdminLoginForm();
            adminForm.MdiParent = this;
            adminForm.StartPosition = FormStartPosition.CenterParent;
        }
        public void CreateNewAdminForm()
        {
            adminForm = new AdminLoginForm();
            adminForm.MdiParent = this;
            adminForm.StartPosition = FormStartPosition.CenterParent;
        }
        public void CreateNewAdminForm()
        {
            adminForm = new AdminLoginForm();
            adminForm.MdiParent = this;
            adminForm.StartPosition = FormStartPosition.CenterParent;
        }

        #endregion

        #region ToolStripMenu Items
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        #endregion

        #region Display Forms



        private void DisplayAdminForm()
        {
            if (adminForm == null)
            {
                CreateNewAdminForm();
            }
            if (adminForm.adminLoginFormClosed)
            {
                CreateNewAdminForm();
            }
            adminForm.Show();
        }

        private void DisplayBookingEnquiryForm()
        {
            if (bookingEnquiryForm == null)
            {
                CreateNewBookingEnquiryForm();
            }
            if (bookingEnquiryForm.bookingFormClosed == true)
            {
                CreateNewBookingEnquiryForm();
            }
            bookingEnquiryForm.Show();
        }



        #endregion

        private void RestEasyMDIParent_Load(object sender, EventArgs e)
        {
            DisplayAdminForm();
        }

        private void makeABookingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
