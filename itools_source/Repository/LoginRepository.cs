using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using VinamiToolUser.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;
using static VinamiToolUser.Utils.MySqlConnect;
using System.Data.SqlClient;

namespace VinamiToolUser.Repository
{
    public class LoginRepository : ILoginRepository
    {
        public async Task<IEnumerable<UserAccount>> GetUserAccount(string strUserName, string strPassword)
        {
            try
            {
                var userList = new List<UserAccount>();
                using (MySqlConnection connection = await OpenAsync())
                {
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"GetUserAccount";
                    MySqlParameter prm = CreateInputParameterForSQL(cmd, "@p_UserLogin", MySqlDbType.String, strUserName);
                    cmd.Parameters.Add(prm);
                    MySqlParameter prm2 = CreateInputParameterForSQL(cmd, "@p_Pass", MySqlDbType.String, strPassword);
                    cmd.Parameters.Add(prm2);
                    using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                    {
                        if (dataReader != null)
                        {
                            while (dataReader.Read())
                            {
                                var userAccount = new UserAccount();
                                if (!await dataReader.IsDBNullAsync(0)) // ID
                                {
                                    userAccount.UserID = dataReader.GetInt32(0);
                                }

                                if (!await dataReader.IsDBNullAsync(1)) // UserLogin
                                {
                                    userAccount.UserName = dataReader.GetString(1);
                                }

                                if (!await dataReader.IsDBNullAsync(2)) // NameStaff
                                {
                                    userAccount.FullName = dataReader.GetString(2);
                                }

                                if (!await dataReader.IsDBNullAsync(3)) // Permission
                                {
                                    userAccount.PermisionID = dataReader.GetString(3);
                                }
                                userList.Add(userAccount);
                            }
                        }
                        dataReader.Close();
                    }
                    connection.Close();
                }
                return userList;
            }
            catch (Exception ex) { return null; }
        }
    }
}
