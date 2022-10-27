using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class Company
    {
        private int _ICompanyId;

        public int ICompanyId
        {
            get { return _ICompanyId; }
            set { _ICompanyId = value; }
        }

        private string _StrCompanyCode;

        public string StrCompanyCode
        {
            get { return _StrCompanyCode; }
            set { _StrCompanyCode = value; }
        }

        private string _StrCompanyName;

        public string StrCompanyName
        {
            get { return _StrCompanyName; }
            set { _StrCompanyName = value; }
        }

        private string _StrCompanyType;

        public string StrCompanyType
        {
            get { return _StrCompanyType; }
            set { _StrCompanyType = value; }
        }

        private string _StrAddress;

        public string StrAddress
        {
            get { return _StrAddress; }
            set { _StrAddress = value; }
        }

        private string _StrLocation;

        public string StrLocation
        {
            get { return _StrLocation; }
            set { _StrLocation = value; }
        }

        private DateTime _DtUpdateDate;

        public DateTime DtUpdateDate
        {
            get { return _DtUpdateDate; }
            set { _DtUpdateDate = value; }
        }
    }
}
