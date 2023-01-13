using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.DTOs
{
    public class ReportStock
    {
        private string _strTrayIndex;

        public string strTrayIndex
        {
            get { return _strTrayIndex; }
            set { _strTrayIndex = value; }
        }

        private int? _iToolId;

        public int? iToolId
        {
            get { return _iToolId; }
            set { _iToolId = value; }
        }

        private int? _iQuantity;

        public int? iQuantity
        {
            get { return _iQuantity; }
            set { _iQuantity = value; }
        }

        private DateTime _dtUpdateDate;

        public DateTime dtUpdateDate
        {
            get { return _dtUpdateDate; }
            set { _dtUpdateDate = value; }
        }
    }
}
