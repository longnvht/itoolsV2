using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IJobRepository
    {
        Task<SortedList<string, string>> GetJobByJobNumber(string strJobNumber);
        Task<Dictionary<int?, Dictionary<string, string>>> GetOPByJobPartOPID(string strJobNumber, int? iPartID); // PartOP
    }
}
