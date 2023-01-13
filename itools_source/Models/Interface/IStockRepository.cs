using System.Collections.Generic;
using System.Threading.Tasks;
using VinamiToolUser.DTOs;

namespace itools_source.Models.Interface
{
    public interface IStockRepository
    {
        Task<IEnumerable<Stock>> GetStocks(); // Get list stock.
        Task<IEnumerable<ReportStock>> GetReportStockByMachineID(int? iMachineID); // Get list stock.
        Task<IEnumerable<Tool>> GetToolIdToolCode(); // Get list tool id, toolcode.
        Task<int?> GetQuantityByToolID(int? iToolID);
        Task<bool> UpdateQuantityStock(int? iToolID = null, int? iQuantity = null);
    }
}
