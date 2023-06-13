using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models
{
    public class TempToolModel
    {
        private int toolID;
        private string toolCode;
        private string toolName;
        private string toolDescription;

        public int ToolID { get => toolID; set => toolID = value; }
        public string ToolCode { get => toolCode; set => toolCode = value; }
        public string ToolName { get => toolName; set => toolName = value; }
        public string ToolDescription { get => toolDescription; set => toolDescription = value; }
    }
}
