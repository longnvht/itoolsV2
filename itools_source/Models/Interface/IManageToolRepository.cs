using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models.Interface
{
    public interface IManageToolRepository
    {
        Task<IEnumerable<TrayModelManage>> GetAllTrayList(int machineID);
        Task<IEnumerable<TrayModelManage>> GetTrayListByValue(int machineID, string value);
        Task<IEnumerable<ToolModel>> GetAllToolList(); //Searchs
        Task<IEnumerable<ToolModel>> GetToolListByValue(string value);
    }
}
