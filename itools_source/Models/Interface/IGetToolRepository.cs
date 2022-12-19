using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IGetToolRepository
    {
        IEnumerable<Job> GetAllJobs(); // Job
        Job GetJobs(); // Job
        Task<SortedList<string, string>> GetJobByJobNumber(string strJobNumber); // Job
        Dictionary<int?, Dictionary<string, string>> GetOPByJobPartOPID(string strJobNumber, int? iPartID); // PartOP
        Task<Dictionary<int, string>> GetByToolForOP(int? iOPId); // Tool and toolforop
        Task<Dictionary<int, Dictionary<string, string>>> GetModelDescriptionByToolId(int iToolId); // Tool
        Task<Dictionary<int, List<object>>> GetMachineTrayByToolId(int iToolID, int iMachineID);  // ToolsMachineTray
        Task<Dictionary<int, List<object>>> GetMachineTrayQuantityByToolId(int iToolID); // ToolsMachineTray
    }
}
