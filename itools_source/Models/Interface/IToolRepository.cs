using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IToolRepository
    {
        bool AddTool(Tool tool);
        bool AddNewToolMachineTray(ToolMachineTray toolMachineTray);
        bool UpdateMachineTray(ToolMachineTray toolMachineTray);
        bool AddNewTool(Tool newTool);
        bool UpdateTool(Tool tool);
        bool DeleteTool(Tool tool);
        ToolMachineTray GetToolByTrayIndex(string strTrayIndex, string strMachineCode);
        int GetToolQuantity(string strTrayIndex);
        IEnumerable<string> GetToolCodeList();
        bool AddToolMachineTray(ToolMachineTray toolMachineTray);
        bool IsMachineTray(string strMachineCode, string strTrayIndex);
        bool AddWorkingTransaction(WorkingTransaction workingTransaction);
    }
}
