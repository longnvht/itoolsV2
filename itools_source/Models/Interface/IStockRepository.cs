using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IStockRepository
    {
        Task<IEnumerable<Stock>> GetStocks(); // Get list stock.
        Task<IEnumerable<Tool>> GetToolIdToolCode(); // Get list tool id, toolcode.
        Task<int?> GetQuantityByToolID(int? iToolID); // Stock
        Task<bool> UpdateQuantityStock(int? iToolID = null, int? iQuantity = null); // Stock
    }
}
