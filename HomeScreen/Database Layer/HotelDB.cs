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
    public class HotelDB: DB
    {

        private string table1 = "Hotels";
        private string sqlLocal1 = "SELECT * FROM Hotels";

        private Collection<Hotel> hotels;

        public HotelDB(): base()
        {
            hotels = new Collection<Hotel>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
        }

        #region Properties

        public Collection<Hotel> AllHotels
        {
            get { return hotels; }
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
            Hotel aHotel;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    aHotel = new Hotel();

                    aHotel.HotelID = Convert.ToInt32(myRow["HotelID"]);
                    aHotel.HotelName = Convert.ToString(myRow["HotelName"]);

                    hotels.Add(aHotel);


                }
            }

        }




    }
}
