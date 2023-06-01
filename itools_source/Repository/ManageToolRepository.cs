using itools_source.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using static VinamiToolUser.Utils.MySqlConnect;

namespace VinamiToolUser.Repository
{
    public class ManageToolRepository : IManageToolRepository
    {
        public async Task<IEnumerable<TempToolModel>> GetAllToolList(string userID)
        {
            var toolList = new List<TempToolModel>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"GetTempToolByUserID";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "userID", MySqlDbType.VarChar, userID);
                cmd.Parameters.Add(prm);
                using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                {
                    if (dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            var toolModel = new TempToolModel();
                            if (!dataReader.IsDBNull(0))
                            {
                                toolModel.StockID = dataReader.GetInt32(0);
                            }
                            if (!dataReader.IsDBNull(1))
                            {
                                toolModel.ToolID = dataReader.GetInt32(1);
                            }
                            if (!dataReader.IsDBNull(2))
                            {
                                toolModel.ToolCode = dataReader.GetString(2);
                            }
                            if (!dataReader.IsDBNull(3))
                            {
                                toolModel.ToolName = dataReader.GetString(3);
                            }
                            if (!dataReader.IsDBNull(4))
                            {
                                toolModel.ToolQuantity = dataReader.GetInt32(4);
                            }
                            toolList.Add(toolModel);
                        }
                    }
                    dataReader.Close();
                }
                connection.Close();
            }
            return toolList;
        }

        public async Task<IEnumerable<TempToolModel>> GetToolListByValue(string userID, string toolCode)
        {
            List<TempToolModel> toolList = new List<TempToolModel>();

            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"SearchTempToolForUserID";

                MySqlParameter prm = CreateInputParameterForSQL(cmd, "userID", MySqlDbType.VarChar, userID);
                cmd.Parameters.Add(prm);
                MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "toolCode", MySqlDbType.VarChar, toolCode);
                cmd.Parameters.Add(prm2);
                using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                {
                    var dt = dataReader;
                    if (dataReader != null)
                    {
                        while (await dataReader.ReadAsync())
                        {
                            var toolModel = new TempToolModel();
                            if (!await dataReader.IsDBNullAsync(0))
                            {
                                toolModel.StockID = dataReader.GetInt32(0);
                            }
                            if (!await dataReader.IsDBNullAsync(1))
                            {
                                toolModel.ToolID = dataReader.GetInt32(1);
                            }
                            if (!await dataReader.IsDBNullAsync(2))
                            {
                                toolModel.ToolCode = dataReader.GetString(2);
                            }
                            if (!await dataReader.IsDBNullAsync(3))
                            {
                                toolModel.ToolName = dataReader.GetString(3);
                            }
                            if (!await dataReader.IsDBNullAsync(4))
                            {
                                toolModel.ToolQuantity = dataReader.GetInt32(4);
                            }
                            toolList.Add(toolModel);
                        }
                    }
                    dataReader.Close();
                }
                await connection.CloseAsync();
            }
            return toolList;
        }

        public async Task<IEnumerable<TrayModelManage>> GetAllTrayList(int machineID)
        {
            var trayList = new List<TrayModelManage>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"GetTrayStockForMachine";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "WHID", MySqlDbType.Int32, machineID);
                cmd.Parameters.Add(prm);
                using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                {
                    if (dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            var trayModel = new TrayModelManage();
                            if (!dataReader.IsDBNull(0))
                            {
                                trayModel.TrayId = dataReader.GetInt32(0);
                            }
                            if (!dataReader.IsDBNull(1))
                            {
                                trayModel.TrayName = dataReader.GetString(1);
                            }
                            if (!dataReader.IsDBNull(2))
                            {
                                trayModel.ToolID = dataReader.GetInt32(2);
                            }
                            if (!dataReader.IsDBNull(3))
                            {
                                trayModel.ToolCode = dataReader.GetString(3);
                            }
                            if (!dataReader.IsDBNull(4))
                            {
                                trayModel.QtyStock = dataReader.GetInt32(4);
                            }
                                trayList.Add(trayModel);
                        }
                    }
                    dataReader.Close();
                }
                connection.Close();
            }
            return trayList;
        }

        

        public async Task<IEnumerable<TrayModelManage>> GetTrayListByValue(int machineID, string searchValue)
        {
            var trayList = new List<TrayModelManage>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"SearchTrayStockForMachine";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "WHID", MySqlDbType.Int32, machineID);
                cmd.Parameters.Add(prm);
                MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "searchValue", MySqlDbType.VarChar, searchValue);
                cmd.Parameters.Add(prm2);
                using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                {
                    if (dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            var trayModel = new TrayModelManage();
                            if (!dataReader.IsDBNull(0))
                            {
                                trayModel.TrayId = dataReader.GetInt32(0);
                            }
                            if (!dataReader.IsDBNull(1))
                            {
                                trayModel.TrayName = dataReader.GetString(1);
                            }
                            if (!dataReader.IsDBNull(2))
                            {
                                trayModel.ToolID = dataReader.GetInt32(2);
                            }
                            if (!dataReader.IsDBNull(3))
                            {
                                trayModel.ToolCode = dataReader.GetString(3);
                            }
                            if (!dataReader.IsDBNull(4))
                            {
                                trayModel.QtyStock = dataReader.GetInt32(4);
                            }
                            trayList.Add(trayModel);
                        }
                    }
                    dataReader.Close();
                }
                connection.Close();
            }
            return trayList;
        }

        public async Task<bool> UpdateStockQuantity(int trayID, int toolID, int newQty)
        {
            bool result = false;
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"UpdateStockQuantity";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "trayID", MySqlDbType.Int32, trayID);
                cmd.Parameters.Add(prm);
                MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "toolID", MySqlDbType.Int32, toolID);
                cmd.Parameters.Add(prm2);
                MySqlParameter prm3 = CreateInputParameterForSQL(cmd, "newQty", MySqlDbType.Int32, newQty);
                cmd.Parameters.Add(prm3);
                result = await CmdExecutionProcedureAsync(cmd);
                await connection.CloseAsync();
            }
            return result;

        }

        public async Task<bool> UpdateTempStockQuantity(int? stockID, int? toolID, string userID, int newQty)
        {
            bool result = false;
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"UpdateTempStockQty";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "stockID", MySqlDbType.Int32, stockID);
                cmd.Parameters.Add(prm);
                MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "toolID", MySqlDbType.Int32, toolID);
                cmd.Parameters.Add(prm2);
                MySqlParameter prm3 = CreateInputParameterForSQL(cmd, "userLogin", MySqlDbType.VarChar, userID);
                cmd.Parameters.Add(prm3);
                MySqlParameter prm4 = CreateInputParameterForSQL(cmd, "newStock", MySqlDbType.Int32, newQty);
                cmd.Parameters.Add(prm4);
                result = await CmdExecutionProcedureAsync(cmd);
                await connection.CloseAsync();
            }
            return result;
        }

        public async Task<bool> UpdateTransaction(int machineID, string userID, int toolID, string trayIndex, int qtyExchange, string typeTransaction, string  transactionStatus )
        {
            bool result = false;
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"UpdateManageToolTransaction";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "machineID", MySqlDbType.Int32, machineID);
                cmd.Parameters.Add(prm);
                MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "userLogin", MySqlDbType.VarChar, userID);
                cmd.Parameters.Add(prm2);
                MySqlParameter prm3 = CreateInputParameterForSQL(cmd, "toolID", MySqlDbType.Int32, toolID);
                cmd.Parameters.Add(prm3);
                MySqlParameter prm4 = CreateInputParameterForSQL(cmd, "trayIndex", MySqlDbType.VarChar, trayIndex);
                cmd.Parameters.Add(prm4);
                MySqlParameter prm5 = CreateInputParameterForSQL(cmd, "qtyExchange", MySqlDbType.Int32, qtyExchange);
                cmd.Parameters.Add(prm5);
                MySqlParameter prm6 = CreateInputParameterForSQL(cmd, "transactionType", MySqlDbType.VarChar, typeTransaction);
                cmd.Parameters.Add(prm6);
                MySqlParameter prm7 = CreateInputParameterForSQL(cmd, "transactionStatus", MySqlDbType.VarChar, transactionStatus);
                cmd.Parameters.Add(prm7);
                result = await CmdExecutionProcedureAsync(cmd);
                await connection.CloseAsync();
            }
            return result;
        }
    }
}
