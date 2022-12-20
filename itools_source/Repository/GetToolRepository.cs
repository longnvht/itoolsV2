using itools_source.Models.Interface;
using itools_source.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Repository
{
    public class GetToolRepository : IGetToolRepository
    {
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(GetToolRepository).Name);

        public async Task<Dictionary<int, string>> GetByToolForOP(int? iOPId) // Tool and toolforop
        {
            if (iOPId == null)
            {
                _log.Info("OPId is Null.");
                return null;
            }
            // 0. ToolId
            // 1. ToolCode
            Dictionary<int, string> lstToolCodeList = new Dictionary<int, string>();
            string strQueryProcedure = @"GetToolCodeByOPId";
            _log.Info("Store procedure query: " + strQueryProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_OPId",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = iOPId,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                if (lstPar[0].Value == DBNull.Value)
                {
                    return null;
                }

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (lstToolCodeList == null)
                            {
                                _log.Error("Variable lstToolForOPList is Null!");
                                return null;
                            }
                            while (await mySqlDataReader.ReadAsync())
                            {
                                if (!await mySqlDataReader.IsDBNullAsync(0) && !await mySqlDataReader.IsDBNullAsync(1))
                                {
                                    // ToolId, ToolCode
                                    lstToolCodeList.Add(mySqlDataReader.GetInt32(0), mySqlDataReader.GetString(1));
                                }
                            }
                            mySqlDataReader.Close();
                        }
                    }
                    await mySqlConnection.CloseAsync();
                }
                return lstToolCodeList;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public async Task<Dictionary<int, Dictionary<string, string>>> GetModelDescriptionByToolId(int iToolId) // Tool
        {
            // 0. ToolId
            // 1.0. ToolModel
            // 1.1. ToolDescription
            Dictionary<int, Dictionary<string, string>> lstToolModelDes = new Dictionary<int, Dictionary<string, string>>();
            string strQueryProcedure = @"GetModelDescriptionByToolId";
            _log.Info("Store procedure query: " + strQueryProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_ToolId",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = iToolId,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                if (lstPar[0].Value == DBNull.Value)
                {
                    return null;
                }

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (lstToolModelDes == null)
                            {
                                _log.Error("Variable lstToolModelDes is Null!");
                                return null;
                            }
                            Dictionary<string, string> lstModelDes = null;
                            while (await mySqlDataReader.ReadAsync())
                            {
                                lstModelDes = new Dictionary<string, string>();

                                if (!await mySqlDataReader.IsDBNullAsync(1) && !await mySqlDataReader.IsDBNullAsync(2))
                                {
                                    // 1.0. ToolModel, 1.1. ToolDescription
                                    lstModelDes.Add(mySqlDataReader.GetString(1), mySqlDataReader.GetString(2));
                                }
                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    // 0. ToolID
                                    lstToolModelDes.Add(mySqlDataReader.GetInt32(0), lstModelDes);
                                }
                            }
                            mySqlDataReader.Close();
                        }
                    }
                    await mySqlConnection.CloseAsync();
                }
                return lstToolModelDes;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public async Task<Dictionary<int, List<object>>> GetMachineTrayByToolId(int iToolID, int iMachineID) // ToolsMachineTray
        {
            // 0. TrayID
            // 1.0. TrayIndex
            // 1.1. Quantity
            Dictionary<int, List<object>> lstTrayQuantity = new Dictionary<int, List<object>>();
            string strQueryProcedure = @"GetTrayByToolIDAndMachineID";
            _log.Info("Store procedure query get list tray by ToolID and MachineID: " + strQueryProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_ToolID",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = iToolID,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_MachineID",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = iMachineID,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                if (lstPar[0].Value == DBNull.Value)
                {
                    return null;
                }

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (lstTrayQuantity == null)
                            {
                                _log.Error("Variable lstMachineTray is Null!");
                                return null;
                            }

                            List<object> lstMT = null;
                            while (await mySqlDataReader.ReadAsync())
                            {
                                lstMT = new List<object>();

                                // 1.0. TrayIndex
                                if (!await mySqlDataReader.IsDBNullAsync(1))
                                {
                                    lstMT.Add(mySqlDataReader.GetString(1));
                                }

                                // 1.1. MachineCode
                                if (!await mySqlDataReader.IsDBNullAsync(2))
                                {
                                    lstMT.Add(mySqlDataReader.GetInt32(2));
                                }

                                // 0. TrayID
                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    lstTrayQuantity.Add(mySqlDataReader.GetInt32(0), lstMT);
                                }
                            }
                            mySqlDataReader.Close();
                        }
                    }
                    await mySqlConnection.CloseAsync();
                }
                return lstTrayQuantity;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public async Task<Dictionary<int, List<object>>> GetMachineTrayQuantityByToolId(int iToolID) // ToolsMachineTray
        {
            /*
             * 0. TrayID => int
             * 1.0. MachineCode => string
             * 1.1. TrayIndex => string
             * 1.2. Quantity => int
             */
            Dictionary<int, List<object>> lst = new Dictionary<int, List<object>>();
            string strQueryProcedure = @"GetMachineTrayQuantityByToolID";
            _log.Info("Store procedure query: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_ToolID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = iToolID,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                if (lstPar[0].Value == DBNull.Value)
                {
                    return null;
                }

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (lst == null)
                            {
                                _log.Error("Variable lstToolModelDes is Null!");
                                return null;
                            }

                            while (await mySqlDataReader.ReadAsync())
                            {
                                List<object> lstMT = new List<object>();

                                // 1.0. MachineCode
                                if (!await mySqlDataReader.IsDBNullAsync(1))
                                {
                                    lstMT.Add(mySqlDataReader["MachineCode"]);
                                }

                                // 1.1. TrayIndex
                                if (!await mySqlDataReader.IsDBNullAsync(2))
                                {
                                    lstMT.Add(mySqlDataReader["TrayIndex"]);
                                }

                                // 1.2 Quantity
                                if (!await mySqlDataReader.IsDBNullAsync(3))
                                {
                                    lstMT.Add(mySqlDataReader["Quantity"]);
                                }

                                // 0. Id
                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    lst.Add(mySqlDataReader.GetInt32(0), lstMT);
                                }
                            }
                            mySqlDataReader.Close();
                        }
                    }
                    await mySqlConnection.CloseAsync();
                }
                return lst;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return null;
            }
        }
    }
}
