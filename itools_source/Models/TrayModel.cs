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
        private string machineName;
        private int qtyStock;

        public int TrayId { get => trayId; set => trayId = value; }
        public string TrayName { get => trayName; set => trayName = value; }
        public int QtyStock { get => qtyStock; set => qtyStock = value; }
        public string MachineName { get => machineName; set => machineName = value; }
    }
}
