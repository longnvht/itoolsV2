using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class PartOP
    {
        private int _IOPId;

        public int IOPId
        {
            get { return _IOPId; }
            set { _IOPId = value; }
        }

        private string _StrOPNumber;

        public string StrOPNumber
        {
            get { return _StrOPNumber; }
            set { _StrOPNumber = value; }
        }

        private int _IPartId;

        public int IPartId
        {
            get { return _IPartId; }
            set { _IPartId = value; }
        }

        private string _StrOPType;

        public string StrOPType
        {
            get { return _StrOPType; }
            set { _StrOPType = value; }
        }

        private string _StrJobNumber;

        public string StrJobNumber
        {
            get { return _StrJobNumber; }
            set { _StrJobNumber = value; }
        }

        private bool _BForOnlyJob;

        public bool BForOnlyJob
        {
            get { return _BForOnlyJob; }
            set { _BForOnlyJob = value; }
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
