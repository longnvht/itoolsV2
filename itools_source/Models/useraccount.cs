namespace VinamiToolUser.Models
{
    public class UserAccount
    {
        private int _userID;
        private string _userName;
        private string _fullName;
        private string _userType;
        private string _permisionID;

        public int UserID { get => _userID; set => _userID = value; }
        public string UserName { get => _userName; set => _userName = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public string PermisionID { get => _permisionID; set => _permisionID = value; }
    }
}
