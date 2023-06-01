using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models
{
    public class TempToolModel
    {
        private int stockID;
        private int toolID;
        private string toolCode;
        private string toolName;
        private int toolQuantity;

        public int ToolID { get => toolID; set => toolID = value; }
        public string ToolCode { get => toolCode; set => toolCode = value; }
        public string ToolName { get => toolName; set => toolName = value; }
        public int ToolQuantity { get => toolQuantity; set => toolQuantity = value; }
        public int StockID { get => stockID; set => stockID = value; }
    }
}
