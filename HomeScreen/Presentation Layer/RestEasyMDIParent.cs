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



        #region Data Members
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
        private RoomAllocationController rAllController;

        private Collection<Room> availableRooms;
        private Hotel hotel;

        public FormState frmState;
        private Booking booking;
        private Guest guest;

        #endregion

        #region Constructors
        public RestEasyMDIParent(string LggdIn)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            admincontroller = new AdminController();
            bookingController = new BookingController();
            hotelController = new HotelController();
            rAllController = new RoomAllocationController();

            availableRooms = new Collection<Room>();
            hotel = new Business_Layer.Hotel();

            //rAllController.AvailRoomsInst += RoomAllocationController_AvailRoomsInst;
            frmState = FormState.LoggedOff;
            this.accountsToolStripMenuItem.Enabled = false;
            this.adminsToolStripMenuItem.Enabled = false;
            this.hotelsToolStripMenuItem.Enabled = false;
            this.hotelsToolStripMenuItem.Enabled = false;
            this.paymentsToolStripMenuItem.Enabled = false;
            this.roomsToolStripMenuItem.Enabled = false;
            this.roomRatesToolStripMenuItem.Enabled = false;

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
            adminForm = new AdminLoginForm(this);
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



        private void DisplayAdminForm(RestEasyMDIParent prntfrm)
        {
            if (adminForm == null)
            {
                CreateNewAdminForm();
            }
            if (adminForm.confirmFormClosed)
            {
                CreateNewAdminForm();
            }
            adminForm.Show();
        }
        



        #endregion

        #region Methods

        private void RoomAllocationController_AvailRoomsInst(Collection<Room> availrms)
        {

            availableRooms = availrms;

        }

        #endregion

        #region FormEvents
        private void RestEasyMDIParent_Load(object sender, EventArgs e)
        {
            DisplayAdminForm(this);
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAdminForm(this);
        }

        protected virtual void OnLogIn(EventArgs e)
        {
            EventHandler handler = LogIn;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler LogIn;

        #endregion
    }
}
