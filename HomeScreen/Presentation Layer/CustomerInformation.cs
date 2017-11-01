using HomeScreen.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeScreen
{
    public partial class CustomerInformation : Form
    {
        private Guest guest;
        public CustomerInformation()
        {
            InitializeComponent();
        }
        private void PopulateObject(string name, string surname, string id)
        {
            //HeadWaiter headW;
            //Waiter waiter;
            //Runner runner;
            Guest existingGuest;
            Guest newGuest;
            //guest = new Type(name, surname, id);
            guest.Name = txtboxFirstName.Text;
            guest.Surname = txtboxLastName.Text;
            guest.GuestID = txtboxID.Text;

            //switch (guest.GuestValue)
            //{
            //    case Guest.GuestType.ExistingGuest:
            //        headW = (Guest)(guest.);
            //        headW.Salary = decimal.Parse(paymentTextBox.Text);
            //        break;
            //    case Role.RoleType.Waiter:
            //        //***waiter to be done later for HW
            //        waiter = (Waiter)(employee.role);
            //        waiter.Rate = decimal.Parse(paymentTextBox.Text);
            //        waiter.NumberOfShifts = int.Parse(hoursTextBox.Text);
            //        //  waiter.Tips = decimal.Parse(tipsTextBox.Text);
            //        break;
            //    case Role.RoleType.Runner:
            //        //***waiter to be done later for HW
            //        runner = (Runner)(employee.role);
            //        runner.Rate = decimal.Parse(paymentTextBox.Text);
            //        runner.NumberOfShifts = int.Parse(hoursTextBox.Text);
            //        break;
            }
        }
    
}
