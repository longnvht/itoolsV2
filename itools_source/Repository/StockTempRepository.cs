using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Utils;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Repository
{
    public class StockTempRepository : IStockTempRepository
    {
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(StockTempRepository).Name);

        public async Task<bool> AddToolAndQuantity(StockTemp stockTemp)
        {
            string strCmdProcedure = @"AddToolAndQuantity";
            _log.Info("Store procedure create to table StockTemp: " + strCmdProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_ToolID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = stockTemp.iToolId,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter{
                        ParameterName = "@p_UserLogin",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = stockTemp.strUserLogin,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_Quantity",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = stockTemp.iQuantity,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_CreateDate",
                        MySqlDbType = MySqlDbType.DateTime,
                        Value = stockTemp.dtCreateDate,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_UpdateDate",
                        MySqlDbType = MySqlDbType.DateTime,
                        Value = stockTemp.dtUpdateDate,
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
                        _log.Info("Add WorkingTransaction Successfully!");
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

        public async Task<bool> GetExsitsToolInStockTemp(StockTemp stockTemp)
        {
            string strQueryProcedure = @"GetExsitsToolInStockTemp";
            _log.Info("Store procedure query get ToolID have Quantity > 0 By UserLogin in table StockTemp: " + strQueryProcedure);
            bool bResult = false;

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_ToolID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = stockTemp.iToolId,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter{
                        ParameterName = "@p_UserLogin",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = stockTemp.strUserLogin,
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
                                    _log.Info("Tool is exsits!");
                                }
                                else
                                {
                                    bResult = false;
                                    _log.Error("Tool is not exsits!");
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

        public async Task<bool> UpdateQuantityInStockTempAdd(StockTemp stockTemp)
        {
            string strCmdProcedure = @"UpdateQuantityInStockTempAdd";
            _log.Info("Store procedure update quantity to table StockTemp: " + strCmdProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_ToolID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = stockTemp.iToolId,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter{
                        ParameterName = "@p_UserLogin",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = stockTemp.strUserLogin,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_Quantity",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = stockTemp.iQuantity,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_UpdateDate",
                        MySqlDbType = MySqlDbType.DateTime,
                        Value = stockTemp.dtUpdateDate,
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
                    _log.Info("Update Quantity StockTemp Successfully!");
                }

                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }

        public async Task<bool> UpdateQuantityInStockTempTakeOut(StockTemp stockTemp)
        {
            string strCmdProcedure = @"UpdateQuantityInStockTempTakeOut";
            _log.Info("Store procedure update quantity to table StockTemp: " + strCmdProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_ToolID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = stockTemp.iToolId,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter{
                        ParameterName = "@p_UserLogin",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = stockTemp.strUserLogin,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_Quantity",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = stockTemp.iQuantity,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_UpdateDate",
                        MySqlDbType = MySqlDbType.DateTime,
                        Value = stockTemp.dtUpdateDate,
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
                    _log.Info("Update Quantity StockTemp Successfully!");
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
