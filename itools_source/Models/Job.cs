using System;

namespace itools_source.Models
{
    public class Job
    {
        private string _strJobNumber;

        public string strJobNumber
        {
            get { return _strJobNumber; }
            set { _strJobNumber = value; }
        }

        private int _iRunQty;

        public int iRunQty
        {
            get { return _iRunQty; }
            set { _iRunQty = value; }
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
