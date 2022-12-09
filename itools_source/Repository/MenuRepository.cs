using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Presenters;
using itools_source.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(MenuRepository).Name);

        public async Task<IEnumerable<string>> GetListFormByMenuId(string strMenuId)
        {
            List<string> lstFormId = null;
            string strQueryProcedure = @"GetFormIdByMenuId";
            _log.Info("Get list form by menu id: " + strQueryProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_MenuId",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strMenuId,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            while (await mySqlDataReader.ReadAsync())
                            {
                                if (lstFormId == null)
                                {
                                    lstFormId = new List<string>();
                                }

                                Menu menu = new Menu();
                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    lstFormId.Add(mySqlDataReader.GetString(0));
                                }
                            }
                            mySqlDataReader.Close();
                        }
                        await mySqlConnection.CloseAsync();
                    }
                }

                return lstFormId;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return lstFormId; // null
        }

        public async Task<IEnumerable<Menu>> GetListMenuByUserLogin(string strUserLogin)
        {
            List<Menu> lstMenuByUserLogin = null;
            string strQueryProcedure = @"GetListMenuByUserLogin";
            _log.Info("Get list menu by user login: " + strQueryProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>
                {
                    new MySqlParameter
                    {
                        ParameterName = "@p_UserLogin",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strUserLogin,
                        Direction = System.Data.ParameterDirection.Input
                    }
                };

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            while (await mySqlDataReader.ReadAsync())
                            {
                                if (lstMenuByUserLogin == null)
                                {
                                    lstMenuByUserLogin = new List<Menu>();
                                }

                                Menu menu = new Menu();
                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    menu.strMenuId = mySqlDataReader.GetString(0);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(1))
                                {
                                    menu.strMenuName = mySqlDataReader.GetString(1);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(2))
                                {
                                    menu.strMenuDescription = mySqlDataReader.GetString(2);
                                }
                                lstMenuByUserLogin.Add(menu);
                            }
                            mySqlDataReader.Close();
                        }
                        await mySqlConnection.CloseAsync();
                    }
                }

                return lstMenuByUserLogin;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return lstMenuByUserLogin; // null
        }
    }
}
