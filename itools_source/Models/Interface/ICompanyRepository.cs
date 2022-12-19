using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> GetCompanies();
    }
}
