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

        public async Task<bool> AddNewToolMachineTray(ToolMachineTray toolMachineTray)
        {
            if (toolMachineTray == null)
            {
                _log.Info("Parameter toolMachineTray is Null!");
                return false;
            }

            string strCmdProcedure = @"UpdateTrayQuantityToolCode";
            _log.Info("Store procedure update tool machine tray: " + strCmdProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter{
                        ParameterName = "@p_TrayIndex",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = toolMachineTray.strTrayIndex,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_MachineCode",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = toolMachineTray.strMachineCode,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_ToolCode",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = toolMachineTray.strToolCode,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter{
                        ParameterName = "@p_Quantity",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = toolMachineTray.iQuantity,
                        Direction = System.Data.ParameterDirection.Input
                    },
                     new MySqlParameter{
                        ParameterName = "@p_UpdateDate",
                        MySqlDbType = MySqlDbType.VarChar,
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

        public async Task<bool> AddWorkingTransaction(WorkingTransaction workingTransaction)
        {
            if (workingTransaction == null)
            {
                _log.Info("Parameter workingTransaction is Null!");
                return false;
            }

            string strCmdProcedure = @"AddWorkingTransaction";
            _log.Info("Store procedure update tool machine tray: " + strCmdProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter{
                        ParameterName = "@p_TransactionDate",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = workingTransaction.dtTransactionDate,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_MachineCode",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = workingTransaction.strMachineCode,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_CompanyCode",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = workingTransaction.strCompanyCode,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter{
                        ParameterName = "@p_UserLogin",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = workingTransaction.strUserLogin,
                        Direction = System.Data.ParameterDirection.Input
                    },
                     new MySqlParameter{
                        ParameterName = "@p_JobNumber",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = workingTransaction.strJobNumber,
                        Direction = System.Data.ParameterDirection.Input
                    },
                     new MySqlParameter{
                        ParameterName = "@p_OPNumber",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = workingTransaction.strOPNumber,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_ToolCode",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = workingTransaction.strToolCode,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_TrayIndex",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = workingTransaction.strTrayIndex,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter{
                        ParameterName = "@p_Quantity",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = workingTransaction.iQuantity,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter{
                        ParameterName = "@p_TransactionStatus",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = workingTransaction.strTransactionStatus,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter{
                        ParameterName = "@p_TransactionType",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = workingTransaction.strTransactiomType,
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
                        _log.Info("Add WorkingTransaction Susccessfully!");
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

        public async Task<ToolMachineTray> GetToolByTrayIndex(string strTrayIndex, string strMachineCode)
        {
            if (string.IsNullOrEmpty(strTrayIndex) || string.IsNullOrEmpty(strMachineCode))
            {
                _log.Info("TrayIndex or MachineCode is Null!");
                return null;
            }

            ToolMachineTray toolsMachineTray = null;
            string strQueryProcedure = @"GetToolByTrayIndex";
            _log.Info("Store procedure query get Tool Tray by TrayIndex in table ToolsMachineTray: " + strQueryProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_TrayIndex",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strTrayIndex,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_MachineCode",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strMachineCode,
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
                                    toolsMachineTray.strMachineCode = mySqlDataReader.GetString(1);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(2))
                                {
                                    toolsMachineTray.strToolCode = mySqlDataReader.GetString(2);
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

        public async Task<IEnumerable<string>> GetToolCodeList()
        {
            var toolCodeList = new List<string>();
            string strQueryProcedure = @"GetToolCodeList";
            _log.Info("Store procedure query get ToolCode in table Tools: " + strQueryProcedure);

            try
            {
                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (var mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, mySqlConnection))
                    {
                        if (toolCodeList == null)
                        {
                            _log.Error("List ToolCode is Null!");
                            return null;
                        }

                        string strToolCode = string.Empty;
                        while (await mySqlDataReader.ReadAsync())
                        {
                            if (!await mySqlDataReader.IsDBNullAsync(0))
                            {
                                strToolCode = mySqlDataReader.GetString(0);
                                toolCodeList.Add(strToolCode);
                            }
                        }

                        mySqlDataReader.Close();
                    }
                    await mySqlConnection.CloseAsync();
                }
                return toolCodeList;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public async Task<int> GetToolQuantity(string strTrayIndex)
        {
            if (string.IsNullOrEmpty(strTrayIndex))
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
                        ParameterName = "@p_TrayIndex",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strTrayIndex,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await  MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader.Read())
                        {
                            if (!mySqlDataReader.IsDBNull(0))
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

        public async Task<bool> IsToolInMachineTray(string strTrayIndex, string strMachineCode)
        {
            string strQueryProcedure = @"GetExistsToolCodeMachineTray";
            _log.Info("Store procedure query check Tool is in table ToolsMachineTray: " + strQueryProcedure);
            bool bResult = false;

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_TrayIndex",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strTrayIndex,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_MachineCode",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strMachineCode,
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

        public async Task<bool> UpdateToolMachineTray(ToolMachineTray toolMachineTray)
        {
            string strCmdProcedure = @"UpdateQuantityToolTray";
            _log.Info("Store procedure update tool quantity to table ToolsMachineTray: " + strCmdProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_Quantity",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = toolMachineTray.iQuantity,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_ToolCode",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = toolMachineTray.strToolCode,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_TrayIndex",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = toolMachineTray.strTrayIndex,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_MachineCode",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = toolMachineTray.strMachineCode,
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

        public async Task<bool> AddToolMachineTray(ToolMachineTray toolMachineTray)
        {
            string strCmdProcedure = @"AddToolMachineTray";
            _log.Info("Add tool to table ToolsMachineTray: " + strCmdProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_ToolsMachineTrayID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = toolMachineTray.iToolsMachineTrayId,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_MachineCode",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = toolMachineTray.strMachineCode,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_ToolCode",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = toolMachineTray.strToolCode,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_TrayIndex",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = toolMachineTray.strTrayIndex,
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
                        ParameterName = "@p_CreatedDate",
                        MySqlDbType = MySqlDbType.Timestamp,
                        Value = toolMachineTray.dtCreateDate,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_UpdatedDate",
                        MySqlDbType = MySqlDbType.Timestamp,
                        Value = toolMachineTray.dtUpdateDate,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                if (lstPar[0].Value == null)
                {
                    _log.Info("ToolMachineTrayID is NULL!");
                    return false;
                }

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
                }

                if (bResult == true)
                {
                    _log.Info("Add ToolMachineTray Successfully.");
                }
                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }

        public async Task<int?> GetTheLargestToolMachineTray()
        {
            string strQueryProcedure = @"SELECT MAX(ToolsMachineTrayID) FROM toolsmachinetray";
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

        public async Task<SortedDictionary<string, string>> GetTrayAndToolCode(string strMachine)
        {
            SortedDictionary<string, string> sortTrayToolCode = null;
            string strQueryProcedure = @"GetTrayToolIDAndCode";
            _log.Info("Store procedure query get TrayIndex and ToolCode by MachineCode in table ToolsMachineTray: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>();
                lstPar.Add(
                    new MySqlParameter
                    {
                        ParameterName = "@p_MachineCode",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strMachine,
                        Direction = System.Data.ParameterDirection.Input
                    });

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (sortTrayToolCode == null)
                            {
                                sortTrayToolCode = new SortedDictionary<string, string>();
                            }

                            while (await mySqlDataReader.ReadAsync())
                            {
                                if (!await mySqlDataReader.IsDBNullAsync(0) && !await mySqlDataReader.IsDBNullAsync(1))
                                {
                                    sortTrayToolCode.Add(mySqlDataReader.GetString(0), mySqlDataReader.GetString(1));
                                }
                            }
                        }

                        mySqlDataReader.Close();
                    }
                    await mySqlConnection.CloseAsync();
                }

                return sortTrayToolCode;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return sortTrayToolCode;
        }

        public async Task<int?> GetToolIDByToolCode(string strToolCode)
        {
            int? iToolID = null;
            string strQueryProcedure = @"GetToolIDInTools";
            _log.Info("Store procedure query get ToolID by ToolCode in table Tools: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>();
                lstPar.Add(
                    new MySqlParameter
                    {
                        ParameterName = "@p_ToolCode",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strToolCode,
                        Direction = System.Data.ParameterDirection.Input
                    });

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
                                    iToolID = mySqlDataReader.GetInt32(0);
                                }
                            }
                        }

                        mySqlDataReader.Close();
                    }
                    await mySqlConnection.CloseAsync();
                }

                return iToolID;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return iToolID;
        }

        public async Task<int?> GetQuantityByToolID(int? iToolID)
        {
            int? iQuantity = null;
            string strQueryProcedure = @"GetQuantityInStock";
            _log.Info("Store procedure query get Quantity by ToolID in table Stock: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>();
                lstPar.Add(
                    new MySqlParameter
                    {
                        ParameterName = "@p_ToolID",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = iToolID,
                        Direction = System.Data.ParameterDirection.Input
                    });

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
                                    iQuantity = mySqlDataReader.GetInt32(0);
                                }
                            }
                        }

                        mySqlDataReader.Close();
                    }
                    await mySqlConnection.CloseAsync();
                }

                return iQuantity;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return iQuantity;
        }

        public async Task<bool> UpdateQuantityStock(int? iToolID = null, int? iQuantity = null)
        {
            string strQueryProcedure = @"UpdateQuantityInStock";
            _log.Info("Store procedure update Quantity by ToolID in Stock: " + strQueryProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter{
                        ParameterName = "@p_ToolID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = iToolID,
                        Direction = System.Data.ParameterDirection.Input
                    },
                     new MySqlParameter{
                        ParameterName = "@p_Quantity",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = iQuantity,
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
                    bResult = await MySqlConnect.CmdExecutionProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection);
                    await mySqlConnection.CloseAsync();

                    if (bResult == true)
                    {
                        _log.Info("Update Quantity in stock Susccessfully!");
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
    }
}
