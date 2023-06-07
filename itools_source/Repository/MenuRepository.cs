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
    internal class MenuRepository : IMenuRepository
    {
        public async Task<IEnumerable<MenuModel>> GetAll()
        {
            var viewList = new List<MenuModel>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"Select * from menu where App = 'ITOOLS'";
                //MySqlParameter prm = CreateInputParameterForSQL(cmd, "@p_JobNumber", MySqlDbType.String, "6789");
                //cmd.Parameters.Add(prm);
                using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                {
                    if (dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            var menuModel = new MenuModel();
                            if (!dataReader.IsDBNull(1))
                            {
                                menuModel.MenuName = dataReader.GetString(1);
                            }
                            if (!dataReader.IsDBNull(2))
                            {
                                menuModel.ViewName = dataReader.GetString(2);
                            }
                            if (!dataReader.IsDBNull(4))
                            {
                                menuModel.MenuDescription = dataReader.GetString(4);
                            }
                            if (!dataReader.IsDBNull(5))
                            {
                                menuModel.Icon = dataReader.GetString(5);
                            }
                            viewList.Add(menuModel);
                        }
                    }
                    dataReader.Close();
                }
                connection.Close();
            }
            return viewList;
        }

        public async Task<IEnumerable<MenuModel>> GetByPermission(string permissionID)
        {
            var viewList = new List<MenuModel>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"GetMenuList";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "@permissionID", MySqlDbType.VarChar, permissionID);
                cmd.Parameters.Add(prm);
                using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                {
                    if (dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            var menuModel = new MenuModel();
                            if (!dataReader.IsDBNull(0))
                            {
                                menuModel.MenuName = dataReader.GetString(0);
                            }
                            if (!dataReader.IsDBNull(1))
                            {
                                menuModel.ViewName = dataReader.GetString(1);
                            }
                            if (!dataReader.IsDBNull(2))
                            {
                                menuModel.Icon = dataReader.GetString(2);
                            }
                            if (!dataReader.IsDBNull(3))
                            {
                                menuModel.MenuDescription = dataReader.GetString(3);
                            }
                            
                            viewList.Add(menuModel);
                        }
                    }
                    dataReader.Close();
                }
                connection.Close();
            }
            return viewList;
        }
    }
}
