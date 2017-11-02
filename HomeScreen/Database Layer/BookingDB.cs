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
    class BookingDB: DB
    {
        private string table1 = "Booking";
        private string sqlLocal1 = "SELECT * FROM Booking";

        private Collection<Booking> bookings;

        public struct ColumnAttribs
        {
            public string myName;
            public SqlDbType myType;
            public int mySize;
        }

        public BookingDB(): base()
        {
            bookings = new Collection<Booking>();
            FillDataSet(sqlLocal1, table1);
            //Add2Collection(table1);

        }

        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        public DataSet GetDataSet()
        {
            return dsMain;
        }

        #region Database Operations CRUD --- Add the object's values to the database
        public void DataSetChange(Booking aBooking, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, aBooking, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aBooking, dataTable)];
                    FillRow(aRow, aBooking, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aBooking, dataTable)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Utility Methods
        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;
            Booking aBooking;
            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Employee object
                    aBooking = new Booking();
                    //Obtain each employee attribute from the specific field in the row in the table
                    aBooking.ReservationNumber = Convert.ToInt32(myRow["ID"]);
                    aBooking.NoOfRooms = Convert.ToInt32(myRow["NoOfRooms"]);
                    aBooking.StartDate = Convert.ToDateTime(myRow["StartDate"]);
                    aBooking.EndDate = Convert.ToDateTime(myRow["EndDate"]);
                    aBooking.SentConfirmation = Convert.ToBoolean(myRow["SentConfirmation"]);
                    aBooking.RecievedDeposit = Convert.ToBoolean(myRow["RecievedDeposit"]);
                    aBooking.IsCancelled = Convert.ToBoolean(myRow["IsCancelled"]);

                    bookings.Add(aBooking);
                }
            }
        }
        private void FillRow(DataRow aRow, Booking aBooking, DB.DBOperation operation)
        {
            Booking booking;
            if (operation == DB.DBOperation.Add)
            {
                aRow["ReservationNumber"] = aBooking.ReservationNumber;  //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["NoOfRooms"] = aBooking.NoOfRooms;
            aRow["StartDate"] = aBooking.StartDate;
            aRow["EndDate"] = aBooking.EndDate;

        }

        //The FindRow method finds the row for a specific employee(by ID)  in a specific table
        private int FindRow(Booking aBooking, string table)
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
                    if (aBooking.ReservationNumber == Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["ID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Booking aBooking)
        {
            //Create Parameters to communicate with SQL INSERT
            //https://www.google.co.za/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=size+in+bytes+of+Int+in+SQL
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@EMPID", SqlDbType.NVarChar, 10, "ID");
            daMain.InsertCommand.Parameters.Add(param);

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Role", SqlDbType.TinyInt, 1, "Role");
            daMain.InsertCommand.Parameters.Add(param);
            switch (anEmp.role.RoleValue)
            {
                case Role.RoleType.Headwaiter:
                    param = new SqlParameter("@Salary", SqlDbType.Money, 8, "Salary");
                    daMain.InsertCommand.Parameters.Add(param);
                    break;
                case Role.RoleType.Waiter:
                    param = new SqlParameter("@Tips", SqlDbType.Money, 8, "Tips");
                    daMain.InsertCommand.Parameters.Add(param);

                    param = new SqlParameter("@DayRate", SqlDbType.Money, 8, "DayRate");
                    daMain.InsertCommand.Parameters.Add(param);

                    param = new SqlParameter("@NoOfShifts", SqlDbType.SmallInt, 4, "NoOfShifts");
                    daMain.InsertCommand.Parameters.Add(param);
                    break;
                case Role.RoleType.Runner:
                    param = new SqlParameter("@DayRate", SqlDbType.Money, 8, "DayRate");
                    daMain.InsertCommand.Parameters.Add(param);

                    param = new SqlParameter("@NoOfShifts", SqlDbType.SmallInt, 4, "NoOfShifts");
                    daMain.InsertCommand.Parameters.Add(param);
                    break;
            }
            //***https://msdn.microsoft.com/en-za/library/ms179882.aspx
        }

        private void Build_UPDATE_Parameters(Booking aBooking)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //Do for all fields other than ID and EMPID as for Insert 
            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Role", SqlDbType.TinyInt, 1, "Role");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            switch (anEmp.role.RoleValue)
            {
                case Role.RoleType.Headwaiter:
                    param = new SqlParameter("@Salary", SqlDbType.Money, 8, "Salary");
                    param.SourceVersion = DataRowVersion.Current;
                    daMain.UpdateCommand.Parameters.Add(param);
                    break;
                case Role.RoleType.Waiter:
                    param = new SqlParameter("@Tips", SqlDbType.Money, 8, "Tips");
                    param.SourceVersion = DataRowVersion.Current;
                    daMain.UpdateCommand.Parameters.Add(param);

                    param = new SqlParameter("@DayRate", SqlDbType.Money, 8, "DayRate");
                    param.SourceVersion = DataRowVersion.Current;
                    daMain.UpdateCommand.Parameters.Add(param);

                    param = new SqlParameter("@NoOfShifts", SqlDbType.SmallInt, 4, "NoOfShifts");
                    param.SourceVersion = DataRowVersion.Current;
                    daMain.UpdateCommand.Parameters.Add(param);
                    break;
                case Role.RoleType.Runner:
                    param = new SqlParameter("@DayRate", SqlDbType.Money, 8, "DayRate");
                    param.SourceVersion = DataRowVersion.Current;
                    daMain.UpdateCommand.Parameters.Add(param);

                    param = new SqlParameter("@NoOfShifts", SqlDbType.SmallInt, 4, "NoOfShifts");
                    param.SourceVersion = DataRowVersion.Current;
                    daMain.UpdateCommand.Parameters.Add(param);
                    break;
            }
            //testing the ID of record that needs to change with the original ID of the record
            param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "ID");
            param.SourceVersion = DataRowVersion.Original;
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
        private void Create_INSERT_Command(Booking aBooking)
        {
            //Create the command that must be used to insert values into the Books table..
            switch (anEmp.role.RoleValue)
            {
                case Role.RoleType.Headwaiter:
                    daMain.InsertCommand = new SqlCommand("INSERT into HeadWaiter (ID, EMPID, Name, Phone, Role, Salary) VALUES (@ID, @EmpID, @Name, @Phone, @Role, @Salary)", cnMain);
                    break;
                case Role.RoleType.Waiter:
                    daMain.InsertCommand = new SqlCommand("INSERT into Waiter (ID, EMPID, Name, Phone, Role, Tips, DayRate, NoOfShifts) VALUES (@ID, @EmpID, @Name, @Phone, @Role, @Tips, @DayRate, @NoOfShifts)", cnMain);
                    break;
                case Role.RoleType.Runner:
                    daMain.InsertCommand = new SqlCommand("INSERT into Runner (ID, EMPID, Name, Phone, Role, DayRate, NoOfShifts) VALUES (@ID, @EmpID, @Name, @Phone, @Role, @DayRate, @NoOfShifts)", cnMain);
                    break;
            }
            Build_INSERT_Parameters(anEmp);
        }

        private void Create_UPDATE_Command(Booking aBooking)
        {
            //Create the command that must be used to insert values into one of the three tables
            //Assumption is that the ID and EMPID cannot be changed

            switch (anEmp.role.RoleValue)
            {
                case Role.RoleType.Headwaiter:
                    daMain.UpdateCommand = new SqlCommand("UPDATE HeadWaiter SET Name =@Name, Phone =@Phone, Role =@Role, Salary = @Salary " + "WHERE ID = @Original_ID", cnMain);
                    break;
                case Role.RoleType.Waiter:
                    daMain.UpdateCommand = new SqlCommand("UPDATE Waiter SET Name =@Name, Phone =@Phone, Role =@Role, Tips =@Tips, DayRate =@DayRate, NoOfShifts =@NoOfShifts " + "WHERE ID = @Original_ID", cnMain);
                    break;
                case Role.RoleType.Runner:
                    daMain.UpdateCommand = new SqlCommand("UPDATE Runner SET Name =@Name, Phone =@Phone, Role =@Role, DayRate =@DayRate, NoOfShifts =@NoOfShifts " + "WHERE ID = @Original_ID", cnMain);
                    break;
            }
            Build_UPDATE_Parameters(anEmp);
        }

        private string Create_DELETE_Command(Booking aBooking)
        {
            string errorString = null;
            //Create the command that must be used to delete values from the the appropriate table
            switch (anEmp.role.RoleValue)
            {
                case Role.RoleType.Headwaiter:
                    daMain.DeleteCommand = new SqlCommand("DELETE FROM HeadWaiter WHERE ID = @ID", cnMain);
                    break;
                case Role.RoleType.Waiter:
                    daMain.DeleteCommand = new SqlCommand("DELETE FROM Waiter WHERE ID = @ID", cnMain);
                    break;
                case Role.RoleType.Runner:
                    daMain.DeleteCommand = new SqlCommand("DELETE FROM Runner WHERE ID = @ID", cnMain);
                    break;
            }
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
        public bool UpdateDataSource(Booking aBooking)
        {
            bool success = true;
            Create_INSERT_Command(aBooking);
            Create_UPDATE_Command(aBooking);
            Create_DELETE_Command(aBooking);
            switch (anEmp.role.RoleValue)
            {
                case Role.RoleType.Headwaiter:
                    success = UpdateDataSource(sqlLocal1, table1);
                    break;
                case Role.RoleType.Waiter:
                    success = UpdateDataSource(sqlLocal2, table2);
                    break;
                case Role.RoleType.Runner:
                    success = UpdateDataSource(sqlLocal3, table3);
                    break;
            }
            return success;
        }
        #endregion */


    }
}
