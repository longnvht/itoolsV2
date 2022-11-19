using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IToolMachineTrayRepository
    {
        bool AddNewToolMachineTray(ToolMachineTray toolMachineTray);
        bool UpdateToolMachineTray(ToolMachineTray toolMachineTray);
        ToolMachineTray GetToolByTrayIndex(string strTrayIndex, string strMachineCode);
        int GetToolQuantity(string strTrayIndex);
        IEnumerable<string> GetToolCodeList();
        bool IsMachineTray(string strMachineCode, string strTrayIndex);
        bool AddWorkingTransaction(WorkingTransaction workingTransaction);
        int? GetTheLargestToolMachineTray();
        SortedDictionary<string, string> GetTrayAndToolCode(string strMachine);
    }
}
