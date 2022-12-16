using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IToolMachineTrayRepository
    {
        Task<bool> UpdateTrayQuantityToolCode(ToolMachineTray toolMachineTray); // Tray
        Task<bool> UpdateQuantityToolTray(ToolMachineTray toolMachineTray); // Tray
        Task<ToolMachineTray> GetToolMachineTray(int? iTrayID); // Tray
        Task<int> GetQuantityInTray(int? iTrayID); // Tray
        Task<bool> IsToolInMachineTray(int? iTrayId, int? iToolId); // Tray
        Task<int?> GetTheLargestToolMachineTray(); // Tray
        Task<Dictionary<int, Dictionary<string, string>>> GetTrayIndexAndToolCode(int? iMachineId); // Tray
        Task<int?> GetToolIDByTrayID(int? iTrayID); // Tray
    }
}
