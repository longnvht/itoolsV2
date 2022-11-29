using System;

namespace itools_source.Models
{
    public class Company
    {
        private int _iCompanyId;

        public int iCompanyId
        {
            get { return _iCompanyId; }
            set { _iCompanyId = value; }
        }

        private string _strCompanyCode;

        public string strCompanyCode
        {
            get { return _strCompanyCode; }
            set { _strCompanyCode = value; }
        }

        private string _strCompanyName;

        public string strCompanyName
        {
            get { return _strCompanyName; }
            set { _strCompanyName = value; }
        }

        private string _strCompanyType;

        public string strCompanyType
        {
            get { return _strCompanyType; }
            set { _strCompanyType = value; }
        }

        private string _strAddress;

        public string strAddress
        {
            get { return _strAddress; }
            set { _strAddress = value; }
        }

        private string _strLocation;

        public string strLocation
        {
            get { return _strLocation; }
            set { _strLocation = value; }
        }

        private DateTime _dtUpdateDate;

        public DateTime dtUpdateDate
        {
            get { return _dtUpdateDate; }
            set { _dtUpdateDate = value; }
        }
    }
}
