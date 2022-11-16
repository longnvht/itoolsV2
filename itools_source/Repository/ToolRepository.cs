﻿using itools_source.Models;
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
    public class ToolRepository : IToolRepository
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ToolRepository).Name);

        public bool AddNewTool(Tool newTool)
        {
            throw new NotImplementedException();
        }

        public bool AddNewToolMachineTray(ToolMachineTray toolMachineTray)
        {
            string strQuery = @"UPDATE toolsmachinetray SET ToolCode = @ToolCode, Quantity = @Quantity, UpdatedDate = @UpdatedDate WHERE TrayIndex = '" + toolMachineTray.strTrayIndex + "'" + "AND MachineCode = '" + toolMachineTray.strMachineCode + "'";
            _log.Info(strQuery);
            try
            {
                List<MySqlParameter> lstPar = new List<MySqlParameter>();
                lstPar.Add(new MySqlParameter("@ToolCode", toolMachineTray.strToolCode));
                lstPar.Add(new MySqlParameter("@Quantity", toolMachineTray.iQuantity));
                lstPar.Add(new MySqlParameter("@UpdatedDate", toolMachineTray.dtUpdateDate));

                foreach (var parCheck in lstPar)
                {
                    if (parCheck.Value == null)
                    {
                        parCheck.Value = DBNull.Value;
                    }
                }

                MySqlConnection mySqlConnection = MySqlConnect.Open();
                bool bResult = MySqlConnect.CmdExecution(strQuery, lstPar.ToArray(), mySqlConnection);
                mySqlConnection.Close();

                if (bResult == true)
                {
                    _log.Info("Add ToolMachineTray Susccessfully!");
                }

                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }

        public bool AddTool(Tool tool)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTool(Tool tool)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTool(Tool tool)
        {
            throw new NotImplementedException();
        }

        public ToolMachineTray GetToolByTrayIndex(string strTrayIndex, string strMachineCode)
        {
            ToolMachineTray toolsMachineTray = null;

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
                        toolsMachineTray = new ToolMachineTray();
                    }

                    if (!mySqlDataReader.IsDBNull(0))
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
            if (string.IsNullOrEmpty(strTrayIndex))
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
                        return -2;
                    }
                }

                mySqlDataReader.Close();
                mySqlConnection.Close();
                return -3;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return -4;
        }

        public IEnumerable<string> GetToolCodeList()
        {
            var toolCodeList = new List<string>();
            string strSelect = "SELECT DISTINCT tools.ToolCode FROM tools";

            _log.Info(strSelect);
            try
            {
                MySqlConnection mySqlConnection = MySqlConnect.Open();

                using (var mySqlDataReader = MySqlConnect.DataQuery(strSelect, mySqlConnection))
                {
                    if (toolCodeList == null)
                    {
                        _log.Error("List ToolCode is Null!");
                        return null;
                    }

                    string strToolCode = string.Empty;
                    while (mySqlDataReader.Read())
                    {
                        if (!mySqlDataReader.IsDBNull(0))
                        {
                            strToolCode = mySqlDataReader.GetString(0);
                            toolCodeList.Add(strToolCode);
                        }
                        else
                        {
                            _log.Info("ToolCode is NULL!: " + mySqlDataReader.FieldCount);
                        }
                    }

                    mySqlDataReader.Close();
                    mySqlConnection.Close();
                    return toolCodeList;
                }

                //MySqlDataReader mySqlDataReader = MySqlConnect.DataQuery(strSelect, mySqlConnection);

                //if (listToolCode == null)
                //{
                //    listToolCode = new List<string>();
                //}

                //string strToolCode = string.Empty;
                //while (mySqlDataReader.Read())
                //{
                //    if (!mySqlDataReader.IsDBNull(0))
                //    {
                //        strToolCode = mySqlDataReader.GetString(0);
                //        //listToolCode.
                //    }
                //    else
                //    {
                //        _log.Info("ToolCode is NULL!: " + mySqlDataReader.FieldCount);
                //    }
                //}

                //mySqlDataReader.Close();
                //mySqlConnection.Close();
                //return listToolCode;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public bool AddToolMachineTray(ToolMachineTray toolMachineTray)
        {
            string strInsert = @"INSERT INTO toolsmachinetray VALUE(@ToolsMachineTrayID, @MachineCode, @ToolCode, @TrayIndex, @Quantity, @CreatedDate, @UpdatedDate, 1)";
            List<MySqlParameter> lstPar = new List<MySqlParameter>();
            lstPar.Add(new MySqlParameter("@ToolsMachineTrayID", toolMachineTray.iToolsMachineTrayId));
            lstPar.Add(new MySqlParameter("@ToolsMachineTrayID", toolMachineTray.strMachineCode));
            lstPar.Add(new MySqlParameter("@ToolsMachineTrayID", toolMachineTray.strToolCode));
            lstPar.Add(new MySqlParameter("@ToolsMachineTrayID", toolMachineTray.strTrayIndex));
            lstPar.Add(new MySqlParameter("@ToolsMachineTrayID", toolMachineTray.iQuantity));
            lstPar.Add(new MySqlParameter("@ToolsMachineTrayID", toolMachineTray.dtUpdateDate));
            _log.Info(strInsert);

            try
            {
                if (lstPar[0].Value == null)
                {
                    _log.Info("ToolMachineTrayID is NULL!");
                    return false;
                }

                foreach (var parCheck in lstPar)
                {
                    if (parCheck.Value == null)
                    {
                        parCheck.Value = DBNull.Value;
                    }
                }

                MySqlConnection mySqlConnection = MySqlConnect.Open();
                bool bResult = MySqlConnect.CmdExecution(strInsert, lstPar.ToArray(), mySqlConnection);
                mySqlConnection.Close();

                _log.Info("Add ToolMachineTray Successfully.");
                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }

        public int? GetTheLargestToolMachineTray()
        {
            string strQuery = @"SELECT MAX(ToolsMachineTrayID) FROM toolsmachinetray";
            _log.Info(strQuery);

            int? iLargestId = null;
            try
            {
                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    using (var mySqlDataReader = MySqlConnect.DataQuery(strQuery, mySqlConnection))
                    {
                        if (mySqlDataReader.Read())
                        {
                            if (!mySqlDataReader.IsDBNull(0))
                            {
                                iLargestId = Convert.ToInt32(mySqlDataReader.GetString(0));
                            }
                            else
                            {
                                _log.Info("ToolCode is NULL!");
                            }
                        }

                        mySqlDataReader.Close();
                        mySqlConnection.Close();

                        if (iLargestId is null)
                        {
                            _log.Error("List ToolCode is Null!");
                        }
                        return iLargestId;
                    }
                }
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return iLargestId;
            }
        }

        public bool IsMachineTray(string strMachineCode, string strTrayIndex)
        {
            string strQuery = @"select MachineCode
	                                from toolsmachinetray
		                                where TrayIndex = '" + strTrayIndex + "'" +
                                            " and MachineCode = '" + strMachineCode + "'";
            _log.Info(strQuery);
            bool bResult = false;
            try
            {
                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    using (MySqlDataReader mySqlDataReader = MySqlConnect.DataQuery(strQuery, mySqlConnection))
                    {
                        if (mySqlDataReader.Read())
                        {
                            if (!mySqlDataReader.IsDBNull(0))
                            {
                                bResult = true;
                                _log.Info("Tool is Machine and Tray!");
                            }
                            else
                            {
                                bResult = false;
                                _log.Error("Tool is not Machine and Tray!");
                            }
                        }
                    }
                }
                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return bResult;
            }
        }

        public bool AddWorkingTransaction(WorkingTransaction workingTransaction)
        {
            string strInsert = @"INSERT INTO workingtransaction(TransactionDate, MachineCode, CompanyCode, AssessorID, JobNumber, OPNumber, ToolCode, TrayIndex, Quantity, TransactionStatus, TransactionType) VALUES (@TransactionDate, @MachineCode, @CompanyCode, @AssessorID, @JobNumber, @OPNumber, @ToolCode, @TrayIndex, @Quantity, @TransactionStatus, @TransactionType)";
            _log.Info(strInsert);

            List<MySqlParameter> lstpar = new List<MySqlParameter>();
            lstpar.Add(new MySqlParameter("@TransactionDate", workingTransaction.dtTransactionDate));
            lstpar.Add(new MySqlParameter("@MachineCode", workingTransaction.strMachineCode));
            lstpar.Add(new MySqlParameter("@CompanyCode", workingTransaction.strCompanyCode));
            lstpar.Add(new MySqlParameter("@AssessorID", workingTransaction.strAssessorId));
            lstpar.Add(new MySqlParameter("@JobNumber", workingTransaction.strJobNumber));
            lstpar.Add(new MySqlParameter("@OPNumber", workingTransaction.strOPNumber));
            lstpar.Add(new MySqlParameter("@ToolCode", workingTransaction.strToolCode));
            lstpar.Add(new MySqlParameter("@TrayIndex", workingTransaction.strTrayIndex));
            lstpar.Add(new MySqlParameter("@Quantity", workingTransaction.iQuantity));
            lstpar.Add(new MySqlParameter("@TransactionStatus", workingTransaction.strTransactionStatus));
            lstpar.Add(new MySqlParameter("@TransactionType", workingTransaction.strTransactiomType));

            if (lstpar[0].Value == null)
            {
                return false;
            }

            foreach (var parCheck in lstpar)
            {
                if (parCheck.Value == null)
                {
                    parCheck.Value = DBNull.Value;
                }
            }

            try
            {
                bool bResult = false;
                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    bResult = MySqlConnect.CmdExecution(strInsert, lstpar.ToArray(), mySqlConnection);
                    mySqlConnection.Close();
                }

                if (bResult == true)
                {
                    _log.Info("Add New WorkingTransation Successfully!");
                }
                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }

        public bool AddPluginMachineTray(ToolMachineTray toolMachineTray)
        {
            string strQuery = @"UPDATE toolsmachinetray
	                                SET Quantity = " + toolMachineTray.iQuantity +
		                                "WHERE ToolCode = '" + toolMachineTray.strToolCode + "'" +
			                                "AND TrayIndex = '" + toolMachineTray.strTrayIndex + "'" +
			                                "AND MachineCode = '" + toolMachineTray.strMachineCode + "'";
            _log.Info(strQuery);
            try
            {
                //List<MySqlParameter> lstPar = new List<MySqlParameter>();
                //lstPar.Add(new MySqlParameter("@ToolCode", toolMachineTray.strToolCode));
                //lstPar.Add(new MySqlParameter("@Quantity", toolMachineTray.iQuantity));
                //lstPar.Add(new MySqlParameter("@UpdatedDate", toolMachineTray.dtUpdateDate));

                //foreach (var parCheck in lstPar)
                //{
                //    if (parCheck.Value == null)
                //    {
                //        parCheck.Value = DBNull.Value;
                //    }
                //}
                bool bResult;
                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    bResult = MySqlConnect.CmdExecution(strQuery, mySqlConnection);
                    mySqlConnection.Close();
                }
                                
                if (bResult == true)
                {
                    _log.Info("Add Plugin ToolMachineTray Susccessfully!");
                }

                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }
    }
}
