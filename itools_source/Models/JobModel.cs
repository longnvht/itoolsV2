using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models
{
    public class JobModel
    {
        private string jobNumber;
        private int partID;
        private int poLineID;

        public string JobNumber { get => jobNumber; set => jobNumber = value; }
        public int PartID { get => partID; set => partID = value; }
        public int PoLineID { get => poLineID; set => poLineID = value; }
    }
}
