using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeScreen.Business_Layer
{
    public class CC
    {

        //businesslayerformat
        //variables
        //properties
        //constructors

        private int cCID;
        private string name;
        private string cCNo;
        private string cVV;
        private DateTime expiryDate;

        #region Properties

        public int CCID
            {
                get { return cCID; }
                set { cCID = value; }
            }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string CCNo
        {
            get { return cCNo; }
            set { cCNo = value; }
        }

        public string CVV
        {
            get { return cVV; }
            set { cVV = value; }
        }

        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }


        #endregion

        public CC()
        {

        }

    }
}
