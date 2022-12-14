using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IToolMachineTrayRepository
    {
        Task<bool> UpdateTrayQuantityToolCode(ToolMachineTray toolMachineTray);
        Task<bool> UpdateQuantityToolTray(ToolMachineTray toolMachineTray);
        Task<ToolMachineTray> GetToolByTrayIndex(int? iTrayID); //
        Task<int> GetToolQuantity(int? iTrayID); //
        Task<IEnumerable<string>> GetToolCodeList(); //
        Task<bool> IsToolInMachineTray(string strTrayIndex, int? iMachineId, int? iToolId); //
        Task<bool> AddWorkingTransaction(WorkingTransaction workingTransaction);
        Task<int?> GetTheLargestToolMachineTray();
        Task<Dictionary<int, Dictionary<string, string>>> GetTrayIndexAndToolCode(int? iMachineId); //
        Task<int?> GetToolIDByToolCode(string strToolCode);
        Task<int?> GetQuantityByToolID(int? iToolID);
        Task<bool> UpdateQuantityStock(int? iToolID = null, int? iQuantity = null);
        Task<int?> GetToolIDByTrayID(int? iTrayID);
    }
}
