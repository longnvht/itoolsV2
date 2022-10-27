using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class Assessor
    {
        private int _IAssessorId;

        public int IAssessorId
        {
            get { return _IAssessorId; }
            set { _IAssessorId = value; }
        }

        private string _StrUserName;

        public string StrUserName
        {
            get { return _StrUserName; }
            set { _StrUserName = value; }
        }

        private string _StrFingerId;

        public string StrFingerId
        {
            get { return _StrFingerId; }
            set { _StrFingerId = value; }
        }

        private string _StrPassword;

        public string StrPassword
        {
            get { return _StrPassword; }
            set { _StrPassword = value; }
        }

        private string _StrFirstName;

        public string StrFirstName
        {
            get { return _StrFirstName; }
            set { _StrFirstName = value; }
        }

        private string _StrLastName;

        public string StrLastName
        {
            get { return _StrLastName; }
            set { _StrLastName = value; }
        }

        private string _StrEmailAddress;

        public string StrEmailAddress
        {
            get { return _StrEmailAddress; }
            set { _StrEmailAddress = value; }
        }

        private string _StrAddress;

        public string StrAddress
        {
            get { return _StrAddress; }
            set { _StrAddress = value; }
        }

        private string _StrPhone;

        public string StrPhone
        {
            get { return _StrPhone; }
            set { _StrPhone = value; }
        }

        private string _StrCompanyCode;

        public string StrCompanyCode
        {
            get { return _StrCompanyCode; }
            set { _StrCompanyCode = value; }
        }

        private string _StrMachineCode;

        public string StrMachineCode
        {
            get { return _StrMachineCode; }
            set { _StrMachineCode = value; }
        }

        private int _IsLocked;

        public int IsLocked
        {
            get { return _IsLocked; }
            set { _IsLocked = value; }
        }

        private int _IsActive;

        public int IsActive
        {
            get { return _IsActive; }
            set { _IsActive = value; }
        }

        private string _StrLastPassword;

        public string StrLastPassword
        {
            get { return _StrLastPassword; }
            set { _StrLastPassword = value; }
        }

        private byte _IsFirstTimeLogin;

        public byte IsFirstTimeLogin
        {
            get { return _IsFirstTimeLogin; }
            set { _IsFirstTimeLogin = value; }
        }

        private int _IFailTimes;

        public int IFailTimes
        {
            get { return _IFailTimes; }
            set { _IFailTimes = value; }
        }

        private DateTime _DtUpdateDate;

        public DateTime DtUpdateDate
        {
            get { return _DtUpdateDate; }
            set { _DtUpdateDate = value; }
        }
    }
}
