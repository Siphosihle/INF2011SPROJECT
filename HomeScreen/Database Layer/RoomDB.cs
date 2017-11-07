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
    public class RoomDB: DB
    {

        private string table1 = "Rooms";
        private string sqlLocal1 = "SELECT * FROM Rooms";

        private Collection<Room> rooms;



        public RoomDB(): base()
        {
            rooms = new Collection<Room>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
        }

        #region Properties

        public Collection<Room> AllRooms
        {
            get { return rooms; }
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

            Room aRoom;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {

                    aRoom = new Room();
                    aRoom.RoomID = Convert.ToInt32(myRow["AccountID"]);
                    aRoom.HotelID = Convert.ToInt32(myRow["AccountID"]);
                    aRoom.RoomNo = Convert.ToInt32(myRow["AccountID"]);

                    rooms.Add(aRoom);


                }
            }

        }




    }
}
