using itools_source.Models.Interface;
using itools_source.Utils;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Repository
{
    public class ToolRepository : IToolRepository
    {
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ToolMachineTrayRepository).Name);

        public async Task<Dictionary<int, string>> GetToolCodeList()
        {
            var lstToolIDAndCode = new Dictionary<int, string>();
            string strQueryProcedure = @"GetToolCodeList";
            _log.Info("Store procedure query get ToolID and ToolCode in table Tools: " + strQueryProcedure);

            try
            {
                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (var mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, mySqlConnection))
                    {
                        if (lstToolIDAndCode == null)
                        {
                            _log.Error("List ToolCode is Null!");
                            return null;
                        }

                        while (await mySqlDataReader.ReadAsync())
                        {
                            if (!await mySqlDataReader.IsDBNullAsync(0) && !await mySqlDataReader.IsDBNullAsync(1))
                            {
                                lstToolIDAndCode.Add(mySqlDataReader.GetInt32(0), mySqlDataReader.GetString(1));
                            }
                        }

                        mySqlDataReader.Close();
                    }
                    await mySqlConnection.CloseAsync();
                }
                return lstToolIDAndCode;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }
    }
}
