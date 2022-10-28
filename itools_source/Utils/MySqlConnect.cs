using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Utils
{
    public class MySqlConnect
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(MySqlConnect).Name);
        private static string _strHOST = "192.168.0.12";
        private static string _strPORT = "3306";
        private static string _strDATABASE_MAME = "tqteamne_itools";
        private static string _strUSER_NAME = "admin";
        private static string _strPASSWORD = "Vinam@123";

        private static string _strConnect = "server=" + _strHOST + ";Database=" + _strDATABASE_MAME + ";User ID=" + _strUSER_NAME + ";Password=" + _strPASSWORD;

        public static MySqlConnection Open()
        {
            try
            {
                if (_strConnect == null)
                {
                    return null;
                }
                MySqlConnection conn = new MySqlConnection(_strConnect);
                conn.Open();
                return conn;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public static MySqlDataReader DataQuery(string strQuery, MySqlConnection mySqlConn)
        {
            MySqlCommand cmd = new MySqlCommand(strQuery, mySqlConn);
            return cmd.ExecuteReader();
        }

        public static MySqlDataReader DataQuery(string strquery, MySqlParameter[] paramerter, MySqlConnection mySqlConn)
        {
            MySqlCommand cmd = new MySqlCommand(strquery, mySqlConn);
            cmd.Parameters.AddRange(paramerter);
            return cmd.ExecuteReader();
        }

        public static bool CmdExecution(string strQuery, MySqlConnection mySqlConn)
        {
            MySqlCommand cmd = new MySqlCommand(strQuery, mySqlConn);
            return (cmd.ExecuteNonQuery() != 0);
        }

        public static bool CmdExecution(string strQuery, MySqlParameter[] parameter, MySqlConnection mySqlConn)
        {
            MySqlCommand cmd = new MySqlCommand(strQuery, mySqlConn);
            cmd.Parameters.AddRange(parameter);
            return (cmd.ExecuteNonQuery() != 0);
        }
    }
}
