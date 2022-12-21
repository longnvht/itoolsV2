using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Repository
{
    public class ToolMachineTrayRepository : IToolMachineTrayRepository
    {
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ToolMachineTrayRepository).Name);

        public async Task<bool> UpdateTrayQuantityToolID(ToolMachineTray toolMachineTray)
        {
            if (toolMachineTray == null)
            {
                _log.Info("Parameter toolMachineTray is Null!");
                return false;
            }

            string strCmdProcedure = @"UpdateTrayQuantityToolID";
            _log.Info("Store procedure update tool machine tray: " + strCmdProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_TrayID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = toolMachineTray.iToolsMachineTrayId,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_ToolID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = toolMachineTray.iToolId,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_Quantity",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = toolMachineTray.iQuantity,
                        Direction = System.Data.ParameterDirection.Input
                    },
                     new MySqlParameter
                     {
                        ParameterName = "@p_UpdateDate",
                        MySqlDbType = MySqlDbType.DateTime,
                        Value = toolMachineTray.dtUpdateDate,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                foreach (var parCheck in lstPar)
                {
                    if (parCheck.Value == null)
                    {
                        parCheck.Value = DBNull.Value;
                    }
                }
                bool bResult;
                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    bResult = await MySqlConnect.CmdExecutionProcedureAsync(strCmdProcedure, lstPar.ToArray(), mySqlConnection);
                    await mySqlConnection.CloseAsync();

                    if (bResult == true)
                    {
                        _log.Info("Update ToolCode, Quantity, UpdateDate in ToolMachineTray Susccessfully!");
                    }
                }

                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }

        public async Task<bool> UpdateQuantityToolTray(ToolMachineTray toolMachineTray)
        {
            string strCmdProcedure = @"UpdateQuantityToolTray";
            _log.Info("Store procedure update tool quantity to table ToolsMachineTray: " + strCmdProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_TrayID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = toolMachineTray.iToolsMachineTrayId,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_Quantity",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = toolMachineTray.iQuantity,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_UpdateDate",
                        MySqlDbType = MySqlDbType.DateTime,
                        Value = toolMachineTray.dtUpdateDate,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                bool bResult;
                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    bResult = await MySqlConnect.CmdExecutionProcedureAsync(strCmdProcedure, lstPar.ToArray(), mySqlConnection);
                    await mySqlConnection.CloseAsync();
                }

                if (bResult == true)
                {
                    _log.Info("Add Plugin(Database - Update Quantity to Table ToolsMachineTray) ToolMachineTray Successfully!");
                }

                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }

        public async Task<ToolMachineTray> GetToolMachineTray(int? iTrayID) //
        {
            if (iTrayID == null)
            {
                _log.Info("TrayIndex is Null!");
                return null;
            }

            ToolMachineTray toolsMachineTray = null;
            string strQueryProcedure = @"GetToolsMachineTrayByTrayID";
            _log.Info("Store procedure query get Tool Tray by TrayIndex in table ToolsMachineTray: " + strQueryProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_TrayID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = iTrayID,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (await mySqlDataReader.ReadAsync())
                            {
                                if (toolsMachineTray == null)
                                {
                                    toolsMachineTray = new ToolMachineTray();
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    toolsMachineTray.iToolsMachineTrayId = mySqlDataReader.GetInt32(0);
                                }
                                else
                                {
                                    _log.Info("Id NULL!");
                                    return null;
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(1))
                                {
                                    toolsMachineTray.iMachineId = mySqlDataReader.GetInt32(1);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(2))
                                {
                                    toolsMachineTray.iToolId = mySqlDataReader.GetInt32(2);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(3))
                                {
                                    toolsMachineTray.strTrayIndex = mySqlDataReader.GetString(3);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(4))
                                {
                                    toolsMachineTray.iQuantity = mySqlDataReader.GetInt32(4);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(5))
                                {
                                    toolsMachineTray.dtCreateDate = mySqlDataReader.GetDateTime(5);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(6))
                                {
                                    toolsMachineTray.dtUpdateDate = mySqlDataReader.GetDateTime(6);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(7))
                                {
                                    toolsMachineTray.isActive = mySqlDataReader.GetByte(7);
                                }
                            }
                            mySqlDataReader.Close();
                        }
                        await mySqlConnection.CloseAsync();
                    }
                }

                return toolsMachineTray;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return toolsMachineTray;
        }

        public async Task<int> GetQuantityInTray(int? iTrayID) //
        {
            if (iTrayID == null)
            {
                _log.Info("TrayIndex is Null!");
                return -1;
            }

            string strQueryProcedure = @"GetQuantityInToolTray";
            _log.Info("Store procedure query get quantity in table ToolsMachineTray: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_TrayID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = iTrayID,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (await mySqlDataReader.ReadAsync())
                        {
                            if (!await mySqlDataReader.IsDBNullAsync(0))
                            {
                                return mySqlDataReader.GetInt32(0);
                            }
                            else
                            {
                                _log.Info("Quantity Empty!");
                                return -2;
                            }
                        }

                        mySqlDataReader.Close();
                    }
                    await mySqlConnection.CloseAsync();
                }

                return -3;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return -4;
        }

        public async Task<bool> IsToolInMachineTray(int? iTrayId, int? iToolId)
        {
            if ((iTrayId == null) || (iToolId == null))
            {
                _log.Error("TrayID and MachineID, ToolId is null!");
                return false;
            }

            string strQueryProcedure = @"GetExistsToolCodeMachineTray";
            _log.Info("Store procedure query check Tool is in table ToolsMachineTray: " + strQueryProcedure);
            bool bResult = false;

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_TrayID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = iTrayId,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_ToolID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = iToolId,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (await mySqlDataReader.ReadAsync())
                            {
                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    bResult = true;
                                    _log.Info("Tool is Machine and Tray!");
                                }
                                else
                                {
                                    bResult = false;
                                    _log.Error("Tool is not Machine and Tray!");
                                }
                            }
                        }
                        mySqlDataReader.Close();
                    }
                    await mySqlConnection.CloseAsync();
                }
                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return bResult;
            }
        }

        public async Task<int?> GetTheLargestToolMachineTray()
        {
            string strQueryProcedure = @"GetTheLargestToolMachineTray";
            _log.Info("Get query the largest ID in ToolsMachineTray: " + strQueryProcedure);

            int? iLargestId = null;
            try
            {
                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (var mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, mySqlConnection))
                    {
                        if (await mySqlDataReader.ReadAsync())
                        {
                            if (!await mySqlDataReader.IsDBNullAsync(0))
                            {
                                iLargestId = Convert.ToInt32(mySqlDataReader.GetString(0));
                            }
                            else
                            {
                                _log.Info("ToolCode is NULL!");
                            }
                        }
                        mySqlDataReader.Close();

                        if (iLargestId is null)
                        {
                            _log.Error("List ToolCode is Null!");
                            return null;
                        }
                    }
                    await mySqlConnection.CloseAsync();
                    return iLargestId;
                }
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return iLargestId;
            }
        }

        public async Task<Dictionary<int, Dictionary<string, string>>> GetTrayIndexAndToolCode(int? iMachineId) //
        {
            if (iMachineId == null)
            {
                _log.Error("MachineId is Null!");
                return null;
            }

            Dictionary<int, Dictionary<string, string>> lstTrayIdIndexToolCode = null;
            string strQueryProcedure = @"GetTrayToolIDAndCode";
            _log.Info("Store procedure query get TrayIndex and ToolCode by MachineID in table ToolsMachineTray: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_MachineID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = iMachineId,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (lstTrayIdIndexToolCode == null)
                            {
                                lstTrayIdIndexToolCode = new Dictionary<int, Dictionary<string, string>>();
                            }

                            Dictionary<string, string> lstTrayIndexAndToolCode = null;
                            while (await mySqlDataReader.ReadAsync())
                            {
                                lstTrayIndexAndToolCode = new Dictionary<string, string>();
                                if (!await mySqlDataReader.IsDBNullAsync(1) && !await mySqlDataReader.IsDBNullAsync(2))
                                {
                                    lstTrayIndexAndToolCode.Add(mySqlDataReader.GetString(1), mySqlDataReader.GetString(2));
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    lstTrayIdIndexToolCode.Add(mySqlDataReader.GetInt32(0), lstTrayIndexAndToolCode);
                                }
                            }
                        }

                        mySqlDataReader.Close();
                    }
                    await mySqlConnection.CloseAsync();
                }

                return lstTrayIdIndexToolCode;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return lstTrayIdIndexToolCode;
        }

        public async Task<int?> GetToolIDByTrayID(int? iTrayID) // Tray
        {
            int? iToolId = null;
            string strQueryProcedure = @"GetToolIDByTrayID";
            _log.Info("Store procedure query get ToolID in table ToolsMachineTray: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_TrayID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = iTrayID,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (await mySqlDataReader.ReadAsync())
                            {
                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    iToolId = mySqlDataReader.GetInt32(0);
                                }
                            }
                        }

                        mySqlDataReader.Close();
                    }
                    await mySqlConnection.CloseAsync();
                }

                return iToolId;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return iToolId;
        }
    }
}
