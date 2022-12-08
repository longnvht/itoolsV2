using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IPermissionRepository
    {
        Task<string> GetPermissionNameById(string strId);
    }
}
