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
        Task<IEnumerable<MachineModel>> GetMachineList();
        Task<IEnumerable<CompanyModel>> GetCompanyList();//Searchs
    }
}
