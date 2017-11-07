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
    public class RoomChargeDB : DB
    {

        private string table1 = "RoomCharge";
        private string sqlLocal1 = "SELECT * FROM RoomCharge";

        private Collection<RoomCharge> roomcharges;



        public RoomChargeDB() : base()
        {
            roomcharges = new Collection<RoomCharge>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
        }

        #region Properties

        public Collection<RoomCharge> AllRoomCharges
        {
            get { return roomcharges; }
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

            RoomCharge aRoomCharge;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aRoomCharge = new RoomCharge();

                    aRoomCharge.RoomChargeID = Convert.ToInt32(myRow["RoomChargeID"]);
                    aRoomCharge.StartDate = Convert.ToDateTime(myRow["StartDate"]);
                    aRoomCharge.EndDate = Convert.ToDateTime(myRow["EndDate"]);
                    aRoomCharge.RoomChargeID = Convert.ToInt32(myRow["RoomChargeID"]);

                    roomcharges.Add(aRoomCharge);


                }
            }

        }




    }
}
