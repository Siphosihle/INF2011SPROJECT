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

        #region Database Operations CRUD --- Add the object's values to the database
        public void DataSetChange(Payment pmt, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, pmt, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(pmt, dataTable)];
                    FillRow(aRow, pmt, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(pmt, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Methods
        private int FindRow(Payment pmt, string dataTable)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table1].Rows)
            {
                myRow = myRow_loopVariable;
                //Ignore rows marked as deleted in dataset
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //In c# there is no item property (but we use the 2-dim array) it is automatically known to the compiler when used as below
                    if (pmt.InvoiceNumber == Convert.ToInt32(dsMain.Tables[table1].Rows[rowIndex]["InvoiceNumber"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }

        private void FillRow(DataRow aRow, Payment pmt, DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["InvoiceNumber"] = pmt.InvoiceNumber;  //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["CCID"] = pmt.CCID;
            aRow["GuestID"] = pmt.GuestID;
            aRow["AccountID"] = pmt.AccountID;
            aRow["Amount"] = pmt.Amount;
        }

         #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Payment pmt)
        {
            //Create Parameters to communicate with SQL INSERT
            //https://www.google.co.za/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=size+in+bytes+of+Int+in+SQL
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@InvoiceNumber", SqlDbType.Int, 20, "InvoiceNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CCID", SqlDbType.NVarChar, 10, "CCID");
            daMain.InsertCommand.Parameters.Add(param);

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 50, "Surame");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@AccountID", SqlDbType.NVarChar, 15, "AccountID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Amount", SqlDbType.NVarChar, 50, "Amount");
            daMain.InsertCommand.Parameters.Add(param);
            //***https://msdn.microsoft.com/en-za/library/ms179882.aspx
        }

        private void Build_UPDATE_Parameters(Payment pmt)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@CCID", SqlDbType.NVarChar, 50, "CCID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 50, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Amount", SqlDbType.NVarChar, 50, "Amount");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters()
        {
            //--Create Parameters to communicate with SQL DELETE
            SqlParameter param;
            param = new SqlParameter("@InvoiceNumber", SqlDbType.Int, 20, "InvoiceNumber");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }
        private void Create_INSERT_Command(Payment pmt)
        {
            //Create the command that must be used to insert values into the Books table..
            daMain.InsertCommand = new SqlCommand("INSERT into Payments (InvoiceNumber, CCID, GuestID, AccountID, Amount) VALUES (@InvoiceNumber, @CCID, @GuestID, @AccountID, @Amount)", cnMain);
            Build_INSERT_Parameters(pmt);
        }

        private void Create_UPDATE_Command(Payment pmt)
        {
            //Create the command that must be used to insert values into one of the three tables
            //Assumption is that the ID and EMPID cannot be changed
            daMain.UpdateCommand = new SqlCommand("UPDATE Payments SET CCID =@CCID, GuestID =@GuestID, AccountID =@AccountID, Amount =@Amount, " + "WHERE InvoiceNumber = @Original_InvoiceNumber", cnMain);
            Build_UPDATE_Parameters(pmt);
        }

        private string Create_DELETE_Command(Payment pmt)
        {
            string errorString = null;
            //Create the command that must be used to delete values from the the appropriate table
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Payments WHERE InvoiceNumber = @InvoiceNumber", cnMain);
            try
            {
                Build_DELETE_Parameters();
            }
            catch (Exception errObj)
            {
                errorString = errObj.Message + "  " + errObj.StackTrace;
            }
            return errorString;
        }
        public bool UpdateDataSource(Payment pmt)
        {
            bool success = true;
            Create_INSERT_Command(pmt);
            Create_UPDATE_Command(pmt);
            Create_DELETE_Command(pmt);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }

        #endregion


    }
}
