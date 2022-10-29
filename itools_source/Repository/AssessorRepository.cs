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

        public bool CheckUserNameAndPassword(string strUserName, string strPassword)
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
