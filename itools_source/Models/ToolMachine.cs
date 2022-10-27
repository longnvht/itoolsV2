using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class ToolMachine
    {
        private int _iToolsMachineId;

        public int iToolsMachineId
        {
            get { return _iToolsMachineId; }
            set { _iToolsMachineId = value; }
        }

        private string _strToolCode;

        public string strToolCode
        {
            get { return _strToolCode; }
            set { _strToolCode = value; }
        }

        private string _strMachineCode;

        public string strMachineCode
        {
            get { return _strMachineCode; }
            set { _strMachineCode = value; }
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

        private byte _isActive;

        public byte isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
    }
}
