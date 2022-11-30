namespace itools_source.Models
{
    public class control
    {
        private string _strControlId;

        public string strControlId
        {
            get { return _strControlId; }
            set { _strControlId = value; }
        }

        private string _strFormId;

        public string strFormId
        {
            get { return _strFormId; }
            set { _strFormId = value; }
        }

        private string _strControlName;

        public string strControlName
        {
            get { return _strControlName; }
            set { _strControlName = value; }
        }

        private string _strDescription;

        public string strDescription
        {
            get { return _strDescription; }
            set { _strDescription = value; }
        }
    }
}
