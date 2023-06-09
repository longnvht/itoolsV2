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
        Task<IEnumerable<TrayModel>> GetCurrentTrayList(int toolID, int machineID);
        Task<IEnumerable<TrayModel>> GetOtherTrayList(int toolID, int machineID);
        Task<IEnumerable<TrayModel>> GetAllTrayList();
        Task<bool> UpdateToolStock(int trayID, int toolID, int newQty);
        Task<bool> UpdateGetToolTransaction(int machineID, string userID, string opNumber, string jobNumber, int toolID, string trayIndex, int qtyExchange, string typeTransaction, string transactionStatus);
    }
}
