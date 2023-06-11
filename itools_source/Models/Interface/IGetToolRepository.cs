using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinamiToolUser.Models.Interface
{
    public interface IGetToolRepository
    {
        Task<IEnumerable<ToolModel>> GetToolList(string companyCode);
        Task<IEnumerable<ToolModel>> GetToolListByToolCode(string companyCode, string searchValue); //Searchs
        Task<IEnumerable<TrayModel>> GetCurrentTrayList(string toolCode, string machineCode);
        Task<IEnumerable<TrayModel>> GetOtherTrayList(string  toolCode, string machineCode);
        Task<IEnumerable<TrayModel>> GetAllTrayList();
        Task<bool> UpdateToolStock(int trayID, int toolID, int newQty);
        Task<bool> UpdateGetToolTransaction(int machineID, string userID, string opNumber, string jobNumber, int toolID, string trayIndex, int qtyExchange, string typeTransaction, string transactionStatus);
    }
}
