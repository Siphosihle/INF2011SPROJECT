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
using HomeScreen.Presentation_Layer;

namespace HomeScreen.Presentation_Layer
{
    public partial class AvailableRoomsForm : Form
    {
        public bool confirmFormClosed = false;

        private HomeScreenForm homescreenform;
        private CustomerInformationForm custInfoForm;

        private BookingDetailsForm bookingDetails;
        private Collection<Room> availableRooms;

        private RoomController roomcontroller;

        private Hotel hotel;
        private Booking booking;
        private Guest guest;

        public AvailableRoomsForm(Collection<Room> availrooms, Hotel htl, Booking bking)
        {
            InitializeComponent();
            this.FormClosed += AvailableRoomsForm_Closed;

            roomcontroller = new RoomController();

            availableRooms = availrooms;
            hotel = htl;
            booking = bking;

            this.Load += AvailableRoomsForm_Load;
            this.Activated += AvailableRoomsForm_Activated;
            this.FormClosed += AvailableRoomsForm_FormClosed;

        }

        private void AvailableRoomsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void AvailableRoomsForm_Activated(object sender, EventArgs e)
        {

            listView1.View = View.Details;
            setUpListView();
            ShowAll1(false);

        }

        private void ShowAll1(bool v)
        {
        }

        private void setUpListView()
        {

            ListViewItem sDetails;
            listView1.Clear();

                    listView1.Columns.Insert(0, "HotelID", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(1, "RoomID", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(2, "RoomNo", 120, HorizontalAlignment.Left);
                    listView1.Columns.Insert(3, "NoOfPeople", 120, HorizontalAlignment.Left);

                    
                    listView1.Text = "Listing of all Guests";

                    foreach (Room r in availableRooms)
                    {
                        sDetails = new ListViewItem();
                        sDetails.Text = r.RoomID.ToString();
                        sDetails.SubItems.Add(r.HotelID.ToString());
                        sDetails.SubItems.Add(r.RoomNo.ToString());
                        sDetails.SubItems.Add(r.NoOfPeople.ToString());


                        listView1.Items.Add(sDetails);
                    }

            listView1.Refresh();
            listView1.GridLines = true;

        }

        private void AvailableRoomsForm_Closed(object sender, FormClosedEventArgs e)
        {
            confirmFormClosed = true;
        }

        private void rtbAvailableRooms_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            BookingDetailsForm hs = new BookingDetailsForm();
            this.Hide();
            hs.Show();
            hs.MdiParent = this;
            hs.StartPosition = FormStartPosition.CenterParent;
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ListForm hs = new ListForm(booking, guest, hotel);
            this.Hide();
            hs.Show();
            hs.MdiParent = this.MdiParent;
            hs.StartPosition = FormStartPosition.CenterParent;
            this.Close();
        }

        private void AvailableRoomsForm_Load(object sender, EventArgs e)
        {
            string sAvailRoom = "The following rooms are available for " + hotel.HotelName ;
            for(int i = 0; i < availableRooms.Count;i++)
            {
                sAvailRoom += "Room No " + availableRooms[i].RoomNo + "\n";
            }




        }

        private void lblAvailableRooms_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();

            homescreenform = new HomeScreenForm();
            homescreenform.MdiParent = this.MdiParent;
            homescreenform.StartPosition = FormStartPosition.CenterParent;
            homescreenform.Show();
        }
    }
}
