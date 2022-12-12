using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source.Repository
{
    public class StockRepository : IStockRepository
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(GetToolRepository).Name);

        public async Task<IEnumerable<Stock>> GetStocks()
        {
            BindingList<Stock> lstStock = null;
            string strQueryProcedure = @"GetStocks";
            _log.Info("Store procedure query get all in stock: " + strQueryProcedure);

            try
            {
                using (var mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (var mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strStoreProcedure: strQueryProcedure, mySqlConn: mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            lstStock = new BindingList<Stock>();
                            Stock stock = null;
                            while (await mySqlDataReader.ReadAsync())
                            {
                                stock = new Stock();
                                // 1. ToolId
                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    stock.iToolId = mySqlDataReader.GetInt32(0);
                                }
                                // 2. Quantity
                                if (!await mySqlDataReader.IsDBNullAsync(1))
                                {
                                    stock.iQuantity = mySqlDataReader.GetInt16(1);
                                }
                                // 3. Location
                                if (!await mySqlDataReader.IsDBNullAsync(2))
                                {
                                    stock.strLocation = mySqlDataReader.GetString(2);
                                }
                                else
                                {
                                    stock.strLocation = DBNull.Value.ToString();
                                }
                                lstStock.Add(stock);
                            }
                        }
                    }
                    await mySqlConnection.CloseAsync();
                }

                return lstStock;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                throw new NotImplementedException(e.Message);
            }
        }

        public async Task<IEnumerable<Tool>> GetToolIdToolCode()
        {
            List<Tool> lstTool = null;
            string strQueryProcedure = @"GetTools";
            _log.Info("Store procedure query get all in tool: " + strQueryProcedure);

            try
            {
                using (var mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (var mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strStoreProcedure: strQueryProcedure, mySqlConn: mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            lstTool = new List<Tool>();
                            Tool tool = null;
                            while (await mySqlDataReader.ReadAsync())
                            {
                                tool = new Tool();
                                // 1. ToolId, 2. ToolCode
                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    tool.iToolId = mySqlDataReader.GetInt32(0);
                                }
                                if (!await mySqlDataReader.IsDBNullAsync(1))
                                {
                                    tool.strToolCode = mySqlDataReader.GetString(1);
                                }
                                lstTool.Add(tool);
                            }
                        }
                    }
                    await mySqlConnection.CloseAsync();
                }

                return lstTool;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                throw new NotImplementedException(e.Message);
            }
        }
    }
}
