using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class RoleAssessor
    {
        private int _IRoleAssessor;

        public int IRoleAssessor
        {
            get { return _IRoleAssessor; }
            set { _IRoleAssessor = value; }
        }

        private int _IRoleId;

        public int IRoleId
        {
            get { return _IRoleId; }
            set { _IRoleId = value; }
        }

        private int _IAssessorId;

        public int IAssessorId
        {
            get { return _IAssessorId; }
            set { _IAssessorId = value; }
        }

        private DateTime _DtCreateDate;

        public DateTime DtCreateDate
        {
            get { return _DtCreateDate; }
            set { _DtCreateDate = value; }
        }

        private byte _IsActive;

        public byte IsActive
        {
            get { return _IsActive; }
            set { _IsActive = value; }
        }
    }
}
