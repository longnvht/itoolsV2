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
    public class RolesRepository : IRolesRepository
    {
        log4net.ILog _log = log4net.LogManager.GetLogger(typeof(RolesRepository).Name);
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
    }
}
