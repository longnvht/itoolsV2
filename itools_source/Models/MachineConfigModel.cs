using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models
{
    public class MachineConfigModel
    {
        private string _companyCode;
        private string _machineCode;
        private string _comPort;
        private string _hardDiskSerial;

        public string HardDiskSerial { get => _hardDiskSerial; set => _hardDiskSerial = value; }
        public string ComPort { get => _comPort; set => _comPort = value; }
        public string CompanyCode { get => _companyCode; set => _companyCode = value; }
        public string MachineCode { get => _machineCode; set => _machineCode = value; }
    }
}
