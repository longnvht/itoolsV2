using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using itools_source.Models;
using MySql.Data.MySqlClient;
using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using static VinamiToolUser.Utils.MySqlConnect;

namespace VinamiToolUser.Repository
{
    public class StockRepository : IStockRepository
    {
        public async Task<IEnumerable<StockModel>> GetStockForMachine(string companyCode)
        {
            try
            {
                var stockList = new List<StockModel>();
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"GetReportStock";
                    MySqlParameter prm = CreateInputParameterForSQL(cmd, "@pCompanyCode", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm);
                    using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                    {
                        if (dataReader != null)
                        {
                            while (dataReader.Read())
                            {
                                var stockModel = new StockModel();
                                if (!dataReader.IsDBNull(0))
                                {
                                    stockModel.MachineCode = dataReader.GetString(0);
                                }
                                if (!dataReader.IsDBNull(1))
                                {
                                    stockModel.TrayName = dataReader.GetString(1);
                                }
                                if (!dataReader.IsDBNull(2))
                                {
                                    stockModel.ToolCode = dataReader.GetString(2);
                                }
                                if (!dataReader.IsDBNull(3))
                                {
                                    stockModel.StockQty = dataReader.GetInt32(3);
                                }
                                stockList.Add(stockModel);
                            }
                        }
                        dataReader.Close();
                    }
                    connection.Close();
                }
                return stockList;
            }
            catch (Exception ex) { return null; }
        }

        public async Task<IEnumerable<StockModel>> SearchStockForMachine(string companyCode, string searchValue)
        {
            try
            {
                var stockList = new List<StockModel>();
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"SearchReportStock";
                    MySqlParameter prm = CreateInputParameterForSQL(cmd, "@pCompanyCode", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm);
                    MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "@pSearchValue", MySqlDbType.VarChar, searchValue);
                    cmd.Parameters.Add(prm2);
                    using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                    {
                        if (dataReader != null)
                        {
                            while (dataReader.Read())
                            {
                                var stockModel = new StockModel();
                                if (!dataReader.IsDBNull(0))
                                {
                                    stockModel.MachineCode = dataReader.GetString(0);
                                }
                                if (!dataReader.IsDBNull(1))
                                {
                                    stockModel.TrayName = dataReader.GetString(1);
                                }
                                if (!dataReader.IsDBNull(2))
                                {
                                    stockModel.ToolCode = dataReader.GetString(2);
                                }
                                if (!dataReader.IsDBNull(3))
                                {
                                    stockModel.StockQty = dataReader.GetInt32(3);
                                }
                                stockList.Add(stockModel);
                            }
                        }
                        dataReader.Close();
                    }
                    connection.Close();
                }
                return stockList;
            }
            catch (Exception ex) { return null; }
        }
    }
}
