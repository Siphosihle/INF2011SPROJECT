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
            Add2Collection(table1);

        }
    }
}
