using System;

namespace itools_source.Models
{
    public class Roles
    {
        private int _iRoleId;
        public int iRoleId
        {
            get { return _iRoleId; }
            set { _iRoleId = value; }
        }

        private string _strRoleName;
        public string strRoleName
        {
            get { return _strRoleName; }
            set { _strRoleName = value; }
        }

        private int _iRoleType;
        public int iRoleType
        {
            get { return _iRoleType; }
            set { _iRoleType = value; }
        }

        private int _isRole;
        public int isRole
        {
            get { return _isRole; }
            set { _isRole = value; }
        }

        private DateTime _dtUpdateDate;
        public DateTime dtUpdateDate
        {
            get { return _dtUpdateDate; }
            set { _dtUpdateDate = value; }
        }
    }
}
