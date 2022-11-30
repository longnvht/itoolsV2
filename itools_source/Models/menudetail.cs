using System;

namespace itools_source.Models
{
    public class menudetail
    {
        private string _strMenuId;

        public string strMenuId
        {
            get { return _strMenuId; }
            set { _strMenuId = value; }
        }

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
