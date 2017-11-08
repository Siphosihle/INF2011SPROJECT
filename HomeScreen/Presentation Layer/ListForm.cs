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
    public partial class ListForm : Form
    {
        private string formstate;

        list

        private BookingController bookingcontroller;
        private Booking booking;
        private Collection<Booking> bookings;

        public ListForm(string frmstate)
        {
            InitializeComponent();

            bookingcontroller = new BookingController;
            bookings = bookingcontroller.AllBookings;

            this.Activated += EmployeeListForm_Activated;

            formstate = frmstate;

        }

        private void ListForm_Load(object sender, EventArgs e)
        {

        }

        private void ListForm_Activated(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            setUpListView();
            ShowAll(false);
        }

        private void setUpListView()
        {

            ListViewItem bookingdetails;
            Booking bking;
            listView1.Clear();

            listView1.Columns.Insert(0, "ReservationNumber", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(0, "GuestID", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(0, "NoOfRooms", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(0, "NoOfPeople", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(0, "StartDate", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(0, "EndDate", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(0, "SentConfirmation", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(0, "ReceivedConfirmation", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(0, "IsCancelled", 120, HorizontalAlignment.Left);


            Collection<Booking> bookings = null;
            switch (formstate)
            {
                case "Enquiry":
                case "Update":
                case "Delete":
                    bookings = bookingcontroller.AllBookings;
                    break;
            }
            
            foreach(Booking booking in bookings)
            {
                bookingDetails = new ListViewItem();

                employeeDetails = new ListViewItem();
                employeeDetails.Text = employee.ID.ToString();
                // Do the same for Gender, HomeLanguage, PopGroup and SA_Citizenship_Status
                employeeDetails.SubItems.Add(employee.EmpID);
                employeeDetails.SubItems.Add(employee.Name);
                employeeDetails.SubItems.Add(employee.Phone);
                switch (employee.role.RoleValue)
                {
                    case Role.RoleType.Headwaiter:
                        headW = (HeadWaiter)employee.role;
                        employeeDetails.SubItems.Add(headW.Salary.ToString());
                        break;
                    case Role.RoleType.Waiter:
                        waiter = (Waiter)employee.role;
                        employeeDetails.SubItems.Add(waiter.Rate.ToString());
                        employeeDetails.SubItems.Add(waiter.NumberOfShifts.ToString());
                        break;
                    case Role.RoleType.Runner:
                        runner = (Runner)employee.role;
                        employeeDetails.SubItems.Add(runner.Rate.ToString());
                        employeeDetails.SubItems.Add(runner.NumberOfShifts.ToString());
                        break;
                }
                listView1.Items.Add(employeeDetails);



            }

            listView1.Refresh();
            listView1.GridLines = true;


        }



    

        private void ShowAll(bool v)
        {
            label1.Visible = v;
            label2.Visible = v;
            label3.Visible = v;
            label4.Visible = v;
            label5.Visible = v;
            label6.Visible = v;
            label7.Visible = v;
            label8.Visible = v;
            label9.Visible = v;

            if(formstate == "Update")
            {
                btnDelete.Enabled = false;
            }
            if(formstate == "Delete")
            {
                btnUpdate.Enabled = false;
            }
            
        }
    }
}
