using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IStockTempRepository
    {
        Task<bool> AddToolAndQuantity(StockTemp stockTemp);
        Task<bool> GetExsitsToolInStockTemp(StockTemp stockTemp);
        Task<bool> UpdateQuantityInStockTempAdd(StockTemp stockTemp);
        Task<bool> UpdateQuantityInStockTempTakeOut(StockTemp stockTemp);
    }
}
