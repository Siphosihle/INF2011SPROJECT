using HomeScreen.Business_Layer;
using System.Collections.ObjectModel;
using System.Data;
using System;
using System.Data.SqlClient;

namespace HomeScreen.Database_Layer
{
    class GuestDB : DB
    {
        private string table = "Guests";
        private string sqlLocal = "SELECT * FROM Guests";
        private Collection<Guest> guest;

        public struct ColumnAttribs
        {
            public string myName;
            public SqlDbType myType;
            public int mySize;
        }

        //Default Constructor
        public GuestDB() : base()
        {
            guest = new Collection<Guest>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
        }
        public Collection<Guest> AllEmployees
        {
            get
            {
                return guest;
            }
        }
        public DataSet GetDataSet()
        {
            return dsMain;
        }
        #region Database Operations CRUD --- Add the object's values to the database
        public void DataSetChange(Guest gst, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, gst, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(gst, dataTable)];
                    FillRow(aRow, gst, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(gst, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion
        #region Methods
        private int FindRow(Guest gst, string dataTable)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                //Ignore rows marked as deleted in dataset
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //In c# there is no item property (but we use the 2-dim array) it is automatically known to the compiler when used as below
                    if (gst.GuestID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["GuestID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }

        private void FillRow(DataRow aRow, Guest gst, DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["GuestID"] = gst.GuestID;  //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["Name"] = gst.Name;
            aRow["Surname"] = gst.Surname;
            aRow["PhoneNo"] = gst.PhoneNumber;
            aRow["Address"] = gst.Address;
        }
 
        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;
            Guest aGuest;
            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aGuest = new Guest();
                    aGuest.GuestID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                    aGuest.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                    aGuest.Surname = Convert.ToString(myRow["Surname"]).TrimEnd();
                    aGuest.PhoneNumber = Convert.ToString(myRow["PhoneNo"]).TrimEnd();
                    aGuest.Address = Convert.ToString(myRow["Address"]).TrimEnd();
                    guest.Add(aGuest);
                }
            }
        }
        #endregion
        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Guest gst)
        {
            //Create Parameters to communicate with SQL INSERT
            //https://www.google.co.za/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=size+in+bytes+of+Int+in+SQL
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 15, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 10, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@Surname", SqlDbType.NVarChar, 100, "Surame");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@PhoneNo", SqlDbType.NVarChar, 15, "PhoneNo");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.TinyInt, 1, "Address");
            daMain.InsertCommand.Parameters.Add(param);
            //***https://msdn.microsoft.com/en-za/library/ms179882.aspx
        }

        private void Build_UPDATE_Parameters(Guest gst)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Surname", SqlDbType.NVarChar, 100, "Surname");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //Do for all fields other than ID and EMPID as for Insert 
            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.TinyInt, 1, "Address");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters()
        {
            //--Create Parameters to communicate with SQL DELETE
            SqlParameter param;
            param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }
        private void Create_INSERT_Command(Guest gst)
        {
            //Create the command that must be used to insert values into the Books table..
            daMain.InsertCommand = new SqlCommand("INSERT into Guests (GuestID, Name, Surname, PhoneNo, Address) VALUES (@GuestID, @Name, @Surname, @PhoneNo, @Address)", cnMain);
            Build_INSERT_Parameters(gst);
        }

        private void Create_UPDATE_Command(Guest gst)
        {
            //Create the command that must be used to insert values into one of the three tables
            //Assumption is that the ID and EMPID cannot be changed
            daMain.UpdateCommand = new SqlCommand("UPDATE Guests SET Name =@Name, Surname =@Surname, PhoneNo =@PhoneNo, Address =@Address, " + "WHERE GuestID = @Original_ID", cnMain);
            Build_UPDATE_Parameters(gst);
        }

        private string Create_DELETE_Command(Guest gst)
        {
            string errorString = null;
            //Create the command that must be used to delete values from the the appropriate table
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Guests WHERE GuestID = @GuestID", cnMain);
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
        public bool UpdateDataSource(Guest gst)
        {
            bool success = true;
            Create_INSERT_Command(gst);
            Create_UPDATE_Command(gst);
            Create_DELETE_Command(gst);
            success = UpdateDataSource(sqlLocal, table);
            return success;
        }
        #endregion

    }
}
