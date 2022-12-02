namespace itools_source.Models
{
    public class UserType
    {
        private int _iTypeID;

        public int iTypeID
        {
            get { return _iTypeID; }
            set { _iTypeID = value; }
        }

        private string _strTypeName;

        public string strTypeName
        {
            get { return _strTypeName; }
            set { _strTypeName = value; }
        }

        private string _strTypeDescription;

        public string strTypeDescription
        {
            get { return _strTypeDescription; }
            set { _strTypeDescription = value; }
        }

        private byte _bEnterValue;

        public byte bEnterValue
        {
            get { return _bEnterValue; }
            set { _bEnterValue = value; }
        }

        private byte _bRaiseNCR;

        public byte bRaiseNCR
        {
            get { return _bRaiseNCR; }
            set { _bRaiseNCR = value; }
        }
    }
}
