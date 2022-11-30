using System;

namespace itools_source.Models
{
    public class permissiondetail
    {
        private string _strPermissionId;

        public string strPermissionId
        {
            get { return _strPermissionId; }
            set { _strPermissionId = value; }
        }

        private string _strRoleId;

        public string strRoleId
        {
            get { return _strRoleId; }
            set { _strRoleId = value; }
        }

        private DateTime _dtCreateDate;

        public DateTime dtCreateDate
        {
            get { return _dtCreateDate; }
            set { _dtCreateDate = value; }
        }

        private DateTime _dtUpdateDate;

        public DateTime dtUpdateDate
        {
            get { return _dtUpdateDate; }
            set { _dtUpdateDate = value; }
        }
    }
}
