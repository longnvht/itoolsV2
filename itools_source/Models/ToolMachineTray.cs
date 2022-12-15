using System;

namespace itools_source.Models
{
    public class ToolMachineTray
    {
        private int? _iToolsMachineTrayId;

        public int? iToolsMachineTrayId
        {
            get { return _iToolsMachineTrayId; }
            set { _iToolsMachineTrayId = value; }
        }

        private int? _iMachineId;

        public int? iMachineId
        {
            get { return _iMachineId; }
            set { _iMachineId = value; }
        }

        private int? _iToolId;

        public int? iToolId
        {
            get { return _iToolId; }
            set { _iToolId = value; }
        }

        private string _strTrayIndex;

        public string strTrayIndex
        {
            get { return _strTrayIndex; }
            set { _strTrayIndex = value; }
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

        private byte _isActive;

        public byte isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
    }
}
