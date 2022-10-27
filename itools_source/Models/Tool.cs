using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class Tool
    {
        private int _IToolId;

        public int IToolId
        {
            get { return _IToolId; }
            set { _IToolId = value; }
        }

        private string _StrToolCode;

        public string StrToolCode
        {
            get { return _StrToolCode; }
            set { _StrToolCode = value; }
        }

        private string _StrCompanyCode;

        public string StrCompanyCode
        {
            get { return _StrCompanyCode; }
            set { _StrCompanyCode = value; }
        }

        private string _StrModel;

        public string StrModel
        {
            get { return _StrModel; }
            set { _StrModel = value; }
        }

        private string _StrBarCode;

        public string StrBarCode
        {
            get { return _StrBarCode; }
            set { _StrBarCode = value; }
        }

        private string _StrDescription;

        public string StrDescription
        {
            get { return _StrDescription; }
            set { _StrDescription = value; }
        }

        private DateTime _DtCreateDate;

        public DateTime DtCreateDate
        {
            get { return _DtCreateDate; }
            set { _DtCreateDate = value; }
        }

        private DateTime _DtUpdateDate;

        public DateTime DtUpdateDate
        {
            get { return _DtUpdateDate; }
            set { _DtUpdateDate = value; }
        }

        private byte _IsActive;

        public byte IsActive
        {
            get { return _IsActive; }
            set { _IsActive = value; }
        }
    }
}
