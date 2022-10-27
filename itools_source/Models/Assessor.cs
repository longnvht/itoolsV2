using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class Assessor
    {
        private int _iAssessorId;

        public int iAssessorId
        {
            get { return _iAssessorId; }
            set { _iAssessorId = value; }
        }

        private string _strUserName;

        public string strUserName
        {
            get { return _strUserName; }
            set { _strUserName = value; }
        }

        private string _strFingerId;

        public string strFingerId
        {
            get { return _strFingerId; }
            set { _strFingerId = value; }
        }

        private string _strPassword;

        public string strPassword
        {
            get { return _strPassword; }
            set { _strPassword = value; }
        }

        private string _strFirstName;

        public string strFirstName
        {
            get { return _strFirstName; }
            set { _strFirstName = value; }
        }

        private string _strLastName;

        public string strLastName
        {
            get { return _strLastName; }
            set { _strLastName = value; }
        }

        private string _strEmailAddress;

        public string strEmailAddress
        {
            get { return _strEmailAddress; }
            set { _strEmailAddress = value; }
        }

        private string _strAddress;

        public string strAddress
        {
            get { return _strAddress; }
            set { _strAddress = value; }
        }

        private string _strPhone;

        public string strPhone
        {
            get { return _strPhone; }
            set { _strPhone = value; }
        }

        private string _strCompanyCode;

        public string strCompanyCode
        {
            get { return _strCompanyCode; }
            set { _strCompanyCode = value; }
        }

        private string _strMachineCode;

        public string strMachineCode
        {
            get { return _strMachineCode; }
            set { _strMachineCode = value; }
        }

        private int _isLocked;

        public int isLocked
        {
            get { return _isLocked; }
            set { _isLocked = value; }
        }

        private int _isActive;

        public int isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        private string _strLastPassword;

        public string strLastPassword
        {
            get { return _strLastPassword; }
            set { _strLastPassword = value; }
        }

        private byte _isFirstTimeLogin;

        public byte isFirstTimeLogin
        {
            get { return _isFirstTimeLogin; }
            set { _isFirstTimeLogin = value; }
        }

        private int _iFailTimes;

        public int iFailTimes
        {
            get { return _iFailTimes; }
            set { _iFailTimes = value; }
        }

        private DateTime _dtUpdateDate;

        public DateTime dtUpdateDate
        {
            get { return _dtUpdateDate; }
            set { _dtUpdateDate = value; }
        }
    }
}
