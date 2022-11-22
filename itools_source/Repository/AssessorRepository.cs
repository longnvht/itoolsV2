using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Utils;
using log4net;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace itools_source.Repository
{
    public class AssessorRepository : BaseRepository, IAssessorRepository
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(AssessorRepository).Name);

        public void AddAssessor(Assessor assessor)
        {
            throw new NotImplementedException();
        }

        public void UpdateAssessor(Assessor assessor)
        {
            throw new NotImplementedException();
        }

        public void DeleteAssessor(Assessor assessor)
        {
            throw new NotImplementedException();
        }

        public Assessor GetAssessor(string strUserName, string strPassword)
        {
            Assessor assessor = null;

            string strSelect = @"SELECT *
                                    FROM assessor
                                        WHERE assessor.UserName = '" + strUserName.ToLower() + 
                                            "' AND (assessor.Password = MD5('" + strPassword +  "') OR assessor.LastPassword = MD5('" + strPassword + "'))" +
                                            " AND assessor.IsActive = 1";
            _log.Info(strSelect);
            try
            {
                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    using (MySqlDataReader mySqlDataReader = MySqlConnect.DataQuery(strSelect, mySqlConnection))
                    {
                        if (mySqlDataReader.Read())
                        {
                            if (assessor == null)
                            {
                                assessor = new Assessor();
                            }

                            if (!mySqlDataReader.IsDBNull(0))
                            {
                                assessor.iAssessorId = mySqlDataReader.GetInt32(0);
                            }
                            else
                            {
                                _log.Info("Id NULL!");
                                return null;
                            }

                            if (!mySqlDataReader.IsDBNull(1))
                            {
                                assessor.strUserName = mySqlDataReader["UserName"].ToString();
                            }

                            if (!mySqlDataReader.IsDBNull(2))
                            {
                                assessor.strFingerId = mySqlDataReader["FingerID"].ToString();
                            }

                            if (!mySqlDataReader.IsDBNull(3))
                            {
                                assessor.strPassword = mySqlDataReader.GetString(3);
                            }

                            if (!mySqlDataReader.IsDBNull(4))
                            {
                                assessor.strFirstName = mySqlDataReader.GetString(4);
                            }

                            if (!mySqlDataReader.IsDBNull(5))
                            {
                                assessor.strLastName = mySqlDataReader.GetString(5);
                            }

                            if (!mySqlDataReader.IsDBNull(6))
                            {
                                assessor.strEmailAddress = mySqlDataReader.GetString(6);
                            }

                            if (!mySqlDataReader.IsDBNull(7))
                            {
                                assessor.strAddress = mySqlDataReader.GetString(7);
                            }

                            if (!mySqlDataReader.IsDBNull(8))
                            {
                                assessor.strPhone = mySqlDataReader.GetString(8);
                            }

                            if (!mySqlDataReader.IsDBNull(9))
                            {
                                assessor.strCompanyCode = mySqlDataReader.GetString(9);
                            }

                            if (!mySqlDataReader.IsDBNull(10))
                            {
                                assessor.strMachineCode = mySqlDataReader.GetString(10);
                            }

                            if (!mySqlDataReader.IsDBNull(11))
                            {
                                assessor.isLocked = mySqlDataReader.GetInt32(11);
                            }

                            if (!mySqlDataReader.IsDBNull(12))
                            {
                                assessor.isActive = mySqlDataReader.GetInt32(12);
                            }

                            if (!mySqlDataReader.IsDBNull(13))
                            {
                                assessor.strLastPassword = mySqlDataReader.GetString(13);
                            }

                            if (!mySqlDataReader.IsDBNull(14))
                            {
                                assessor.isFirstTimeLogin = mySqlDataReader.GetByte(14);
                            }

                            if (!mySqlDataReader.IsDBNull(15))
                            {
                                assessor.iFailTimes = mySqlDataReader.GetInt32(15);
                            }

                            if (!mySqlDataReader.IsDBNull(16))
                            {
                                assessor.dtUpdateDate = mySqlDataReader.GetDateTime(16);
                            }
                        }
                        mySqlDataReader.Close();
                    }
                    mySqlConnection.Close();
                }
                return assessor;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return assessor;
        }

        public string GetRoleName(int iAssessorId)
        {
            string strName = "";
            string strSelect = @"SELECT roles.RoleName
	                                FROM roles, assessor, roleassessor
		                                WHERE roles.RoleID = roleassessor.RoleID
			                                AND assessor.AssessorID = roleassessor.AssessorID
				                                AND assessor.AssessorID = '" + iAssessorId + "'";
            _log.Info(strSelect);
            try
            {
                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    using (MySqlDataReader mySqlDataReader = MySqlConnect.DataQuery(strSelect, mySqlConnection))
                    {
                        if (mySqlDataReader.Read())
                        {
                            if (!mySqlDataReader.IsDBNull(0))
                            {
                                strName = mySqlDataReader.GetString(0);
                            }
                        }
                        mySqlDataReader.Close();
                    }
                    mySqlConnection.Close();
                }
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }

            return strName;
        }

        public IEnumerable<Assessor> GetAllAssessor()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Assessor> GetByValue()
        {
            throw new NotImplementedException();
        }

        public int GetById(string strUserName, string strPassword)
        {
            int iAssessorID = -1;
            string strSelect = @"SELECT *
                                    FROM assessor
                                        WHERE assessor.UserName = '" + strUserName.ToLower() +
                                            "' AND (assessor.Password = MD5('" + strPassword + "') OR assessor.LastPassword = MD5('" + strPassword + "'))" +
                                            "AND assessor.IsActive = 1";
            _log.Info(strSelect);
            try
            {
                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    using (MySqlDataReader mySqlDataReader = MySqlConnect.DataQuery(strSelect, mySqlConnection))
                    {
                        if (mySqlDataReader.Read())
                        {
                            if (!mySqlDataReader.IsDBNull(0))
                            {
                                iAssessorID = mySqlDataReader.GetInt32(0);
                            }
                            else
                            {
                                _log.Error("AssessorID is Null!");
                                return iAssessorID;
                            }
                        }

                        mySqlDataReader.Close();
                    }
                    mySqlConnection.Close();
                }
                return iAssessorID;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return iAssessorID; // Login Fail.
            }
        }
    }
}
