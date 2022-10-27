using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class Roles
    {
        private int _IRoleId;

        public int IRoleId
        {
            get { return _IRoleId; }
            set { _IRoleId = value; }
        }

        private string _StrRoleName;

        public string StrRoleName
        {
            get { return _StrRoleName; }
            set { _StrRoleName = value; }
        }

        private int _IRoleType;

        public int IRoleType
        {
            get { return _IRoleType; }
            set { _IRoleType = value; }
        }

        private int _IsRole;

        public int IsRole
        {
            get { return _IsRole; }
            set { _IsRole = value; }
        }

        private DateTime _DtUpdateDate;

        public DateTime DtUpdateDate
        {
            get { return _DtUpdateDate; }
            set { _DtUpdateDate = value; }
        }
    }
}
