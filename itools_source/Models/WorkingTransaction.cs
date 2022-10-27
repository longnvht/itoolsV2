using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class WorkingTransaction
    {
        private int _IWorkingTransactionId;

        public int IWorkingTransactionId
        {
            get { return _IWorkingTransactionId; }
            set { _IWorkingTransactionId = value; }
        }

        private DateTime _DtTransactionDate;

        public DateTime DtTransactionDate
        {
            get { return _DtTransactionDate; }
            set { _DtTransactionDate = value; }
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

        private string _StrAssessorId;

        public string StrAssessorId
        {
            get { return _StrAssessorId; }
            set { _StrAssessorId = value; }
        }

        private string _StrWOCode;

        public string StrWOCode
        {
            get { return _StrWOCode; }
            set { _StrWOCode = value; }
        }

        private string _StrToolCode;

        public string StrToolCode
        {
            get { return _StrToolCode; }
            set { _StrToolCode = value; }
        }

        private string _StrTrayIndex;

        public string StrTrayIndex
        {
            get { return _StrTrayIndex; }
            set { _StrTrayIndex = value; }
        }

        private int _IQuantity;

        public int IQuantity
        {
            get { return _IQuantity; }
            set { _IQuantity = value; }
        }

        private DateTime _DtUpdateDate;

        public DateTime DtUpdateDate
        {
            get { return _DtUpdateDate; }
            set { _DtUpdateDate = value; }
        }

        private string _StrTransactionStatus;

        public string StrTransactionStatus
        {
            get { return _StrTransactionStatus; }
            set { _StrTransactionStatus = value; }
        }

        private string _StrRespondMessge;

        public string StrRespondMessge
        {
            get { return _StrRespondMessge; }
            set { _StrRespondMessge = value; }
        }

        private string _StrTransactiomType;

        public string StrTransactiomType
        {
            get { return _StrTransactiomType; }
            set { _StrTransactiomType = value; }
        }
    }
}
