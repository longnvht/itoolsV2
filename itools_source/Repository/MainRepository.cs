using itools_source.Models;
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
    public class MainRepository : IMainRepository
    {
        public async Task<IEnumerable<MachineModel>> GetCurrentMachineInfo(string hddSerial, int machineID)
        {
            var machineList = new List<MachineModel>();
            using (MySqlConnection connection = await OpenAsync())
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = String.Format("Select * from warehouse where warehousetype = 'machine' and warehouseID = {0} and serial = '{1}'", machineID, hddSerial);
                using (MySqlDataReader dataReader = await ExecuteReaderForSQLAsync(cmd))
                {
                    if (dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            var machineModel = new MachineModel();
                            if (!dataReader.IsDBNull(0))
                            {
                                machineModel.MachineID = dataReader.GetInt32(0);
                            }
                            if (!dataReader.IsDBNull(1))
                            {
                                machineModel.MachineCode = dataReader.GetString(1);
                            }
                            if (!dataReader.IsDBNull(2))
                            {
                                machineModel.MachineName = dataReader.GetString(2);
                            }
                            if (!dataReader.IsDBNull(7))
                            {
                                machineModel.MachineSerial = dataReader.GetString(7);
                            }
                            if (!dataReader.IsDBNull(11))
                            {
                                machineModel.CompanyID = dataReader.GetInt32(11);
                            }
                            machineList.Add(machineModel);
                        }
                    }
                    dataReader.Close();
                }
                connection.Close();
            }
            return machineList;
        }
    }
}
