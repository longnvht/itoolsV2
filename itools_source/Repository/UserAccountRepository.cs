using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Repository
{
    public class UserAccountRepository : IUserAccountRepository
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(UserAccountRepository).Name);

        public Task AddUserAccount(UserAccount userAccount)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateUserAccount(UserAccount userAccount)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteUserAccount(UserAccount userAccount)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<UserAccount>> GetAllUserAccount()
        {
            throw new System.NotImplementedException();
        }

        public async Task<int?> GetById(string strUserName, string strPassword)
        {
            int? iID = null;
            string strQueryProcedure = @"GetByID";
            _log.Info("Store procedure query get by id: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>();
                lstPar.Add(
                    new MySqlParameter
                    {
                        ParameterName = "@p_UserLogin",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strUserName,
                        Direction = System.Data.ParameterDirection.Input
                    });
                lstPar.Add(
                    new MySqlParameter
                    {
                        ParameterName = "@p_Pass",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strPassword,
                        Direction = System.Data.ParameterDirection.Input
                    });

                foreach (var item in lstPar)
                {
                    if (item.Value == DBNull.Value)
                    {
                        return null;
                    }
                }

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (!mySqlDataReader.IsDBNull(0)) // ID
                            {
                                iID = mySqlDataReader.GetInt32(0);
                            }
                            mySqlDataReader.Close();
                        }
                    }
                    mySqlConnection.Close();
                }
                return iID;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public Task<IEnumerable<UserAccount>> GetByValue()
        {
            throw new System.NotImplementedException();
        }

        public async Task<UserAccount> GetUserAccount(string strUserName, string strPassword)
        {
            UserAccount userAccount = null;
            string strQueryProcedure = @"GetUserAccount";
            _log.Info("Store procedure query get user account: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>();
                lstPar.Add(
                    new MySqlParameter
                    {
                        ParameterName = "@p_UserLogin",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strUserName,
                        Direction = System.Data.ParameterDirection.Input
                    });
                lstPar.Add(
                    new MySqlParameter
                    {
                        ParameterName = "@p_Pass",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strPassword,
                        Direction = System.Data.ParameterDirection.Input
                    });

                foreach (var item in lstPar)
                {
                    if (item.Value == DBNull.Value)
                    {
                        return null;
                    }
                }

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (userAccount == null)
                            {
                                userAccount = new UserAccount();
                            }

                            if (!mySqlDataReader.IsDBNull(0)) // ID
                            {
                                userAccount.iID = mySqlDataReader.GetInt32(0);
                            }

                            if (!mySqlDataReader.IsDBNull(1)) // UserLogin
                            {
                                userAccount.strUserLogin = mySqlDataReader.GetString(1);
                            }

                            if (!mySqlDataReader.IsDBNull(2)) // Pass
                            {
                                userAccount.strPass = mySqlDataReader.GetString(2);
                            }

                            if (!mySqlDataReader.IsDBNull(3)) // NameStaff
                            {
                                userAccount.strNameStaff = mySqlDataReader.GetString(3);
                            }

                            if (!mySqlDataReader.IsDBNull(4)) // Permission
                            {
                                userAccount.strPermission = mySqlDataReader.GetString(4);
                            }
                            mySqlDataReader.Close();
                        }
                    }
                    mySqlConnection.Close();
                }
                return userAccount;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return null;
            }
        }
    }
}
