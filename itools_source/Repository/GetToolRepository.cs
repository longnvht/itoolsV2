using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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

        public IEnumerable<string> GetJobByNumber(string strJobNumber)
        {
            List<string> lstJobNumberList = new List<string>();
            string strQuery = @"SELECT longnv.job.JobNumber
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
                        }
                        string strJobNumberTemp = string.Empty;
                        while (mySqlDataReader.Read())
                        {
                            if (!mySqlDataReader.IsDBNull(0))
                            {
                                strJobNumberTemp = mySqlDataReader.GetString(0);
                                lstJobNumberList.Add(strJobNumberTemp);
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

        public Job GetJobs()
        {
            throw new NotImplementedException();
        }
    }
}
