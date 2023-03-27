using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Utils;
using itools_source.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace itools_source.Repository
{
    public class MachineRepository : IMachineRepository
    {
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(MachineRepository).Name);

        public async Task<string> GetExsitsSerialMachine(string strSerialMachine)
        {
            if (string.IsNullOrEmpty(strSerialMachine))
            {
                _log.Info("Serial Machine is Null!");
                return null;
            }
            string strSerial = null;
            string strQueryProcedure = @"GetExsitsSerialMachine";
            _log.Info("Store procedure query get Serial by SerialMachine in table Warehousession: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_SerialMachine",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strSerialMachine,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                if (lstPar == null || (lstPar[0].Value == DBNull.Value))
                {
                    return null;
                }

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (await mySqlDataReader.ReadAsync())
                            {
                                if (!await mySqlDataReader.IsDBNullAsync(0)) // Serial
                                {
                                    strSerial = mySqlDataReader.GetString(0);
                                }
                            }
                        }
                        mySqlDataReader.Close();
                    }
                    await mySqlConnection.CloseAsync();
                }
                return strSerial;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return null;
            }
        }
        
        public async Task<IEnumerable<Machine>> GetMachines(int iCompanyId)
        {
            BindingList<Machine> lstMachine = null;
            string strQueryProcedure = @"GetMachineIdAndNameByCompanyId";
            _log.Info("Get list id and name in table machine: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_CompanyID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = iCompanyId,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (lstMachine == null)
                            {
                                lstMachine = new BindingList<Machine>();
                            }

                            Machine machine = null;
                            while (await mySqlDataReader.ReadAsync())
                            {
                                machine = new Machine();

                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    machine.iMachineId = mySqlDataReader.GetInt32(0);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(1))
                                {
                                    machine.strMachineName = mySqlDataReader.GetString(1);
                                }
                                lstMachine.Add(machine);
                            }
                            mySqlDataReader.Close();
                        }
                        await mySqlConnection.CloseAsync();
                    }
                }

                return lstMachine;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }

            return lstMachine;
        }

        public async Task<bool> UpdateSerialMachine(int? strMachineId, string strSerialMachine)
        {
            string strCmdProcedure = @"UpdateSerialMachine";
            _log.Info("Store procedure update tool machine tray: " + strCmdProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_MachineID",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = strMachineId,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_SerialMachine",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strSerialMachine,
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
                        _log.Info("Update ToolCode, Quantity, UpdateDate in ToolMachineTray Successfully!");
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
