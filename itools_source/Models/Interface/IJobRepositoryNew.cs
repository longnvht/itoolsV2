using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models.Interface
{
    public interface IJobRepositoryNew
    {
        Task<IEnumerable<JobModelNew>> GetAll();
        Task<IEnumerable<JobModelNew>> GetByValue(string value);//Searchs
    }
}
