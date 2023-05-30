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
        Task<IEnumerable<TempToolModel>> GetAllToolList(string userID); //Searchs
        Task<IEnumerable<TempToolModel>> GetToolListByValue(string userID, string toolCode);
    }
}
