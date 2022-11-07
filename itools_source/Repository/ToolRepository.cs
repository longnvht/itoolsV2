using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Utils;
using log4net;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Repository
{
    public class ToolRepository : IToolRepository
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(AssessorRepository).Name);

        public void AddNewTool(Tool newTool)
        {
            throw new NotImplementedException();
        }

        public void AddTool(Tool tool)
        {
            throw new NotImplementedException();
        }

        public void DeleteTool(Tool tool)
        {
            throw new NotImplementedException();
        }

        public void UpdateTool(Tool tool)
        {
            throw new NotImplementedException();
        }

        public ToolsMachineTray GetToolByTrayIndex(string strTrayIndex, string strMachineCode)
        {
            ToolsMachineTray toolsMachineTray = null;

            //string strSelect = @"SELECT DISTINCT tools.ToolID,
            //                     tools.ToolCode,
            //                     tools.CompanyCode,
            //                     tools.Model,
            //                     tools.Barcode,
            //                     tools.Description,
            //                     tools.CreatedDate,
            //                     tools.UpdatedDate,
            //                     tools.IsActive
            //                 FROM tools, toolsmachinetray
            //                  WHERE tools.ToolCode = toolsmachinetray.ToolCode
            //                            AND toolsmachinetray.TrayIndex = '" + strTrayIndex + "'" +
            //                            "AND YEAR(toolsmachinetray.UpdatedDate) = \"2022\"";
            string strSelect = @"SELECT DISTINCT *
	                                FROM toolsmachinetray
				                        where toolsmachinetray.TrayIndex = '" + strTrayIndex + "'" +
                                            "AND toolsmachinetray.MachineCode = '" + strMachineCode + "'";
            _log.Info(strSelect);
            try
            {
                MySqlConnection mySqlConnection = MySqlConnect.Open();
                MySqlDataReader mySqlDataReader = MySqlConnect.DataQuery(strSelect, mySqlConnection);

                if (mySqlDataReader.Read())
                {
                    if (toolsMachineTray == null)
                    {
                        toolsMachineTray = new ToolsMachineTray();
                    }

                    if (!mySqlDataReader.IsDBNull(2))
                    {
                        toolsMachineTray.iToolsMachineTrayId = mySqlDataReader.GetInt32(0);
                    }
                    else
                    {
                        _log.Info("Id NULL!");
                        return null;
                    }

                    if (!mySqlDataReader.IsDBNull(1))
                    {
                        toolsMachineTray.strMachineCode = mySqlDataReader.GetString(1);
                    }

                    if (!mySqlDataReader.IsDBNull(2))
                    {
                        toolsMachineTray.strToolCode = mySqlDataReader.GetString(2);
                    }

                    if (!mySqlDataReader.IsDBNull(3))
                    {
                        toolsMachineTray.strTrayIndex = mySqlDataReader.GetString(3);
                    }

                    if (!mySqlDataReader.IsDBNull(4))
                    {
                        toolsMachineTray.iQuantity = mySqlDataReader.GetInt32(4);
                    }

                    if (!mySqlDataReader.IsDBNull(5))
                    {
                        toolsMachineTray.dtCreateDate = mySqlDataReader.GetDateTime(5);
                    }

                    if (!mySqlDataReader.IsDBNull(6))
                    {
                        toolsMachineTray.dtUpdateDate = mySqlDataReader.GetDateTime(6);
                    }

                    if (!mySqlDataReader.IsDBNull(7))
                    {
                        toolsMachineTray.isActive = mySqlDataReader.GetByte(7);
                    }
                }

                mySqlDataReader.Close();
                mySqlConnection.Close();
                return toolsMachineTray;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return toolsMachineTray;
        }

        public int GetToolQuantity(string strTrayIndex)
        {
            if (strTrayIndex == null || string.IsNullOrEmpty(strTrayIndex))
            {
                return -1;
            }

            string strSelect = @"SELECT DISTINCT toolsmachinetray.Quantity
	                                FROM tools, toolsmachinetray
		                                WHERE tools.ToolCode = toolsmachinetray.ToolCode
				                                AND toolsmachinetray.TrayIndex = '" + strTrayIndex + "'";
            _log.Info(strSelect);
            try
            {
                MySqlConnection mySqlConnection = MySqlConnect.Open();
                MySqlDataReader mySqlDataReader = MySqlConnect.DataQuery(strSelect, mySqlConnection);

                if (mySqlDataReader.Read())
                {
                    if (!mySqlDataReader.IsDBNull(0))
                    {
                        return mySqlDataReader.GetInt32(0);
                    }
                    else
                    {
                        _log.Info("Id NULL!");
                        return -1;
                    }
                }

                mySqlDataReader.Close();
                mySqlConnection.Close();
                return -1;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return -1;
        }
    }
}
