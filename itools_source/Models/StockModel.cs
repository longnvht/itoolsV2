using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models
{
    public class StockModel
    {

        private string _machineCode;
        private string _trayName;
        private string _toolCode;
        private int _stockQty;

        public string MachineCode { get => _machineCode; set => _machineCode = value; }
        public string TrayName { get => _trayName; set => _trayName = value; }
        public string ToolCode { get => _toolCode; set => _toolCode = value; }
        public int StockQty { get => _stockQty; set => _stockQty = value; }
        
    }
}
