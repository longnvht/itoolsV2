namespace itools_source.Models
{
    public class menu
    {
        private string _strMenuId;

        public string strMenuId
        {
            get { return _strMenuId; }
            set { _strMenuId = value; }
        }

        private string _strMenuName;

        public string strMenuName
        {
            get { return _strMenuName; }
            set { _strMenuName = value; }
        }

        private string _strDescription;

        public string strDescription
        {
            get { return _strDescription; }
            set { _strDescription = value; }
        }
    }
}
