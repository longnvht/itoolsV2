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
    public class OpRepositoryNew : IOpRepositoryNew
    {
        public async Task<IEnumerable<OPModel>> GetAll(JobModelNew job)
        {
            var jobNumber = job.JobNumber;
            var partID = job.PartID;
            var opList = new List<OPModel>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"Select * from partop where jobnumber = @jobNumber or partid = @partID order by opnumber desc limit 100";
                cmd.Parameters.AddWithValue("@jobNumber", jobNumber);
                cmd.Parameters.AddWithValue("@partID", partID);
                using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                {
                    if (dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            var opModel = new OPModel();
                            if (!dataReader.IsDBNull(0))
                            {
                                opModel.OpID = dataReader.GetInt32(0);
                            }
                            if (!dataReader.IsDBNull(1))
                            {
                                opModel.OpNumber = dataReader.GetString(1);
                            }
                            if (!dataReader.IsDBNull(2))
                            {
                                opModel.PartID = dataReader.GetInt32(2);
                            }
                            if (!dataReader.IsDBNull(3))
                            {
                                opModel.OpType = dataReader.GetString(3);
                            }
                            if (!dataReader.IsDBNull(4))
                            {
                                opModel.JobNumber = dataReader.GetString(4);
                            }
                            opList.Add(opModel);
                        }
                    }
                    dataReader.Close();
                }
                connection.Close();
            }
            return opList;
        }

        public async Task<IEnumerable<OPModel>> GetByValue(JobModelNew job, string value)
        {
            var opList = new List<OPModel>();
            string jobNumber = job.JobNumber;
            int partID = job.PartID;
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"Select * from partop where (jobnumber = @jobNumber or partid = @partID) and opnumber like CONCAT('%', @opNumber,'%') order by opnumber desc limit 100";
                cmd.Parameters.AddWithValue("@jobNumber", jobNumber);
                cmd.Parameters.AddWithValue("@partID", partID);
                cmd.Parameters.AddWithValue("@opNumber", value);
                using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                {
                    if (dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            var opModel = new OPModel();
                            if (!dataReader.IsDBNull(0))
                            {
                                opModel.OpID = dataReader.GetInt32(0);
                            }
                            if (!dataReader.IsDBNull(1))
                            {
                                opModel.OpNumber = dataReader.GetString(1);
                            }
                            if (!dataReader.IsDBNull(2))
                            {
                                opModel.PartID = dataReader.GetInt32(2);
                            }
                            if (!dataReader.IsDBNull(3))
                            {
                                opModel.OpType = dataReader.GetString(3);
                            }
                            if (!dataReader.IsDBNull(4))
                            {
                                opModel.JobNumber = dataReader.GetString(4);
                            }
                            opList.Add(opModel);
                        }
                    }
                    dataReader.Close();
                }
                connection.Close();
            }
            return opList;
        }
    }
}
