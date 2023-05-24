namespace itools_source.Models
{
    public class Menu
    {
        private string _menuId;
        private string _menuName;
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
    }
}
