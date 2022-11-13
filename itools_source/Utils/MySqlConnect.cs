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
        //private static string _strHOST = "192.168.0.12";
        //private static string _strPORT = "3306";
        //private static string _strDATABASE_MAME = "tqteamne_itools";
        //private static string _strUSER_NAME = "admin";
        //private static string _strPASSWORD = "Vinam@123";

        private static string _strHOST = "127.0.0.1";
        private static string _strPORT = "3308";
        private static string _strDATABASE_MAME = "tqteamne_itools";
        private static string _strUSER_NAME = "root";
        private static string _strPASSWORD = "0306ht@1502";

        private static string _strConnect = "server=" + _strHOST + ";Port=" + _strPORT + ";Database=" + _strDATABASE_MAME + ";User ID=" + _strUSER_NAME + ";Password=" + _strPASSWORD;

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
            try
            {
                MySqlCommand cmd = new MySqlCommand(strQuery, mySqlConn);
                return cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public static MySqlDataReader DataQuery(string strquery, MySqlParameter[] paramerter, MySqlConnection mySqlConn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strquery, mySqlConn);
                cmd.Parameters.AddRange(paramerter);
                return cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public static bool CmdExecution(string strQuery, MySqlConnection mySqlConn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strQuery, mySqlConn);
                return (cmd.ExecuteNonQuery() != 0);
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }

        public static bool CmdExecution(string strQuery, MySqlParameter[] parameter, MySqlConnection mySqlConn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strQuery, mySqlConn);
                cmd.Parameters.AddRange(parameter);
                return (cmd.ExecuteNonQuery() != 0);
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }
    }
}
