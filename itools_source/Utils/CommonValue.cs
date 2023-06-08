using itools_source.Models;
using Salaros.Configuration;
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
        private const string appConfig = @"C:\ProgramData\VinamItools\VinamItoolsConfig.dat";
        private static UserAccount _userLogin;
        private static JobModel _currentJob;
        private static OPModel _currentOP;
        private static ToolModel _currentTool;
        private static TrayModel _currentTray;
        private static MachineConfigModel _configModel;


        public static UserAccount UserLogin { get => _userLogin; set => _userLogin = value; }
        public static JobModel CurrentJob { get => _currentJob; set => _currentJob = value; }
        public static OPModel CurrentOP { get => _currentOP; set => _currentOP = value; }
        public static ToolModel CurrentTool { get => _currentTool; set => _currentTool = value; }
        public static TrayModel CurrentTray { get => _currentTray; set => _currentTray = value; }
        public static MachineConfigModel ConfigModel 
        { 
            get => _configModel; 
            set 
            { 
                _configModel = value;
                SaveConfig(value);
            } 
        }

        public static MachineConfigModel LoadConfig()
        {
            try
            {
                // load config .datL
                MachineConfigModel configModel = new MachineConfigModel();
                var cfg = new ConfigParser(appConfig);
                if (!Int32.TryParse(cfg.GetValue("CONFIG", "CompanyID"), out int companyID)) return null;
                if (configModel.MachineID < 0) return null;
                configModel.CompanyID = companyID;
                if (!Int32.TryParse(cfg.GetValue("CONFIG", "MachineID"), out int machineID)) return null;
                if (configModel.MachineID < 0) return null;
                configModel.MachineID = machineID;
                string comPort = cfg.GetValue("CONFIG", "ComPort");
                if(String.IsNullOrEmpty(comPort)) return null;
                configModel.ComPort = comPort;
                string hardDiskSerial = cfg.GetValue("CONFIG", "HardDiskSerial");
                if(String.IsNullOrEmpty(hardDiskSerial)) return null;
                configModel.HardDiskSerial = hardDiskSerial;
                return configModel;
            }
            catch (Exception)
            {

            }
            return null;
        }

        private static void SaveConfig(MachineConfigModel configModel)
        {
            if(configModel != null)
            {
                var cfg = new ConfigParser(appConfig);
                cfg.SetValue("CONFIG", "CompanyID", configModel.CompanyID);
                cfg.SetValue("CONFIG", "MachineID", configModel.MachineID);
                cfg.SetValue("CONFIG", "ComPort", configModel.ComPort);
                cfg.SetValue("CONFIG", "HardDiskSerial", configModel.HardDiskSerial);
                cfg.Save();
            }
        }
    }
}
