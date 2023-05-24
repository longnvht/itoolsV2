using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models
{
    public class MenuModel
    {
        private string _menuId;
        private string _menuName;
        private string _viewName;
        private string _icon;
        private string _menuDescription;
        public string MenuId
        {
            get { return _menuId; }
            set { _menuId = value; }
        }
        public string MenuName
        {
            get { return _menuName; }
            set { _menuName = value; }
        }
        public string MenuDescription
        {
            get { return _menuDescription; }
            set { _menuDescription = value; }
        }

        public string ViewName { get => _viewName; set => _viewName = value; }
        public string Icon { get => _icon; set => _icon = value; }
    }
}
