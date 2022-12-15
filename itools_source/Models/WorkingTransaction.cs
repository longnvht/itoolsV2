using System;

namespace itools_source.Models
{
    public class WorkingTransaction
    {
        private int _iWorkingTransactionId;

        public int iWorkingTransactionId
        {
            get { return _iWorkingTransactionId; }
            set { _iWorkingTransactionId = value; }
        }

        private DateTime _dtTransactionDate;

        public DateTime dtTransactionDate
        {
            get { return _dtTransactionDate; }
            set { _dtTransactionDate = value; }
        }

        private int? _iMachineId;

        public int? iMachineId
        {
            get { return _iMachineId; }
            set { _iMachineId = value; }
        }

        private int? _iCompanyId;

        public int? iCompanyId
        {
            get { return _iCompanyId; }
            set { _iCompanyId = value; }
        }

        private string _strUserLogin;

        public string strUserLogin
        {
            get { return _strUserLogin; }
            set { _strUserLogin = value; }
        }

        private string _strJobNumber;

        public string strJobNumber
        {
            get { return _strJobNumber; }
            set { _strJobNumber = value; }
        }

        private string _strOPNumber;

        public string strOPNumber
        {
            get { return _strOPNumber; }
            set { _strOPNumber = value; }
        }


        private int? _iTrayId;

        public int? iTrayId
        {
            get { return _iTrayId; }
            set { _iTrayId = value; }
        }

        private int _iQuantity;

        public int iQuantity
        {
            get { return _iQuantity; }
            set { _iQuantity = value; }
        }

        private string _strTransactionStatus;

        public string strTransactionStatus
        {
            get { return _strTransactionStatus; }
            set { _strTransactionStatus = value; }
        }

        private string _strTransactiomType;

        public string strTransactiomType
        {
            get { return _strTransactiomType; }
            set { _strTransactiomType = value; }
        }
    }
}
