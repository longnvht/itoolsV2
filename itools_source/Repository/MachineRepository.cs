using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Utils;
using log4net;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Repository
{
    public class MachineRepository : IMachineRepository
    {
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(CompanyRepository).Name);

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
                            Machine machine = null;
                            while (await mySqlDataReader.ReadAsync())
                            {
                                if (lstMachine == null)
                                {
                                    lstMachine = new BindingList<Machine>();
                                }
                                machine = new Machine();

                                Menu menu = new Menu();
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
    }
}
