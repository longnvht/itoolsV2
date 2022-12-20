using Guna.UI2.WinForms;
using itools_source.Models.Interface;
using itools_source.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source.Repository
{
    public class JobRepository : IJobRepository
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(JobRepository).Name);

        public async Task<SortedList<string, string>> GetJobByJobNumber(string strJobNumber)
        {
            SortedList<string, string> lstJobNumberList = new SortedList<string, string>();
            string strQueryProcedure = @"GetJobByJobNumber";
            _log.Info("Store procedure query get job by jobnumber: " + strQueryProcedure);

            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>();
                lstPar.Add(
                    new MySqlParameter
                    {
                        ParameterName = "@p_JobNumber",
                        MySqlDbType = MySqlDbType.VarChar,
                        Value = strJobNumber,
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
                            if (lstJobNumberList == null)
                            {
                                _log.Error("Variable lstJobNumberList is Null!");
                                return null;
                            }
                            while (await mySqlDataReader.ReadAsync())
                            {
                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    lstJobNumberList.Add(mySqlDataReader.GetString(0), mySqlDataReader.GetString(1));
                                }
                            }
                        }
                        mySqlDataReader.Close();
                    }
                    mySqlConnection.Close();
                }
                return lstJobNumberList;
            }
            catch (MySqlException e)
            {

                _log.Error(e.Message);
                return null;
            }
        }

        public async Task<Dictionary<int?, Dictionary<string, string>>> GetOPByJobPartOPID(string strJobNumber, int? iPartID)
        {
            Dictionary<int?, Dictionary<string, string>> lstOPList = null;
            
            string strQueryProcedure = @"GetOPByJobPartOPID";

            _log.Info("Store procedure query: " + strQueryProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>();
                lstPar.Add(
                new MySqlParameter
                {
                    ParameterName = "@p_JobNumber",
                    MySqlDbType = MySqlDbType.VarChar,
                    Value = strJobNumber,
                    Direction = System.Data.ParameterDirection.Input
                });
                lstPar.Add(
                new MySqlParameter
                {
                    ParameterName = "@p_PartID",
                    MySqlDbType = MySqlDbType.Int32,
                    Value = iPartID,
                    Direction = System.Data.ParameterDirection.Input
                });

                if (lstPar == null)
                {
                    return null;
                }

                if (lstPar[0].Value == DBNull.Value)
                {
                    return null;
                }
                foreach (var parCheck in lstPar)
                {
                    if (parCheck.Value == DBNull.Value)
                    {
                        parCheck.Value = DBNull.Value;
                    }
                }

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (lstOPList == null)
                            {
                                lstOPList = new Dictionary<int?, Dictionary<string, string>>();
                            }

                            Dictionary<string, string> lstOPNumberOPType = null;
                            while (await mySqlDataReader.ReadAsync())
                            {
                                lstOPNumberOPType = new Dictionary<string, string>();
                                if (!await mySqlDataReader.IsDBNullAsync(1) && !await mySqlDataReader.IsDBNullAsync(2))
                                {
                                    lstOPNumberOPType.Add(mySqlDataReader.GetString(1), mySqlDataReader.GetString(2));
                                    //MessageDialog.Show("OPNumber: " + lstOPNumberOPType.Keys.ElementAt(0) +
                                    //    "\nOPType: " + lstOPNumberOPType.Values.ElementAt(0));
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    lstOPList.Add(mySqlDataReader.GetInt32(0), lstOPNumberOPType);
                                }
                            }
                            mySqlDataReader.Close();
                        }
                    }
                    mySqlConnection.Close();
                }
                return lstOPList;
            }
            catch (MySqlException e)
            {

                _log.Error(e.Message);
                return null;
            }
        }
    }
}
