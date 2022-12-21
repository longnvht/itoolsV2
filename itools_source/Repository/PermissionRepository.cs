using itools_source.Models.Interface;
using itools_source.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Repository
{
    public class PermissionRepository : IPermissionRepository
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(UserAccountRepository).Name);

        public async Task<string> GetPermissionNameById(string strId)
        {
            if (string.IsNullOrEmpty(strId))
            {
                _log.Info("PermissionId is Null!");
                return null;
            }
            string strPermissionName = null;
            string strQueryProcedure = @"GetPermissionName";
            _log.Info("Store procedure query get permission name by permission id a table Permission: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_PermissionId",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strId,
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
                                if (!await mySqlDataReader.IsDBNullAsync(0)) // PermissionName
                                {
                                    strPermissionName = mySqlDataReader.GetString(0);
                                }
                            }
                        }
                        mySqlDataReader.Close();
                    }
                    await mySqlConnection.CloseAsync();
                }
                return strPermissionName;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return null;
            }
        }
    }
}
