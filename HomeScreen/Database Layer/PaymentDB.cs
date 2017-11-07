using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Xml;
//namespaces
using HomeScreen.Business_Layer;
using HomeScreen.Database_Layer;

namespace HomeScreen.Database_Layer
{
    public class PaymentDB: DB
    {

        private string table1 = "Payments";
        private string sqlLocal1 = "SELECT * FROM Payments";

        private Collection<Payment> payments;



        public PaymentDB(): base()
        {
            payments = new Collection<Payment>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
        }

        #region Properties

        public Collection<Payment> AllPayments
        {
            get { return payments; }
        }

        #endregion

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;

            Payment aPayment;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aPayment = new Payment();

                    aPayment.InvoiceNumber = Convert.ToInt32(myRow["InvoiceNumber"]);
                    aPayment.AccountID = Convert.ToInt32(myRow["AccountID"]);
                    aPayment.CCID = Convert.ToString(myRow["CCID"]);
                    aPayment.GuestID = Convert.ToInt32(myRow["GuestID"]);
                    aPayment.ReservationNumber = Convert.ToInt32(myRow["ReservationNumber"]);
                    aPayment.Amount = Convert.ToInt32(myRow["Amount"]);

                    payments.Add(aPayment);


                }
            }

        }




    }
}
