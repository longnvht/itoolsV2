using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models
{
    public class Menu
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

		private string _strMenuDescription;

		public string strMenuDescription
        {
			get { return _strMenuDescription; }
			set { _strMenuDescription = value; }
		}

	}
}
