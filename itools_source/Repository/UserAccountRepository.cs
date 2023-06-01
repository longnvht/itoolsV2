using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VinamiToolUser.Repository
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
            if (string.IsNullOrEmpty(strUserName) || string.IsNullOrEmpty(strPassword))
            {
                _log.Info("UserName or Password is Null!");
                return null;
            }

            int? iID = null;
            string strQueryProcedure = @"GetByID";
            _log.Info("Store procedure query get by id: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_UserLogin",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strUserName,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_Pass",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strPassword,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

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
                            if (await mySqlDataReader.ReadAsync())
                            {
                                if (!await mySqlDataReader.IsDBNullAsync(0)) // ID
                                {
                                    iID = mySqlDataReader.GetInt32(0);
                                }
                            }
                        }
                        mySqlDataReader.Close();
                    }
                    await mySqlConnection.OpenAsync();
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
            if (string.IsNullOrEmpty(strUserName) || string.IsNullOrEmpty(strPassword))
            {
                _log.Info("UserName or Password is Null!");
                return null;
            }

            UserAccount userAccount = null;
            string strQueryProcedure = @"GetUserAccount";
            _log.Info("Store procedure query get user account: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_UserLogin",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strUserName,
                        Direction = System.Data.ParameterDirection.Input
                    },
                    new MySqlParameter
                    {
                        ParameterName = "@p_Pass",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strPassword,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

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

                            if (await mySqlDataReader.ReadAsync())
                            {
                                if (!await mySqlDataReader.IsDBNullAsync(0)) // ID
                                {
                                    userAccount.iID = mySqlDataReader.GetInt32(0);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(1)) // UserLogin
                                {
                                    userAccount.strUserLogin = mySqlDataReader.GetString(1);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(2)) // Pass
                                {
                                    userAccount.strPass = mySqlDataReader.GetString(2);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(3)) // NameStaff
                                {
                                    userAccount.strNameStaff = mySqlDataReader.GetString(3);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(4)) // Permission
                                {
                                    userAccount.strPermissionId = mySqlDataReader.GetString(4);
                                }
                            }
                        }
                        mySqlDataReader.Close();
                    }
                    await mySqlConnection.CloseAsync();
                }
                return userAccount;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return null;
            }
        }

        public async Task<List<string>> GetListFormByUserLogin(string strUserName)
        {
            if (string.IsNullOrEmpty(strUserName))
            {
                _log.Info("UserName is Null!");
                return null;
            }

            List<string> lstForm = null;
            string strQueryProcedure = @"GetListFormByUserLogin";
            _log.Info("Store procedure query get permission a user account: " + strQueryProcedure);

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
                            if (lstForm == null)
                            {
                                lstForm = new List<string>();
                            }

                            while (await mySqlDataReader.ReadAsync())
                            {
                                if (!await mySqlDataReader.IsDBNullAsync(0)) // FormId
                                {
                                    lstForm.Add(mySqlDataReader.GetString(0));
                                }
                            }
                        }
                        mySqlDataReader.Close();
                    }
                    await mySqlConnection.CloseAsync();
                }
                return lstForm;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return null;
            }
        }
    }
}
