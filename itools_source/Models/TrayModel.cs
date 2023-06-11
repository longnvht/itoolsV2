using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models
{
    public class TrayModel
    {
        private int trayId;
        private string trayName;
        private string machineCode;
        private int qtyStock;

        public int TrayId { get => trayId; set => trayId = value; }
        public string TrayName { get => trayName; set => trayName = value; }
        public int QtyStock { get => qtyStock; set => qtyStock = value; }
        public string MachineCode { get => machineCode; set => machineCode = value; }
    }
}
