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

        private string _strAssessorId;

        public string strAssessorId
        {
            get { return _strAssessorId; }
            set { _strAssessorId = value; }
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
