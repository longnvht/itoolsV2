using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models.Interface
{
    public interface IJobRepository
    {
        Task<IEnumerable<JobModel>> GetAll();
        Task<IEnumerable<JobModel>> GetByValue(string value);//Searchs
    }
}
