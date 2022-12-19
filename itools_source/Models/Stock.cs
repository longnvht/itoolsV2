namespace itools_source.Models
{
    public class Stock
    {
        private int _iToolId;

        public int iToolId
        {
            get { return _iToolId; }
            set { _iToolId = value; }
        }

        private short _iQuantity;

        public short iQuantity
        {
            get { return _iQuantity; }
            set { _iQuantity = value; }
        }

        private string _strLocation;

        public string strLocation
        {
            get { return _strLocation; }
            set { _strLocation = value; }
        }

    }
}
