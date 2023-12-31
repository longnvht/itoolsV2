﻿using itools_source.Models;
using MySql.Data.MySqlClient;
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
    public class SettingRepository : ISettingRepository
    {
        public async Task<IEnumerable<CompanyModel>> GetCompanyList()
        {
            try
            {
                var companyList = new List<CompanyModel>();
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"Select * from company Limit 100";
                    //MySqlParameter prm = CreateInputParameterForSQL(cmd, "@p_JobNumber", MySqlDbType.String, "6789");
                    //cmd.Parameters.Add(prm);
                    using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                    {
                        if (dataReader != null)
                        {
                            while (dataReader.Read())
                            {
                                var companyModel = new CompanyModel();
                                if (!dataReader.IsDBNull(0))
                                {
                                    companyModel.CompanyID = dataReader.GetInt32(0);
                                }
                                if (!dataReader.IsDBNull(1))
                                {
                                    companyModel.CompanyCode = dataReader.GetString(1);
                                }
                                if (!dataReader.IsDBNull(2))
                                {
                                    companyModel.CompanyName = dataReader.GetString(2);
                                }
                                if (!dataReader.IsDBNull(3))
                                {
                                    companyModel.CompanyAddress = dataReader.GetString(3);
                                }
                                if (!dataReader.IsDBNull(4))
                                {
                                    companyModel.CompanyLocation = dataReader.GetString(4);
                                }
                                companyList.Add(companyModel);
                            }
                        }
                        dataReader.Close();
                    }
                    connection.Close();
                }
                return companyList;
            }
            catch (Exception ex) { return null; }
        }


        public async Task<IEnumerable<MachineModel>> GetValidMachine(int companyID)
        {
            try
            {
                var machineList = new List<MachineModel>();
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"GetValidMachine";
                    MySqlParameter prm = CreateInputParameterForSQL(cmd, "companyID", MySqlDbType.Int32, companyID);
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
            catch (Exception ex) { return null; }   
        }

        public async Task<bool> UpdateMachineSerial(string machineCode, string serial)
        {
            try
            {
                bool result = false;
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"UpdateMachineSerial";
                    MySqlParameter prm = CreateInputParameterForSQL(cmd, "pMachineCode", MySqlDbType.VarChar, machineCode);
                    cmd.Parameters.Add(prm);
                    MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "pSerial", MySqlDbType.VarChar, serial);
                    cmd.Parameters.Add(prm2);
                    result = await CmdExecutionProcedureAsync(cmd);
                    await connection.CloseAsync();
                }
                return result;
            }
            catch (Exception ex) { return false; }
        }
    }
}
