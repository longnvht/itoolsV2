using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Repository
{
    public class GetToolRepository : IGetToolRepository
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(GetToolRepository).Name);

        public IEnumerable<Job> GetAllJobs()
        {
            throw new NotImplementedException();
        }

        public Job GetJobs()
        {
            throw new NotImplementedException();
        }

        public SortedList<string, string> GetJobByJobNumber(string strJobNumber)
        {
            SortedList<string, string> lstJobNumberList = new SortedList<string, string>();
            string strQuery = @"SELECT longnv.job.JobNumber, longnv.job.PartID
	                                FROM longnv.job	
		                                WHERE longnv.job.JobNumber LIKE '%" + strJobNumber + "%'" +
			                                " LIMIT 50";
            _log.Info(strQuery);
            try
            {
                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    using (MySqlDataReader mySqlDataReader = MySqlConnect.DataQuery(strQuery, mySqlConnection))
                    {
                        if (lstJobNumberList == null)
                        {
                            _log.Error("Variable lstJobNumberList is Null!");
                            return null;
                        }
                        while (mySqlDataReader.Read())
                        {
                            if (!mySqlDataReader.IsDBNull(0))
                            {
                                lstJobNumberList.Add(mySqlDataReader.GetString(0), mySqlDataReader.GetString(1));
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

        public Dictionary<string, Dictionary<string, string>> GetOPByJobPartOPID(string strJobNumber, string strPartID)
        {
            Dictionary<string, Dictionary<string, string>> lstOPList = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> lstOPNumberOPType = new Dictionary<string, string>();
            string strQueryProcedure = @"GetOPByJobPartOPID";

            _log.Info("Store procedure query: " + strQueryProcedure);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>();
                lstPar.Add(new MySqlParameter("@p_JobNumber", strJobNumber));
                lstPar.Add(new MySqlParameter("@p_PartID", strPartID));
                //lstPar.Add(
                //new MySqlParameter
                //{
                //    ParameterName = "@p_JobNumber",
                //    MySqlDbType = MySqlDbType.VarChar,
                //    Value = strJobNumber,
                //    Direction = System.Data.ParameterDirection.Input
                //});
                //lstPar.Add(
                //new MySqlParameter
                //{
                //    ParameterName = "@p_PartID",
                //    MySqlDbType = MySqlDbType.Int32,
                //    Value = strPartID,
                //    Direction = System.Data.ParameterDirection.Input
                //});

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

                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    using (MySqlDataReader mySqlDataReader = MySqlConnect.DataQueryProcedure(strQueryProcedure, lstPar.ToArray(), mySqlConnection))
                    {
                        if (lstOPList == null)
                        {
                            _log.Error("Variable lstOPList is Null!");
                            return null;
                        }
                        if (mySqlDataReader != null)
                        {
                            if (lstOPNumberOPType == null)
                            {
                                _log.Error("Variable lstOPNumberOPType is Null!");
                                return null;
                            }
                            while (mySqlDataReader.Read())
                            {
                                if (!mySqlDataReader.IsDBNull(1) && !mySqlDataReader.IsDBNull(2))
                                {
                                    lstOPNumberOPType.Add(mySqlDataReader.GetString(1), mySqlDataReader.GetString(2));
                                }

                                if (!mySqlDataReader.IsDBNull(0))
                                {
                                    lstOPList.Add(mySqlDataReader.GetString(0), lstOPNumberOPType);
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

        public async Task<Dictionary<int, string>> GetByToolForOP(int iOPId)
        {
            // 0. ToolId
            // 1. ToolCode
            Dictionary<int, string> lstToolCodeList = new Dictionary<int, string>();
            string strQuery = @"GetToolCodeByOPId";
            _log.Info(strQuery);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>();
                lstPar.Add(
                    new MySqlParameter
                    {
                        ParameterName = "@p_OPId",
                        MySqlDbType = MySqlDbType.Int32,
                        Value = iOPId,
                        Direction = System.Data.ParameterDirection.Input
                    });

                if (lstPar[0].Value == DBNull.Value)
                {
                    return null;
                }

                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQuery, lstPar.ToArray(), mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            if (lstToolCodeList == null)
                            {
                                _log.Error("Variable lstToolForOPList is Null!");
                                return null;
                            }
                            while (mySqlDataReader.Read())
                            {
                                if (!mySqlDataReader.IsDBNull(0) && !mySqlDataReader.IsDBNull(1))
                                {
                                    // ToolId, ToolCode
                                    lstToolCodeList.Add(mySqlDataReader.GetInt32(0), mySqlDataReader.GetString(1));
                                }
                            }
                            mySqlDataReader.Close();
                        }
                    }
                    mySqlConnection.Close();
                }
                return lstToolCodeList;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return null;
            }
        }
    }
}
