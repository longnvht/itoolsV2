using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models
{
    public class WorkInfoModel
    {
        private string _workCode;
        private string _workMachineCode;

        public string WorkCode { get => _workCode; set => _workCode = value; }
        public string WorkMachineCode { get => _workMachineCode; set => _workMachineCode = value; }
    }
}
