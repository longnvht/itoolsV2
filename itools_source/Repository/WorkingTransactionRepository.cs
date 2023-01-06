using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Repository
{
    public class WorkingTransactionRepository : IWorkingTransactionRepository
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(WorkingTransactionRepository).Name);

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
                        MySqlDbType = MySqlDbType.DateTime,
                        Value = workingTransaction.dtTransactionDate,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_MachineID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = workingTransaction.iMachineId,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_CompanyID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = workingTransaction.iCompanyId,
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
                        ParameterName = "@p_TrayID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = workingTransaction.iTrayId,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter{
                        ParameterName = "@p_Quantity",
                        MySqlDbType = MySqlDbType.Int32,
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

        public bool DeleteWorkingTransaction(WorkingTransaction workingTransaction)
        {
            throw new NotImplementedException();
        }

        public bool UpdateWorkingTransaction(WorkingTransaction workingTransaction)
        {
            throw new NotImplementedException();
        }
    }
}
