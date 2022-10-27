using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string StrCompanyCode
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

        private string _strWOCode;

        public string strWOCode
        {
            get { return _strWOCode; }
            set { _strWOCode = value; }
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

        private DateTime _dtUpdateDate;

        public DateTime dtUpdateDate
        {
            get { return _dtUpdateDate; }
            set { _dtUpdateDate = value; }
        }

        private string _strTransactionStatus;

        public string StrTransactionStatus
        {
            get { return _strTransactionStatus; }
            set { _strTransactionStatus = value; }
        }

        private string _strRespondMessge;

        public string strRespondMessge
        {
            get { return _strRespondMessge; }
            set { _strRespondMessge = value; }
        }

        private string _strTransactiomType;

        public string strTransactiomType
        {
            get { return _strTransactiomType; }
            set { _strTransactiomType = value; }
        }
    }
}
