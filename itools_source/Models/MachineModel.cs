using System;

namespace itools_source.Models
{
    public class MachineModel
    {
        private int machineID;
        private string machineCode;
        private string machineName;
        private string machineSerial;

        public int MachineID { get => machineID; set => machineID = value; }
        public string MachineCode { get => machineCode; set => machineCode = value; }
        public string MachineName { get => machineName; set => machineName = value; }
        public string MachineSerial { get => machineSerial; set => machineSerial = value; }
    }
}
