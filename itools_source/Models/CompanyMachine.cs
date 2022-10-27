using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class CompanyMachine
    {
        private int _ICompanyMachineId;

        public int ICompanyMachineId
        {
            get { return _ICompanyMachineId; }
            set { _ICompanyMachineId = value; }
        }

        private string _StrMachineCode;

        public string StrMachineCode
        {
            get { return _StrMachineCode; }
            set { _StrMachineCode = value; }
        }

        private string _StrCompanyCode;

        public string StrCompanyCode
        {
            get { return _StrCompanyCode; }
            set { _StrCompanyCode = value; }
        }

        private DateTime _DtCreateDate;

        public DateTime DtCreateDate
        {
            get { return _DtCreateDate; }
            set { _DtCreateDate = value; }
        }

        private DateTime _DtUpdateDate;

        public DateTime DtUpdateDate
        {
            get { return _DtUpdateDate; }
            set { _DtUpdateDate = value; }
        }

        private byte _IsActive;

        public byte IsActive
        {
            get { return _IsActive; }
            set { _IsActive = value; }
        }
    }
}
