using Google.Protobuf.WellKnownTypes;
using itools_source.Models;
using itools_source.Models.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using static VinamiToolUser.Utils.MySqlConnect;

namespace VinamiToolUser.Repository
{
    public class GetToolRepository : IGetToolRepository
    {
        public async Task<IEnumerable<ToolModel>> GetToolList(string companyCode)
        {
            var toolList = new List<ToolModel>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"GetToolList";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "@pCompanyCode", MySqlDbType.String, companyCode);
                cmd.Parameters.Add(prm);
                using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                {
                    if (dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            var toolModel = new ToolModel();
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
        }

        public async Task<IEnumerable<TrayModel>> GetCurrentTrayList(string toolCode, string machineCode)
        {
            var trayList = new List<TrayModel>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"GetTrayStockForTool";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "@pToolCode", MySqlDbType.VarChar, toolCode);
                cmd.Parameters.Add(prm);
                MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "@pMachineCode", MySqlDbType.VarChar, machineCode);
                cmd.Parameters.Add(prm2);
                using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                {
                    if (dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            var trayModel = new TrayModel();
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
                                trayModel.QtyStock = dataReader.GetInt32(2);
                            }
                            if (!dataReader.IsDBNull(3))
                            {
                                trayModel.MachineCode = dataReader.GetString(3);
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

        public async Task<IEnumerable<TrayModel>> GetOtherTrayList(string toolCode, string machineCode)
        {
            var trayList = new List<TrayModel>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"GetOtherTrayStockForTool";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "@pToolCode", MySqlDbType.VarChar, toolCode);
                cmd.Parameters.Add(prm);
                MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "@pMachineCode", MySqlDbType.VarChar, machineCode);
                cmd.Parameters.Add(prm2);
                using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                {
                    if (dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            var trayModel = new TrayModel();
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
                                trayModel.QtyStock = dataReader.GetInt32(2);
                            }
                            if (!dataReader.IsDBNull(3))
                            {
                                trayModel.MachineCode = dataReader.GetString(3);
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

        public async Task<IEnumerable<TrayModel>> GetAllTrayList()
        {
            var trayList = new List<TrayModel>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"GetTrayStockAll";
                //MySqlParameter prm = CreateInputParameterForSQL(cmd, "@OPID", MySqlDbType.String, value);
                //cmd.Parameters.Add(prm);
                using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                {
                    if (dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            var trayModel = new TrayModel();
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
                                trayModel.QtyStock = dataReader.GetInt32(2);
                            }
                            if (!dataReader.IsDBNull(3))
                            {
                                trayModel.MachineCode = dataReader.GetString(3);
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

        public async Task<IEnumerable<ToolModel>> GetToolListByToolCode(string companyCode, string searchValue)
        {
            var toolList = new List<ToolModel>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"SearchToolCode";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "@pCompanyCode", MySqlDbType.String, companyCode);
                cmd.Parameters.Add(prm);
                MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "@pSearchValue", MySqlDbType.String, searchValue);
                cmd.Parameters.Add(prm2);
                using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                {
                    if (dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            var toolModel = new ToolModel();
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
        }

        public async Task<bool> UpdateToolStock(int trayID, int toolID, int newQty)
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

        public async Task<bool> UpdateGetToolTransaction(int machineID, string userID, string opNumber, string jobNumber, int toolID, string trayIndex, int qtyExchange, string typeTransaction, string transactionStatus)
        {
            bool result = false;
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"UpdateGetToolTransaction";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "machineID", MySqlDbType.Int32, machineID);
                cmd.Parameters.Add(prm);
                MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "userLogin", MySqlDbType.VarChar, userID);
                cmd.Parameters.Add(prm2);
                MySqlParameter prm3 = CreateInputParameterForSQL(cmd, "toolID", MySqlDbType.Int32, toolID);
                cmd.Parameters.Add(prm3);
                MySqlParameter prm4 = CreateInputParameterForSQL(cmd, "opNumber", MySqlDbType.VarChar, opNumber);
                cmd.Parameters.Add(prm4);
                MySqlParameter prm5 = CreateInputParameterForSQL(cmd, "jobNumber", MySqlDbType.Int32, jobNumber);
                cmd.Parameters.Add(prm5);
                MySqlParameter prm6 = CreateInputParameterForSQL(cmd, "trayIndex", MySqlDbType.VarChar, trayIndex);
                cmd.Parameters.Add(prm6);
                MySqlParameter prm7 = CreateInputParameterForSQL(cmd, "qtyExchange", MySqlDbType.Int32, qtyExchange);
                cmd.Parameters.Add(prm7);
                MySqlParameter prm8 = CreateInputParameterForSQL(cmd, "transactionType", MySqlDbType.VarChar, typeTransaction);
                cmd.Parameters.Add(prm8);
                MySqlParameter prm9 = CreateInputParameterForSQL(cmd, "transactionStatus", MySqlDbType.VarChar, transactionStatus);
                cmd.Parameters.Add(prm9);
                result = await CmdExecutionProcedureAsync(cmd);
                await connection.CloseAsync();
            }
            return result;
        }
    }
}
