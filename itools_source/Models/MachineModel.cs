using System;

namespace itools_source.Models
{
    public class MachineModel
    {
        private int machineID;
        private string machineCode;
        private string machineName;
        private string machineSerial;
        private int companyID;

        public int MachineID { get => machineID; set => machineID = value; }
        public string MachineCode { get => machineCode; set => machineCode = value; }
        public string MachineName { get => machineName; set => machineName = value; }
        public string MachineSerial { get => machineSerial; set => machineSerial = value; }
        public int CompanyID { get => companyID; set => companyID = value; }
    }
}
