using VinamiToolUser.Utils;
using log4net;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinamiToolUser.Models;
using VinamiToolUser.Models.Interface;
using static VinamiToolUser.Utils.MySqlConnect;

namespace VinamiToolUser.Repository
{
    public class JobRepositoryNew : IJobRepositoryNew
    {
        public async Task<IEnumerable<JobModelNew>> GetAll()
        {
            var jobList = new List<JobModelNew>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"Select * from Job Limit 100";
                //MySqlParameter prm = CreateInputParameterForSQL(cmd, "@p_JobNumber", MySqlDbType.String, "6789");
                //cmd.Parameters.Add(prm);
                using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                {
                    if (dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            var jobModel = new JobModelNew();
                            if (!dataReader.IsDBNull(0))
                            {
                                jobModel.JobNumber = dataReader.GetString(0);
                            }
                            if (!dataReader.IsDBNull(3))
                            {
                                jobModel.PartID = dataReader.GetInt32(3);
                            }
                            if (!dataReader.IsDBNull(4))
                            {
                                jobModel.PoLineID = dataReader.GetInt32(4);
                            }
                            jobList.Add(jobModel);
                        }
                    }
                    dataReader.Close();
                }
                connection.Close(); 
            }
            return jobList;

        }

        public async Task<IEnumerable<JobModelNew>> GetByValue(string value)
        {
            var jobList = new List<JobModelNew>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                //string jobNumber = value;
                //cmd.CommandText = @"Select * from job where jobnumber like CONCAT('%', @jobNumber,'%') order by jobnumber desc limit 100";
                //cmd.Parameters.AddWithValue("@jobNumber", jobNumber);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"GetJobByJobNumberNew";
                MySqlParameter prm = CreateInputParameterForSQL(cmd, "@p_JobNumber", MySqlDbType.VarChar, value);
                cmd.Parameters.Add(prm);
                using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                {
                    if (dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            var jobModel = new JobModelNew();
                            if (!dataReader.IsDBNull(0))
                            {
                                jobModel.JobNumber = dataReader.GetString(0);
                            }
                            if (!dataReader.IsDBNull(3))
                            {
                                jobModel.PartID = dataReader.GetInt32(3);
                            }
                            if (!dataReader.IsDBNull(4))
                            {
                                jobModel.PoLineID = dataReader.GetInt32(4);
                            }
                            jobList.Add(jobModel);
                        }
                    }
                    dataReader.Close();
                }
                connection.Close();
            }
            return jobList;
        }
    }
}
