using itools_source.Views;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IMachineRepository
    {
        Task<string> GetExsitsSerialMachine(string strSerialMachine);
        Task<IEnumerable<Machine>> GetMachines(int iCompanyId);
        Task<bool> UpdateSerialMachine(int? strMachineId, string strSerialMachine);
    }
}
