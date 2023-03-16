using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IToolMachineTrayRepository
    {
        Task<bool> UpdateTrayQuantityToolID(ToolMachineTray toolMachineTray); // Update ToolID, Quantity, UpdateDate in table ToolsMachineTray
        Task<bool> UpdateQuantityToolTray(ToolMachineTray toolMachineTray);
        Task<ToolMachineTray> GetToolMachineTray(int? iTrayID);
        Task<int> GetQuantityInTray(int? iTrayID);
        Task<bool> IsToolInMachineTray(int? iTrayId, int? iToolId);
        Task<int?> GetTheLargestToolMachineTray();
        Task<Dictionary<int, Dictionary<string, string>>> GetTrayIndexAndToolCode(int? iMachineId);
        Task<int?> GetToolIDByTrayID(int? iTrayID);
    }
}