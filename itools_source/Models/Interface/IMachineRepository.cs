using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IMachineRepository
    {
        Task<IEnumerable<Machine>> GetMachines(int iCompanyId);
    }
}
