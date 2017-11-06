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
    class RestEasyDB: DB
    {
        #region sql strings
        private string table1 = "Accounts";
        private string sqlLocal1 = "SELECT * FROM Accounts";
        private string table2 = "Admins";
        private string sqlLocal2 = "SELECT * FROM Admins";
        private string table3 = "BookingPayments";
        private string sqlLocal3 = "SELECT * FROM BookingPayments";
        private string table4 = "Bookings";
        private string sqlLocal4 = "SELECT * FROM Bookings";
        private string table5 = "CCDetails";
        private string sqlLocal5 = "SELECT * FROM CCDetails";
        private string table6 = "Guests";
        private string sqlLocal6 = "SELECT * FROM Guests";
        private string table7 = "Hotels";
        private string sqlLocal7 = "SELECT * FROM Hotels";
        private string table8 = "Payments";
        private string sqlLocal8 = "SELECT * FROM Payments";
        private string table9 = "RoomAllocation";
        private string sqlLocal9 = "SELECT * FROM RoomAllocation";
        private string table10 = "RoomCharge";
        private string sqlLocal10 = "SELECT * FROM RoomCharge";
        private string table11 = "RoomRates";
        private string sqlLocal11 = "SELECT * FROM RoomRates";
        private string table12 = "Rooms";
        private string sqlLocal12 = "SELECT * FROM Rooms";
        #endregion
        
        #region Collections

        private List<Type> types;
        private List<String> tableNames;
        private List<String> tableNamesLC;

        private Collection<Object> objects;

        private Collection<Account> accounts;
        private Collection<Admin> admins;
        private Collection<Booking> bookings;
        private Collection<CC> ccs;
        private Collection<Guest> guests;
        private Collection<Hotel> hotels;
        private Collection<Payment> payments;
        private Collection<RoomCharge> roomcharges;
        private Collection<Room> rooms;
        #endregion

        public struct ColumnAttribs
        {
            public string myName;
            public SqlDbType myType;
            public int mySize;
        }

        public RestEasyDB(): base()
        {
            types = new List<Type>()
            {
                typeof(Account), typeof(Admin), typeof(Booking), typeof(CC), typeof(Guest), typeof(Hotel), typeof(Payment), typeof(Room), typeof(RoomCharge)
            };

            tableNames = new List<string>()
            {
                "Accounts", "Admins", "Bookings", "CCDetails", "Guests", "Hotels", "Payments", "RoomCharge", "Rooms"
            };

            tableNamesLC = tableNames.ConvertAll(low => low.ToLowerInvariant());

            //for(int i=0;i<tableNames.Count+1;i++)
            //{
            //    tableNamesLC[i] = new Collection<>();
            //} 


            //(Account), (Admin), (Booking), (CC), (Guest), (Hotel), (Payment), (Room), (RoomCharge)

            

            accounts = new Collection<Account>();
            admins = new Collection<Admin>();
            bookings = new Collection<Booking>();
            ccs = new Collection<CC>();
            guests = new Collection<Guest>();
            hotels = new Collection<Hotel>();
            payments = new Collection<Payment>();
            rooms = new Collection<Room>();
            roomcharges = new Collection<RoomCharge>();

            //for (int i=1; i<10; i++ )
            //{
                string s1 = "sqlLocal" + Convert.ToString(2);
                string s2 = "table" + Convert.ToString(2);
                FillDataSet(sqlLocal2, table2);
                Add2Collection(table2);
            //}

        }

        #region Properties

        public List<Type> AllTypes
        {
            get
            {
                return types;
            }
        }
        public List<String> AllTableNames
        {
            get
            {
                return tableNames;
            }
        }
        public List<String> AllTableNamesLC
        {
            get
            {
                return tableNamesLC;
            }
        }

        public Collection<Account> AllAccounts
        {
            get
            {
                return accounts;
            }
        }

        public Collection<Admin> AllAdmins
        {
            get
            {
                return admins;
            }
        }

        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }

        public Collection<CC> AllCCs
        {
            get
            {
                return ccs;
            }
        }

        public Collection<Guest> AllGuests
        {
            get
            {
                return guests;
            }
        }

        public Collection<Hotel> AllHotels
        {
            get
            {
                return hotels;
            }
        }

        public Collection<Payment> AllPayments
        {
            get
            {
                return payments;
            }
        }

        public Collection<RoomCharge> AllRoomCharges
        {
            get
            {
                return roomcharges;
            }
        }

        public Collection<Room> AllRooms
        {
            get
            {
                return rooms;
            }
        }

        #endregion

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        #region Database Operations CRUD --- Add the object's values to the database

        #region DataSetChange
        /*public void DataSetChange(Account obj, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            //setting the dataTable string property for which table to use
            #region DBOperation
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, obj, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    FillRow(aRow, obj, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    aRow.Delete();
                    break;
            }
            #endregion
        }
        public void DataSetChange(Admin obj, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            //setting the dataTable string property for which table to use
            #region DBOperation
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, obj, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    FillRow(aRow, obj, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    aRow.Delete();
                    break;
            }
            #endregion
        }
        public void DataSetChange(Booking obj, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            //setting the dataTable string property for which table to use
            #region DBOperation
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, obj, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    FillRow(aRow, obj, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    aRow.Delete();
                    break;
            }
            #endregion
        }
        public void DataSetChange(CC obj, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            //setting the dataTable string property for which table to use
            #region DBOperation
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, obj, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    FillRow(aRow, obj, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    aRow.Delete();
                    break;
            }
            #endregion
        }
        public void DataSetChange(Guest obj, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            //setting the dataTable string property for which table to use
            #region DBOperation
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, obj, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    FillRow(aRow, obj, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    aRow.Delete();
                    break;
            }
            #endregion
        }
        public void DataSetChange(Hotel obj, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            //setting the dataTable string property for which table to use
            #region DBOperation
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, obj, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    FillRow(aRow, obj, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    aRow.Delete();
                    break;
            }
            #endregion
        }
        public void DataSetChange(Payment obj, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            //setting the dataTable string property for which table to use
            #region DBOperation
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, obj, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    FillRow(aRow, obj, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    aRow.Delete();
                    break;
            }
            #endregion
        }
        public void DataSetChange(RoomCharge obj, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            //setting the dataTable string property for which table to use
            #region DBOperation
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, obj, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    FillRow(aRow, obj, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    aRow.Delete();
                    break;
            }
            #endregion
        }
        public void DataSetChange(Room obj, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;

            //setting the dataTable string property for which table to use
            #region DBOperation
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, obj, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    FillRow(aRow, obj, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(obj, dataTable)];
                    aRow.Delete();
                    break;
            }
            #endregion
        } */
        #endregion

        #region Utility Methods
        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;

            /*switch (table)
            {
                case "table1":
                    Account anAccount;
                    foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
                    {
                        myRow = myRow_loopVariable;
                        if (!(myRow.RowState == DataRowState.Deleted))
                        {
                            anAccount = new Account();
                            anAccount.AccountID = Convert.ToInt32(myRow[""]);
                            anAccount.GuestID = Convert.ToInt32(myRow[""]);
                            anAccount.Balance = Convert.ToInt32(myRow[""]);
                        }
                    }
                    break;
                case "table2":
                    Admin anAdmin;
                    foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
                    {
                        myRow = myRow_loopVariable;
                        if (!(myRow.RowState == DataRowState.Deleted))
                        {
                            anAdmin = new Admin();
                            anAdmin.Username = Convert.ToString(myRow["Username"]).TrimEnd();
                            anAdmin.Password = Convert.ToString(myRow["Password"]).TrimEnd();




                        }
                    }
                    break;
                case "table3":
                    Booking aBooking;
                    //READ from the table  
                    foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
                    {
                        myRow = myRow_loopVariable;
                        if (!(myRow.RowState == DataRowState.Deleted))
                        {
                            aBooking = new Booking();
                            aBooking.ReservationNumber = Convert.ToInt32(myRow["ReservationNumber"]);
                            aBooking.GuestID = Convert.ToInt32(myRow["GuestID"]);
                            aBooking.NoOfRooms = Convert.ToInt32(myRow["NoOfRooms"]);
                            aBooking.NoOfPeople = Convert.ToInt32(myRow["NoOfPeople"]);
                            aBooking.StartDate = Convert.ToDateTime(myRow["StartDate"]);
                            aBooking.EndDate = Convert.ToDateTime(myRow["EndDate"]);
                            aBooking.SentConfirmation = Convert.ToBoolean(myRow["SentConfirmation"]);
                            aBooking.RecievedDeposit = Convert.ToBoolean(myRow["RecievedDeposit"]);
                            aBooking.IsCancelled = Convert.ToBoolean(myRow["IsCancelled"]);

                            bookings.Add(aBooking);
                        }
                    }
                    break;
                case "table4":

                    break;
            } */

            Admin anAdmin;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    anAdmin = new Admin();
                    anAdmin.Username = Convert.ToString(myRow["Username"]).TrimEnd();
                    anAdmin.Password = Convert.ToString(myRow["Password"]).TrimEnd();

                    admins.Add(anAdmin);


                }
            }



            


            
        }

        #region FillRow
        private void FillRow(DataRow aRow, Account anAccount, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["AccountID"] = anAccount.AccountID;
                aRow["GuestID"] = anAccount.GuestID;
                
                //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["Balance"] = anAccount.Balance;
            
        }
        private void FillRow(DataRow aRow, Admin anAdmin, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["Username"] = anAdmin.Username;
               
                //NOTE square brackets to indicate index of collections of fields in row.
            }

            aRow["Password"] = anAdmin.Password;

        }
        private void FillRow(DataRow aRow, Booking aBooking, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["ReservationNumber"] = aBooking.ReservationNumber;
                aRow["GuestID"] = aBooking.GuestID;
                //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["NoOfRooms"] = aBooking.NoOfRooms;
            aRow["NoOfPeople"] = aBooking.NoOfPeople;
            aRow["StartDate"] = aBooking.StartDate;
            aRow["EndDate"] = aBooking.EndDate;
            aRow["SentConfirmation"] = aBooking.SentConfirmation;
            aRow["RecievedDeposit"] = aBooking.RecievedDeposit;
            aRow["IsCancelled"] = aBooking.IsCancelled;


        }
        private void FillRow(DataRow aRow, CC aCC, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["CCID"] = aCC.CCID;
                //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["Name"] = aCC.Name;
            aRow["CCNo"] = aCC.CCNo;
            aRow["CVV"] = aCC.CVV;
            aRow["ExpiryDate"] = aCC.ExpiryDate;
        }
        private void FillRow(DataRow aRow, Guest aGuest, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["GuestID"] = aGuest.GuestID;

                //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["Name"] = aGuest.Name;
            aRow["Surname"] = aGuest.Surname;
            aRow["PhoneNumber"] = aGuest.PhoneNumber;
            aRow["Address"] = aGuest.Address;
            aRow["Email"] = aGuest.Email;
            aRow["Status"] = aGuest.Status;


        }
        private void FillRow(DataRow aRow, Hotel aHotel, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["HotelID"] = aHotel.HotelID;
                //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["HotelName"] = aHotel.HotelName;

        }
        private void FillRow(DataRow aRow, Payment aPayment, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["InvoiceNumber"] = aPayment.InvoiceNumber;
                aRow["CCID"] = aPayment.CCID;
                aRow["GuestID"] = aPayment.GuestID;
                aRow["AccountID"] = aPayment.AccountID;
                aRow["ReservationNumber"] = aPayment.ReservationNumber;

                //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["Amount"] = aPayment.Amount;


        }
        private void FillRow(DataRow aRow, RoomCharge aRoomCharge, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["RoomChargeID"] = aRoomCharge.RoomChargeID;
                //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["StartDate"] = aRoomCharge.StartDate;
            aRow["EndDate"] = aRoomCharge.EndDate;
            aRow["Price"] = aRoomCharge.Price;

        }
        private void FillRow(DataRow aRow, Room aRoom, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                aRow["RoomID"] = aRoom.RoomID;
                aRow["HotelID"] = aRoom.HotelID;
                //NOTE square brackets to indicate index of collections of fields in row.
            }

            aRow["RoomNo"] = aRoom.RoomNo;

        }

        #endregion

        #region FindRow
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
        private int FindRow(Account anAccount, string table)
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
                    if (anAccount.AccountID == Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["AccountID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }
        private int FindRow(Admin anAdmin, string table)
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
                    if (anAdmin.Username == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["Username"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }

        #endregion

        #endregion

        #endregion


        /*
        #region Many-To-Many CRUD Functionality

        public void InsertWithoutData(Booking bking, Payment pmt) 
        {
        using (manyto conn = new ManyToManyEntities())
	    {
		//add instances to context
		conn.Product.Add(prod);
		conn.Supplier.Add(sup);

		// add instance to navigation property
		prod.Supplier.Add(sup);

		//call SaveChanges from context to confirm inserts
		conn.SaveChanges();
	    }
        }	

        #endregion
        */

        
        #region Build Parameters, Create Commands & Update database


        private void Build_INSERT_Parameters(Booking aBooking)
        {
            //Create Parameters to communicate with SQL INSERT
            //https://www.google.co.za/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=size+in+bytes+of+Int+in+SQL
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@ReservationNumber", SqlDbType.NVarChar, 15, "ReservationNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 15, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@NoOfRooms", SqlDbType.Int, 15, "NoOfRooms");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@StartDate", SqlDbType.DateTime, 15, "StartDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@EndDate", SqlDbType.DateTime, 15, "EndDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@SentConfirmation", SqlDbType.Bit, 15, "SentConfirmation");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@ReceivedDeposit", SqlDbType.Bit, 15, "ReceivedDeposit");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@isCancelled", SqlDbType.Bit, 15, "isCancelled");
            daMain.InsertCommand.Parameters.Add(param);

            
            //***https://msdn.microsoft.com/en-za/library/ms179882.aspx
        }

        private void Build_UPDATE_Parameters(Booking aBooking)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@NoOfRooms", SqlDbType.NVarChar, 50, "NoOfRooms");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 15, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@StartDate", SqlDbType.DateTime, 15, "StartDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@EndDate", SqlDbType.DateTime, 15, "EndDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
           
            param = new SqlParameter("@SentConfirmation", SqlDbType.Money, 8, "SentConfirmation");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@ReceivedDeposit", SqlDbType.Money, 8, "ReceivedDeposit");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@IsCancelled", SqlDbType.Money, 8, "IsCancelled");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //testing the ID of record that needs to change with the original ID of the record
            param = new SqlParameter("@Original_ReservationNumber", SqlDbType.NVarChar, 15, "ReservationNumber");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters()
        {
            //--Create Parameters to communicate with SQL DELETE
            SqlParameter param;
            param = new SqlParameter("@ReservationNumber", SqlDbType.NVarChar, 15, "ReservationNumber");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }
        private void Create_INSERT_Command(Booking aBooking)
        {

            daMain.InsertCommand = new SqlCommand("INSERT into Bookings (ReservationNumber, GuestID, NoOfRooms, NoOfPeople, StartDate, EndDate, SentConfirmation, ReceivedDeposit, IsCancelled) VALUES (@ReservationNumber, @GuestID, @NoOfRooms, @NoOfPeople, @StartDate, @EndDate, @SentConfirmation, @ReceivedDeposit, @IsCancelled)", cnMain);
            Build_INSERT_Parameters(aBooking);
        }

        private void Create_UPDATE_Command(Booking aBooking)
        {
            //Create the command that must be used to insert values into one of the three tables

            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET ReservationNumber =@ReservationNumber, GuestID =@GuestID, NoOfRooms =@NoOfRooms, NoOfPeople = @NoOfPeople, StartDate = @StartDate, EndDate = @EndDate, SentConfirmation = @SentConfirmation, ReceivedDeposit = @ReceivedDeposit, IsCancelled = @IsCancelled " + "WHERE ReservationNumber = @Original_ReservationNumber", cnMain);
            
            
            Build_UPDATE_Parameters(aBooking);
        }

        private string Create_DELETE_Command(Booking aBooking)
        {
            string errorString = null;
            //Create the command that must be used to delete values from the the appropriate table

            daMain.DeleteCommand = new SqlCommand("DELETE FROM Bookings WHERE ReservationNumber = @ReservationNumber", cnMain);
            
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

            success = UpdateDataSource(sqlLocal2, table2);

            return success;
        }

        /*public bool UpdateDataSource(Admin anAdmin)
        {
            bool success = true;
            Create_INSERT_Command(anAdmin);
            Create_UPDATE_Command(anAdmin);
            Create_DELETE_Command(anAdmin);

            success = UpdateDataSource(sqlLocal2, table2);

            return success;
        } */



        #endregion


    }
}
