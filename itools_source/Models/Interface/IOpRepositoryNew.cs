using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models.Interface
{
    public interface IOpRepositoryNew
    {
        Task<IEnumerable<OPModel>> GetAll(JobModelNew job);
        Task<IEnumerable<OPModel>> GetByValue(JobModelNew job, string value);//Searchs
    }
}
