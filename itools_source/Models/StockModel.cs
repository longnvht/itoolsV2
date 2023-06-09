using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models
{
    public class StockModel
    {
        private string _trayName;
        private string _toolCode;
        private string _toolName;
        private int _stockQty;

        public string TrayName { get => _trayName; set => _trayName = value; }
        public string ToolCode { get => _toolCode; set => _toolCode = value; }
        public string ToolName { get => _toolName; set => _toolName = value; }
        public int StockQty { get => _stockQty; set => _stockQty = value; }
    }
}
