using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using itools_source.Models;
using itools_source.Utils;
using MySql.Data.MySqlClient;
using log4net.Repository.Hierarchy;

namespace itools_source.Presenter
{
    public class EmployeePresenter
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(EmployeePresenter).Name);

        public static BindingList<Assessor> LoadAssessor()
        {
            try
            {
                BindingList<Assessor> assessorList = new BindingList<Assessor>();
                string strSelect = @"SELECT * FROM assessor WHERE assessor.IsActive = 1";
                MySqlConnection mySqlConnection = MySqlConnect.Open();
                MySqlDataReader mySqlDataReader = MySqlConnect.DataQuery(strSelect, mySqlConnection);
                Assessor assessor = new Assessor();

                while (mySqlDataReader.Read())
                {
                    if (!mySqlDataReader.IsDBNull(0))
                    {
                        assessor.iAssessorId = int.Parse(mySqlDataReader["AssessorID"].ToString());
                    }
                    else
                    {
                        continue;
                    }

                    if (!mySqlDataReader.IsDBNull(1))
                    {
                        assessor.strUserName = mySqlDataReader["UserName"].ToString();
                    }
                    else
                    {
                        assessor.strUserName = "";
                    }

                    if (!mySqlDataReader.IsDBNull(2))
                    {
                        assessor.strFingerId = mySqlDataReader["FingerID"].ToString();
                    }
                    else
                    {
                        assessor.strUserName = "";
                    }

                    if (!mySqlDataReader.IsDBNull(3))
                    {
                        assessor.strPassword = mySqlDataReader["Password"].ToString();
                    }
                    else
                    {
                        assessor.strUserName = "";
                    }

                    if (!mySqlDataReader.IsDBNull(4))
                    {
                        assessor.strFirstName = mySqlDataReader["FirstName"].ToString();
                    }
                    else
                    {
                        assessor.strUserName = "";
                    }

                    if (!mySqlDataReader.IsDBNull(5))
                    {
                        assessor.strLastName = mySqlDataReader["LastName"].ToString();
                    }
                    else
                    {
                        assessor.strUserName = "";
                    }

                    if (!mySqlDataReader.IsDBNull(6))
                    {
                        assessor.strEmailAddress = mySqlDataReader["EmailAddress"].ToString();
                    }
                    else
                    {
                        assessor.strUserName = "";
                    }

                    if (!mySqlDataReader.IsDBNull(7))
                    {
                        assessor.strFingerId = mySqlDataReader["FingerID"].ToString();
                    }
                    else
                    {
                        assessor.strUserName = "";
                    }

                    if (!mySqlDataReader.IsDBNull(2))
                    {
                        assessor.strFingerId = mySqlDataReader["FingerID"].ToString();
                    }
                    else
                    {
                        assessor.strUserName = "";
                    }
                }

                _log.Info(strSelect);
                mySqlDataReader.Close();
                mySqlConnection.Close();

                return assessorList;
            }
            catch (MySqlException ex)
            {
                _log.Error(ex.Message);
            }
            return null;
        }

        public static bool CheckUserNameAndPassword(string strUserName, string strPassword)
        {
            string strSelect = @"SELECT * FROM assessor WHERE assessor.UserName = '" + strUserName.ToLower() + "' AND (assessor.Password = MD5('" + strPassword + "') OR assessor.LastPassword = MD5('" + strPassword + "')) AND assessor.IsActive = 1";
            _log.Info(strSelect);
            try
            {
                MySqlConnection mySqlConnection = MySqlConnect.Open();
                MySqlDataReader mySqlDataReader = MySqlConnect.DataQuery(strSelect, mySqlConnection);
                
                while (mySqlDataReader.Read())
                {
                    mySqlDataReader.Close();
                    mySqlConnection.Close();
                    return true;
                }

                mySqlDataReader.Close();
                mySqlConnection.Close();
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return false;
        }
    }
}
