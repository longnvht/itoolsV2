using itools_source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models.Interface
{
    public interface ISettingRepository
    {
        Task<IEnumerable<CompanyModel>> GetCompanyList();//Searchs
        Task<IEnumerable<MachineModel>> GetValidMachine(int companyID);
        Task<bool> UpdateMachineSerial(string machineCode,  string serial);
    }
}
