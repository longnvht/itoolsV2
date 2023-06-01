﻿using System;
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
        Task UpdateStockQuantity(int trayID, int? toolID, int newQty);
        Task UpdateTempStockQuantity(int? stockID, int? toolID, string userID, int newQty);
        Task UpdateTransaction(int machineID, int userID, string typeTransaction, int qty);
    }
}
