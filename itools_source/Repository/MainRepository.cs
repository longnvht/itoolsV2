using Google.Protobuf.WellKnownTypes;
using itools_source.Models;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using static VinamiToolUser.Utils.MySqlConnect;

namespace VinamiToolUser.Repository
{
    public class MainRepository : IMainRepository
    {
        public async Task<IEnumerable<MachineModel>> GetCurrentMachineInfo(string hddSerial)
        {
            try
            {
                var machineList = new List<MachineModel>();
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"GetCurrentMachine";
                    MySqlParameter prm = CreateInputParameterForSQL(cmd, "@hddSerial", MySqlDbType.VarChar, hddSerial);
                    cmd.Parameters.Add(prm);
                    using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                    {
                        if (dataReader != null)
                        {
                            while (dataReader.Read())
                            {
                                var machineModel = new MachineModel();
                                if (!dataReader.IsDBNull(0))
                                {
                                    machineModel.MachineID = dataReader.GetInt32(0);
                                }
                                if (!dataReader.IsDBNull(1))
                                {
                                    machineModel.MachineName = dataReader.GetString(1);
                                }
                                if (!dataReader.IsDBNull(2))
                                {
                                    machineModel.MachineCode = dataReader.GetString(2);
                                }
                                if (!dataReader.IsDBNull(3))
                                {
                                    machineModel.MachineSerial = dataReader.GetString(3);
                                }
                                if (!dataReader.IsDBNull(4))
                                {
                                    machineModel.CompanyCode = dataReader.GetString(4);
                                }
                                machineList.Add(machineModel);
                            }
                        }
                        dataReader.Close();
                    }
                    connection.Close();
                }
                return machineList;
            }
            catch(Exception ex) { return  null; }
        }

        public async Task<bool> SyncHostToLocal_Assessor(string machineCode, string companyCode)
        {
            try
            {
                bool result = false;
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"SyncHostToLocal_Assessor";
                    MySqlParameter prm1 = CreateInputParameterForSQL(cmd, "MachineCode", MySqlDbType.VarBinary, machineCode);
                    cmd.Parameters.Add(prm1);
                    MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "CompanyCode", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm2);
                    MySqlParameter prm3 = CreateOutParameterForSQL(cmd, "returnResult", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm3);
                    result = await CmdExecutionProcedureAsync(cmd);
                    await connection.CloseAsync();
                }
                return result;
            }
            catch (Exception ex) { return false; }
        }

        public async Task<bool> SyncHostToLocal_Company(string machineCode, string companyCode)
        {
            try
            {
                bool result = false;
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"SyncHostToLocal_Company";
                    MySqlParameter prm1 = CreateInputParameterForSQL(cmd, "MachineCode", MySqlDbType.VarBinary, machineCode);
                    cmd.Parameters.Add(prm1);
                    MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "CompanyCode", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm2);
                    MySqlParameter prm3 = CreateOutParameterForSQL(cmd, "returnResult", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm3);
                    result = await CmdExecutionProcedureAsync(cmd);
                    await connection.CloseAsync();
                }
                return result;
            }
            catch (Exception ex) { return false; }
        }

        public async Task<bool> SyncHostToLocal_CompanyMachine(string machineCode, string companyCode)
        {
            try
            {
                bool result = false;
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"SyncHostToLocal_CompanyMachine";
                    MySqlParameter prm1 = CreateInputParameterForSQL(cmd, "MachineCode", MySqlDbType.VarBinary, machineCode);
                    cmd.Parameters.Add(prm1);
                    MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "CompanyCode", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm2);
                    MySqlParameter prm3 = CreateOutParameterForSQL(cmd, "returnResult", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm3);
                    result = await CmdExecutionProcedureAsync(cmd);
                    await connection.CloseAsync();
                }
                return result;
            }
            catch (Exception ex) { return false; }
        }

        public async Task<bool> SyncHostToLocal_Machine(string machineCode, string companyCode)
        {
            try
            {
                bool result = false;
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"SyncHostToLocal_Machine";
                    MySqlParameter prm1 = CreateInputParameterForSQL(cmd, "MachineCode", MySqlDbType.VarBinary, machineCode);
                    cmd.Parameters.Add(prm1);
                    MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "CompanyCode", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm2);
                    MySqlParameter prm3 = CreateOutParameterForSQL(cmd, "returnResult", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm3);
                    result = await CmdExecutionProcedureAsync(cmd);
                    await connection.CloseAsync();
                }
                return result;
            }
            catch (Exception ex) { return false; }
        }

        public async Task<bool> SyncHostToLocal_RoleAssessor(string machineCode, string companyCode)
        {
            try
            {
                bool result = false;
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"SyncHostToLocal_RoleAssessor";
                    MySqlParameter prm1 = CreateInputParameterForSQL(cmd, "MachineCode", MySqlDbType.VarBinary, machineCode);
                    cmd.Parameters.Add(prm1);
                    MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "CompanyCode", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm2);
                    MySqlParameter prm3 = CreateOutParameterForSQL(cmd, "returnResult", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm3);
                    result = await CmdExecutionProcedureAsync(cmd);
                    await connection.CloseAsync();
                }
                return result;
            }
            catch (Exception ex) { return false; }
        }

        public async Task<bool> SyncHostToLocal_Tools(string machineCode, string companyCode)
        {
            try
            {
                bool result = false;
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"SyncHostToLocal_Tools";
                    MySqlParameter prm1 = CreateInputParameterForSQL(cmd, "MachineCode", MySqlDbType.VarBinary, machineCode);
                    cmd.Parameters.Add(prm1);
                    MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "CompanyCode", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm2);
                    MySqlParameter prm3 = CreateOutParameterForSQL(cmd, "returnResult", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm3);
                    result = await CmdExecutionProcedureAsync(cmd);
                    await connection.CloseAsync();
                }
                return result;
            }
            catch (Exception ex) { return false; }
        }

        public async Task<bool> SyncLocalToHost_ToolsMachineTray(string machineCode, string companyCode)
        {
            try
            {
                bool result = false;
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"SyncLocalToHost_ToolsMachineTray";
                    MySqlParameter prm1 = CreateInputParameterForSQL(cmd, "MachineCode", MySqlDbType.VarBinary, machineCode);
                    cmd.Parameters.Add(prm1);
                    MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "CompanyCode", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm2);
                    MySqlParameter prm3 = CreateOutParameterForSQL(cmd, "returnResult", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm3);
                    result = await CmdExecutionProcedureAsync(cmd);
                    await connection.CloseAsync();
                }
                return result;
            }
            catch (Exception ex) { return false; }
        }

        public async Task<bool> SyncLocalToHost_WorkingTransaction(string machineCode, string companyCode)
        {
            try
            {
                bool result = false;
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"SyncLocalToHost_WorkingTransaction";
                    MySqlParameter prm1 = CreateInputParameterForSQL(cmd, "MachineCode", MySqlDbType.VarBinary, machineCode);
                    cmd.Parameters.Add(prm1);
                    MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "CompanyCode", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm2);
                    MySqlParameter prm3 = CreateOutParameterForSQL(cmd, "returnResult", MySqlDbType.VarChar, companyCode);
                    cmd.Parameters.Add(prm3);
                    result = await CmdExecutionProcedureAsync(cmd);
                    await connection.CloseAsync();
                }
                return result;
            }
            catch (Exception ex) { return false; }
        }
    }
}
