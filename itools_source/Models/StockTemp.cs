using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class StockTemp
    {
        private int _iID;

        public int iID
        {
            get { return _iID; }
            set { _iID = value; }
        }

        private int? _iToolId;

        public int? iToolId
        {
            get { return _iToolId; }
            set { _iToolId = value; }
        }

        private string _strUserLogin;

        public string strUserLogin
        {
            get { return _strUserLogin; }
            set { _strUserLogin = value; }
        }

        private int _iQuantity;

        public int iQuantity
        {
            get { return _iQuantity; }
            set { _iQuantity = value; }
        }

        private DateTime? _dtCreateDate;

        public DateTime? dtCreateDate
        {
            get { return _dtCreateDate; }
            set { _dtCreateDate = value; }
        }

        private DateTime _dtUpdateDate;

        public DateTime dtUpdateDate
        {
            get { return _dtUpdateDate; }
            set { _dtUpdateDate = value; }
        }
    }
}
