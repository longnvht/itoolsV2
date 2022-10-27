using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class Tool
    {
        private int _iToolId;

        public int iToolId
        {
            get { return _iToolId; }
            set { _iToolId = value; }
        }

        private string _strToolCode;

        public string strToolCode
        {
            get { return _strToolCode; }
            set { _strToolCode = value; }
        }

        private string _strCompanyCode;

        public string strCompanyCode
        {
            get { return _strCompanyCode; }
            set { _strCompanyCode = value; }
        }

        private string _strModel;

        public string strModel
        {
            get { return _strModel; }
            set { _strModel = value; }
        }

        private string _strBarCode;

        public string strBarCode
        {
            get { return _strBarCode; }
            set { _strBarCode = value; }
        }

        private string _strDescription;

        public string strDescription
        {
            get { return _strDescription; }
            set { _strDescription = value; }
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
