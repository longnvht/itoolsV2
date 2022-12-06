using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IToolMachineTrayRepository
    {
        Task<bool> AddNewToolMachineTray(ToolMachineTray toolMachineTray);
        Task<bool> UpdateToolMachineTray(ToolMachineTray toolMachineTray);
        Task<ToolMachineTray> GetToolByTrayIndex(string strTrayIndex, string strMachineCode);
        Task<int> GetToolQuantity(string strTrayIndex);
        Task<IEnumerable<string>> GetToolCodeList();
        Task<bool> IsMachineTray(string strMachineCode, string strTrayIndex);
        Task<bool> AddWorkingTransaction(WorkingTransaction workingTransaction);
        Task<int?> GetTheLargestToolMachineTray();
        Task<SortedDictionary<string, string>> GetTrayAndToolCode(string strMachine);
        Task<int?> GetToolIDByToolCode(string strToolCode);
        Task<int?> GetQuantityByToolID(int? iToolID);
        Task<bool> UpdateQuantityStock(int? iToolID = null, int? iQuantity = null);
    }
}
