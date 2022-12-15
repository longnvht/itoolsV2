using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IToolRepository
    {
        Task<Dictionary<int, string>> GetToolCodeList();
    }
}
