using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models
{
    public class MachineConfigModel
    {
        private string _comPort;
        private int _machineID;
        private string _hardDiskSerial;

        public string ComPort { get => _comPort; set => _comPort = value; }
        public int MachineID { get => _machineID; set => _machineID = value; }
        public string HardDiskSerial { get => _hardDiskSerial; set => _hardDiskSerial = value; }
    }
}
