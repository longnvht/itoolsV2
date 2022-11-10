using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IToolRepository
    {
        void AddTool(Tool tool);
        void AddNewTool(Tool newTool);
        void UpdateTool(Tool tool);
        void DeleteTool(Tool tool);
        ToolsMachineTray GetToolByTrayIndex(string strTrayIndex, string strMachineCode);
        int GetToolQuantity(string strTrayIndex);
        IEnumerable<string> GetToolCodeList();
    }
}
