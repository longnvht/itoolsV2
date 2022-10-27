﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class ToolsMachineTray
    {
        private int _iToolsMachineTrayId;

        public int iToolsMachineTrayId
        {
            get { return _iToolsMachineTrayId; }
            set { _iToolsMachineTrayId = value; }
        }

        private string _strMachineCode;

        public string strMachineCode
        {
            get { return _strMachineCode; }
            set { _strMachineCode = value; }
        }

        private string _strToolCode;

        public string strToolCode
        {
            get { return _strToolCode; }
            set { _strToolCode = value; }
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
