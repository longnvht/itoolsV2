namespace itools_source.Models
{
    public class permission
    {
        private string _strPermissionId;

        public string strPermissionId
        {
            get { return _strPermissionId; }
            set { _strPermissionId = value; }
        }

        private string _strPermissionName;

        public string strPermissionName
        {
            get { return _strPermissionName; }
            set { _strPermissionName = value; }
        }

        private string _strDescription;

        public string strDescription
        {
            get { return _strDescription; }
            set { _strDescription = value; }
        }
    }
}
