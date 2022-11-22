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

        public SortedList<string, string> GetOPByJobAndPart(string strJobName, string strPartID)
        {
            SortedList<string, string> lstOPList = new SortedList<string, string>();
            string strQuery = @"SELECT longnv.partop.OPNumber, longnv.partop.OPType
	                                FROM longnv.partop
		                                WHERE longnv.partop.JobNumber LIKE '" + strJobName + "' or longnv.partop.PartID = " + strPartID +
			                                " LIMIT 50";
            _log.Info(strQuery);
            try
            {
                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    using (MySqlDataReader mySqlDataReader = MySqlConnect.DataQuery(strQuery, mySqlConnection))
                    {
                        if (lstOPList == null)
                        {
                            _log.Error("Variable lstJobNumberList is Null!");
                            return null;
                        }
                        while (mySqlDataReader.Read())
                        {
                            if (!mySqlDataReader.IsDBNull(0))
                            {
                                lstOPList.Add(mySqlDataReader.GetString(0), mySqlDataReader.GetString(1));
                            }
                        }
                        mySqlDataReader.Close();
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
