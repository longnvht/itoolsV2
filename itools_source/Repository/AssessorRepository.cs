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

        public Assessor CheckUserNameAndPassword(string strUserName, string strPassword)
        {
            Assessor assessor = null;

            string strSelect = @"SELECT * FROM assessor WHERE assessor.UserName = '" + strUserName.ToLower() + "' AND (assessor.Password = MD5('" + strPassword + "') OR assessor.LastPassword = MD5('" + strPassword + "')) AND assessor.IsActive = 1";
            _log.Info(strSelect);
            try
            {
                MySqlConnection mySqlConnection = MySqlConnect.Open();
                MySqlDataReader mySqlDataReader = MySqlConnect.DataQuery(strSelect, mySqlConnection);
                MessageBox.Show("1");
                if (mySqlDataReader.Read())
                {
                    MessageBox.Show("2");
                    if (!mySqlDataReader.IsDBNull(0))
                    {
                        MessageBox.Show("3");
                        //MessageBox.Show(mySqlDataReader["AssessorID"].ToString());
                        MessageBox.Show(mySqlDataReader.GetInt32(0).ToString());
                        //return null;
                    }
                }

                MessageBox.Show("4");
                mySqlDataReader.Close();
                mySqlConnection.Close();
                MessageBox.Show("5");
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
                MySqlConnection mySqlConnection = MySqlConnect.Open();
                MySqlDataReader mySqlDataReader = MySqlConnect.DataQuery(strSelect, mySqlConnection);
                if (mySqlDataReader.Read())
                {
                    if (!mySqlDataReader.IsDBNull(0))
                    {
                        strName = mySqlDataReader.GetString(0);
                    }
                }
                mySqlDataReader.Close();
                mySqlConnection.Close();
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
    }
}
