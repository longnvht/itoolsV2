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
        Task<bool> UpdateToolStock(int trayID, int newQty);
        Task<bool> UpdateGetToolTransaction(string machineCode, string companyCode, string userLogin, string toolCode, string trayIndex, int qtyExchange, string typeTransaction, string transactionStatus);
    }
}
