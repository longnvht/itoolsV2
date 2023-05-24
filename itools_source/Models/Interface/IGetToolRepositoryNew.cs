using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinamiToolUser.Models.Interface
{
    public interface IGetToolRepositoryNew
    {
        Task<IEnumerable<ToolModel>> GetToolList(int opID);
        Task<IEnumerable<ToolModel>> GetToolListByToolCode(int opID, string searchValue); //Searchs
        Task<IEnumerable<TrayModel>> GetTrayList(int toolID);
        Task<IEnumerable<TrayModel>> GetAllTrayList();
    }
}
