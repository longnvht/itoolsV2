using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class PartOP
    {
        private int _iOPId;

        public int iOPId
        {
            get { return _iOPId; }
            set { _iOPId = value; }
        }

        private string _strOPNumber;

        public string strOPNumber
        {
            get { return _strOPNumber; }
            set { _strOPNumber = value; }
        }

        private int _iPartId;

        public int iPartId
        {
            get { return _iPartId; }
            set { _iPartId = value; }
        }

        private string _strOPType;

        public string strOPType
        {
            get { return _strOPType; }
            set { _strOPType = value; }
        }

        private string _strJobNumber;

        public string strJobNumber
        {
            get { return _strJobNumber; }
            set { _strJobNumber = value; }
        }

        private bool _bForOnlyJob;

        public bool bForOnlyJob
        {
            get { return _bForOnlyJob; }
            set { _bForOnlyJob = value; }
        }

        private string _StrDescription;

        public string StrDescription
        {
            get { return _StrDescription; }
            set { _StrDescription = value; }
        }

        private string _StrNote;

        public string StrNote
        {
            get { return _StrNote; }
            set { _StrNote = value; }
        }

        private double _DSetuptime;

        public double DSetuptime
        {
            get { return _DSetuptime; }
            set { _DSetuptime = value; }
        }

        private double _DProdTime;

        public double DProdTime
        {
            get { return _DProdTime; }
            set { _DProdTime = value; }
        }

        private bool _BComplete;

        public bool BComplete
        {
            get { return _BComplete; }
            set { _BComplete = value; }
        }

        private int _ICompleteUser;

        public int ICompleteUser
        {
            get { return _ICompleteUser; }
            set { _ICompleteUser = value; }
        }

        private int _IOPTypeId;

        public int IOPTypeId
        {
            get { return _IOPTypeId; }
            set { _IOPTypeId = value; }
        }

        private int _ICreator;

        public int ICreator
        {
            get { return _ICreator; }
            set { _ICreator = value; }
        }

        private DateTime _DtDate;

        public DateTime DtDate
        {
            get { return _DtDate; }
            set { _DtDate = value; }
        }
    }
}
