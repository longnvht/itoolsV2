using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class Job
    {
        private string _StrJobNumber;

        public string StrJobNumber
        {
            get { return _StrJobNumber; }
            set { _StrJobNumber = value; }
        }

        private int _IRunQty;

        public int IRunQty
        {
            get { return _IRunQty; }
            set { _IRunQty = value; }
        }

        private DateTime _DtShipBy;

        public DateTime DtShipBy
        {
            get { return _DtShipBy; }
            set { _DtShipBy = value; }
        }

        private int _IPartId;

        public int IPartId
        {
            get { return _IPartId; }
            set { _IPartId = value; }
        }

        private int _IPOLineId;

        public int IPOLineId
        {
            get { return _IPOLineId; }
            set { _IPOLineId = value; }
        }
    }
}
