using itools_source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinamiToolUser.Models;

namespace VinamiToolUser.Utils
{
    public static class CommonValue
    {
        private static UserAccount _userLogin;
        private static JobModelNew _currentJob;
        private static OPModel _currentOP;
        private static ToolModel _currentTool;
        private static TrayModel _currentTray;

        public static UserAccount UserLogin { get => _userLogin; set => _userLogin = value; }
        public static JobModelNew CurrentJob { get => _currentJob; set => _currentJob = value; }
        public static OPModel CurrentOP { get => _currentOP; set => _currentOP = value; }
        public static ToolModel CurrentTool { get => _currentTool; set => _currentTool = value; }
        public static TrayModel CurrentTray { get => _currentTray; set => _currentTray = value; }
    }
}
