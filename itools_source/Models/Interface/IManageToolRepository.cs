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
        Task<IEnumerable<TrayModelManage>> GetTrayListByValue(int machineID, string searchValue);
        Task<IEnumerable<TempToolModel>> GetAllToolList(string userID); //Searchs
        Task<IEnumerable<TempToolModel>> GetToolListByValue(string userID, string toolCode);
        Task<bool> UpdateStockQuantity(int trayID, int toolID, int newQty);
        Task<bool> UpdateTempStockQuantity(int? stockID, int? toolID, string userID, int newQty);
        Task<bool> UpdateTransaction(int machineID, string userID, int toolID, string trayIndex, int qtyExchange, string typeTransaction, string transactionStatus);
    }
}
