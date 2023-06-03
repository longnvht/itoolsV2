using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models.Interface
{
    public interface IOpRepository
    {
        Task<IEnumerable<OPModel>> GetAll(JobModel job);
        Task<IEnumerable<OPModel>> GetByValue(JobModel job, string value);//Searchs
    }
}
