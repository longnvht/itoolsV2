using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models
{
    public class OPModel
    {
        private int opID;
        private string opNumber;
        private int partID;
        private string opType;
        private string jobNumber;

        public int OpID { get => opID; set => opID = value; }
        public string OpNumber { get => opNumber; set => opNumber = value; }
        public int PartID { get => partID; set => partID = value; }
        public string JobNumber { get => jobNumber; set => jobNumber = value; }
        public string OpType { get => opType; set => opType = value; }
    }
}
