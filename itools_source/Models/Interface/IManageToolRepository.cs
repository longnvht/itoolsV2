using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models.Interface
{
    public interface IManageToolRepository
    {
        Task<IEnumerable<TrayModelManage>> GetAllTrayList(string machineCode);
        Task<IEnumerable<TrayModelManage>> GetTrayListByValue(string machineCode, string searchValue);
        Task<IEnumerable<TempToolModel>> GetAllToolList(string machineCode); //Searchs
        Task<IEnumerable<TempToolModel>> GetToolListByValue(string machineCode, string searchValue);
        Task<bool> UpdateStockQuantity(int trayID, string toolCode, int newQty);
        Task<bool> AddNewToolToTray(string machineCode, string toolCode, string trayIndex, int quantity);
        Task<bool> UpdateTransaction(string companyCode, string machineCode, string userID, string toolCode, string trayIndex, int qtyExchange, string typeTransaction, string transactionStatus);
    }
}
