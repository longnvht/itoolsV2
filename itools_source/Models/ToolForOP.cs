using System;

namespace itools_source.Models
{
    public class ToolForOP
    {
        private int _iToolForOp;

        public int iToolForOp
        {
            get { return _iToolForOp; }
            set { _iToolForOp = value; }
        }

        private int _iOPId;

        public int iOPId
        {
            get { return _iOPId; }
            set { _iOPId = value; }
        }

        private int _iToolId;

        public int iToolId
        {
            get { return _iToolId; }
            set { _iToolId = value; }
        }

        private DateTime _dtCreateDate;

        public DateTime dtCreateDate
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

        private bool _isActive;

        public bool isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
    }
}
