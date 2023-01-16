using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IGetToolRepository
    {
        Task<Dictionary<int, string>> GetByToolForOP(int? iOPId);
        Task<Dictionary<int, Dictionary<string, string>>> GetModelDescriptionByToolId(int? iToolId);
        Task<Dictionary<int, List<object>>> GetMachineTrayByToolId(int? iToolID, int iMachineID);
        Task<Dictionary<int, List<object>>> GetMachineTrayQuantityByToolId(int? iToolID);
    }
}
