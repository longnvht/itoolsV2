using itools_source.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using static itools_source.Utils.MySqlConnect;

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
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "userID", MySqlDbType.Int32, userID);
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
                                toolModel.ToolQuantity = dataReader.GetInt32(3);
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
            var toolList = new List<TempToolModel>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"SearchTempToolForUserID";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "userID", MySqlDbType.Int32, userID);
                cmd.Parameters.Add(prm);
                MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "toolCode", MySqlDbType.Int32, toolCode);
                cmd.Parameters.Add(prm2);
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
                                toolModel.ToolQuantity = dataReader.GetInt32(3);
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
                                trayModel.MachineName = dataReader.GetString(1);
                            }
                            if (!dataReader.IsDBNull(2))
                            {
                                trayModel.TrayName = dataReader.GetString(2);
                            }
                            if (!dataReader.IsDBNull(3))
                            {
                                trayModel.ToolID = dataReader.GetInt32(3);
                            }
                            if (!dataReader.IsDBNull(4))
                            {
                                trayModel.ToolCode = dataReader.GetString(4);
                            }
                            if (!dataReader.IsDBNull(5))
                            {
                                trayModel.QtyStock = dataReader.GetInt32(5);
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

        

        public Task<IEnumerable<TrayModelManage>> GetTrayListByValue(int machineID, string value)
        {
            throw new NotImplementedException();
        }
    }
}
