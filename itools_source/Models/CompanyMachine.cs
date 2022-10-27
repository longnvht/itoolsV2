using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class CompanyMachine
    {
        private int _iCompanyMachineId;

        public int iCompanyMachineId
        {
            get { return _iCompanyMachineId; }
            set { _iCompanyMachineId = value; }
        }

        private string _strMachineCode;

        public string strMachineCode
        {
            get { return _strMachineCode; }
            set { _strMachineCode = value; }
        }

        private string _strCompanyCode;

        public string strCompanyCode
        {
            get { return _strCompanyCode; }
            set { _strCompanyCode = value; }
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
