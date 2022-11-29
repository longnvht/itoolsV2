using System;

namespace itools_source.Models
{
    public class RoleAssessor
    {
        private int _iRoleAssessor;
        public int iRoleAssessor
        {
            get { return _iRoleAssessor; }
            set { _iRoleAssessor = value; }
        }

        private int _iRoleId;
        public int iRoleId
        {
            get { return _iRoleId; }
            set { _iRoleId = value; }
        }

        private int _iAssessorId;
        public int iAssessorId
        {
            get { return _iAssessorId; }
            set { _iAssessorId = value; }
        }

        private DateTime _dtCreateDate;
        public DateTime dtCreateDate
        {
            get { return _dtCreateDate; }
            set { _dtCreateDate = value; }
        }

        private byte _isActive;
        public byte isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
    }
}
