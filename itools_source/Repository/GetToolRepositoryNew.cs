using Google.Protobuf.WellKnownTypes;
using itools_source.Models.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using static itools_source.Utils.MySqlConnect;

namespace VinamiToolUser.Repository
{
    public class GetToolRepositoryNew : IGetToolRepositoryNew
    {
        public async Task<IEnumerable<ToolModel>> GetToolList(int opID)
        {
            var toolList = new List<ToolModel>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"GetToolForOP";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "@OPID", MySqlDbType.String, opID);
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

        public async Task<IEnumerable<TrayModel>> GetTrayList(int toolID)
        {
            var trayList = new List<TrayModel>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"GetTrayStockForTool";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "@toolID", MySqlDbType.String, toolID);
                cmd.Parameters.Add(prm);
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
                                trayModel.MachineName = dataReader.GetString(3);
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
                                trayModel.MachineName = dataReader.GetString(3);
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

        public async Task<IEnumerable<ToolModel>> GetToolListByToolCode(int opID, string searchValue)
        {
            var toolList = new List<ToolModel>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"SearchToolForOP";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "@OPID", MySqlDbType.String, opID);
                cmd.Parameters.Add(prm);
                MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "@searchValue", MySqlDbType.String, searchValue);
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
    }
}
