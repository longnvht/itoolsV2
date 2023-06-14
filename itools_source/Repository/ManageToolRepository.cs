using itools_source.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using static VinamiToolUser.Utils.MySqlConnect;

namespace VinamiToolUser.Repository
{
    public class ManageToolRepository : IManageToolRepository
    {
        public async Task<IEnumerable<TempToolModel>> GetAllToolList(string companyCode)
        {
            try
            {
                var toolList = new List<TempToolModel>();
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"GetActiveToolList";
                    MySqlParameter prm = CreateInputParameterForSQL(cmd, "pCompanyCode", MySqlDbType.VarChar, companyCode);
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
                                    toolModel.ToolID = dataReader.GetInt32(0);
                                }
                                if (!dataReader.IsDBNull(1))
                                {
                                    toolModel.ToolCode = dataReader.GetString(1);
                                }
                                if (!dataReader.IsDBNull(2))
                                {
                                    toolModel.ToolName = dataReader.GetString(2);
                                }
                                if (!dataReader.IsDBNull(3))
                                {
                                    toolModel.ToolDescription = dataReader.GetString(3);
                                }
                                toolList.Add(toolModel);
                            }
                        }
                        dataReader.Close();
                    }
                    connection.Close();
                }
                return toolList;
            }catch (Exception ex) { return null; }
        }

        public async Task<IEnumerable<TempToolModel>> GetToolListByValue(string companyCode, string searchValue)
        {
            try
            {
                List<TempToolModel> toolList = new List<TempToolModel>();

                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"SearchActiveToolList";

                    MySqlParameter prm = CreateInputParameterForSQL(cmd, "pCompanyCode", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm);
                    MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "pSearchValue", MySqlDbType.VarChar, searchValue);
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
                                    toolModel.ToolID = dataReader.GetInt32(0);
                                }
                                if (!await dataReader.IsDBNullAsync(1))
                                {
                                    toolModel.ToolCode = dataReader.GetString(1);
                                }
                                if (!await dataReader.IsDBNullAsync(2))
                                {
                                    toolModel.ToolName = dataReader.GetString(2);
                                }
                                if (!dataReader.IsDBNull(3))
                                {
                                    toolModel.ToolDescription = dataReader.GetString(3);
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
            catch (Exception ex) { return null; }
        }

        public async Task<IEnumerable<TrayModelManage>> GetAllTrayList(string machineCode)
        {
            try
            {
                var trayList = new List<TrayModelManage>();
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"GetTrayStockForMachine";
                    MySqlParameter prm = CreateInputParameterForSQL(cmd, "pMachineCode", MySqlDbType.VarChar, machineCode);
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
                                    trayModel.ToolCode = dataReader.GetString(2);
                                }
                                if (!dataReader.IsDBNull(3))
                                {
                                    trayModel.QtyStock = dataReader.GetInt32(3);
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
            catch (Exception ex) { return null; }
        }

        

        public async Task<IEnumerable<TrayModelManage>> GetTrayListByValue(string machineCode, string searchValue)
        {
            try
            {
                var trayList = new List<TrayModelManage>();
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"SearchTrayStockForMachine";
                    MySqlParameter prm = CreateInputParameterForSQL(cmd, "pMachineCode", MySqlDbType.VarChar, machineCode);
                    cmd.Parameters.Add(prm);
                    MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "pSearchValue", MySqlDbType.VarChar, searchValue);
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
                                    trayModel.ToolCode = dataReader.GetString(2);
                                }
                                if (!dataReader.IsDBNull(2))
                                {
                                    trayModel.QtyStock = dataReader.GetInt32(3);
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
            catch (Exception ex) { return null; }   
        }

        public async Task<bool> UpdateStockQuantity(int trayID, string toolCode, int newQty)
        {
            try
            {
                bool result = false;
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"UpdateStockQuantity";
                    MySqlParameter prm = CreateInputParameterForSQL(cmd, "trayID", MySqlDbType.Int32, trayID);
                    cmd.Parameters.Add(prm);
                    MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "newQty", MySqlDbType.Int32, newQty);
                    cmd.Parameters.Add(prm2);
                    result = await CmdExecutionProcedureAsync(cmd);
                    await connection.CloseAsync();
                }
                return result;
            }
            catch (Exception ex) { return false; }
        }


        public async Task<bool> UpdateTransaction(string companyCode,string machineCode, string userID, string toolCode, string trayIndex, int qtyExchange, string typeTransaction, string  transactionStatus )
        {
            try
            {
                bool result = false;
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"UpdateTransaction";
                    MySqlParameter prm = CreateInputParameterForSQL(cmd, "pCompanyCode", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm);
                    MySqlParameter prm1 = CreateInputParameterForSQL(cmd, "pMachineCode", MySqlDbType.VarChar, machineCode);
                    cmd.Parameters.Add(prm1);
                    MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "pUserLogin", MySqlDbType.VarChar, userID);
                    cmd.Parameters.Add(prm2);
                    MySqlParameter prm3 = CreateInputParameterForSQL(cmd, "pToolCode", MySqlDbType.VarChar, toolCode);
                    cmd.Parameters.Add(prm3);
                    MySqlParameter prm4 = CreateInputParameterForSQL(cmd, "pTrayIndex", MySqlDbType.VarChar, trayIndex);
                    cmd.Parameters.Add(prm4);
                    MySqlParameter prm5 = CreateInputParameterForSQL(cmd, "pQuantity", MySqlDbType.Int32, qtyExchange);
                    cmd.Parameters.Add(prm5);
                    MySqlParameter prm6 = CreateInputParameterForSQL(cmd, "pTransactioStatus", MySqlDbType.VarChar, transactionStatus);
                    cmd.Parameters.Add(prm6);
                    MySqlParameter prm7 = CreateInputParameterForSQL(cmd, "pTransactionType", MySqlDbType.VarChar, typeTransaction);
                    cmd.Parameters.Add(prm7);
                    result = await CmdExecutionProcedureAsync(cmd);
                    await connection.CloseAsync();
                }
                return result;
            }
            catch(Exception ex) { return false; }
        }

        public async Task<bool> AddNewToolToTray(string machineCode, string toolCode, string trayIndex, int quantity)
        {
            try
            {
                bool result = false;
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"AddNewToolToTray";
                    MySqlParameter prm = CreateInputParameterForSQL(cmd, "pMachineCode", MySqlDbType.VarChar, machineCode);
                    cmd.Parameters.Add(prm);
                    MySqlParameter prm1 = CreateInputParameterForSQL(cmd, "pToolCode", MySqlDbType.VarChar, toolCode);
                    cmd.Parameters.Add(prm1);
                    MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "pTrayIndex", MySqlDbType.VarChar, trayIndex);
                    cmd.Parameters.Add(prm2);
                    MySqlParameter prm3 = CreateInputParameterForSQL(cmd, "pQuantity", MySqlDbType.Int32, quantity);
                    cmd.Parameters.Add(prm3);
                    result = await CmdExecutionProcedureAsync(cmd);
                    await connection.CloseAsync();
                }
                return result;
            }
            catch (Exception ex) { return false; }
        }
    }
}
