using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespaces
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Windows.Forms;
using HomeScreen.Properties; //Settings Property

namespace HomeScreen.Database_Layer
{
    public class DB
    {
        private string strConn = Settings.Default.RestEasySystemConnectionString;
        protected SqlConnection cnMain;
        protected DataSet dsMain;
        protected SqlDataAdapter daMain;

        protected string aSQLstring;  // to be initialised later
        public enum DBOperation
        {
            Add = 0,
            Edit = 1,
            Delete = 2
        }
        public DB()
        {
            try
            {
                //Open a connection & create a new dataset object
                cnMain = new SqlConnection(strConn);
                dsMain = new DataSet();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }

        public void FillDataSet(string aSQLstring, string aTable)
        {
            //fills dataset fresh from the db for a specific table and with a specific Query
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                cnMain.Open();
                //dsMain.Clear();   // need to have all the tables in the dataset
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }

        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try
            {
                //open the connection
                cnMain.Open();
                //***update the database table via the data adapter
                daMain.Update(dsMain, table);
                //---close the connection
                cnMain.Close();
                //refresh the dataset
                FillDataSet(sqlLocal, table);
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
            }
            finally
            {
            }
            return success;
        }
    }
}
