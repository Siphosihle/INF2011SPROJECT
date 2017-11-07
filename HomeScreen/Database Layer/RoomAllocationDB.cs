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
    public class RoomAllocationDB: DB
    {

        private string table1 = "RoomAllocation";
        private string sqlLocal1 = "SELECT * FROM RoomAllocation";

        private Collection<RoomAllocation> roomAllocations;

        public RoomAllocationDB(): base()
        {
            roomAllocations = new Collection<RoomAllocation>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
        }

        #region Properties

        public Collection<RoomAllocation> AllRoomAllocations
        {
            get { return roomAllocations; }
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
            RoomAllocation aRoomAllocation;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aRoomAllocation = new RoomAllocation();

                    aRoomAllocation.ReservationNumber = Convert.ToInt32(myRow["BookingID"]);
                    aRoomAllocation.RoomID = Convert.ToInt32(myRow["RoomID"]);

                    roomAllocations.Add(aRoomAllocation);


                }
            }

        }




    }
}
