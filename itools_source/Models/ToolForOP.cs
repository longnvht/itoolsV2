using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class ToolForOP
    {
        private int _IToolForOp;

        public int IToolForOp
        {
            get { return _IToolForOp; }
            set { _IToolForOp = value; }
        }

        private int _IOPId;

        public int IOPId
        {
            get { return _IOPId; }
            set { _IOPId = value; }
        }

        private int _IToolId;

        public int IToolId
        {
            get { return _IToolId; }
            set { _IToolId = value; }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
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

        private bool _IsActive;

        public bool IsActive
        {
            get { return _IsActive; }
            set { _IsActive = value; }
        }
    }
}
