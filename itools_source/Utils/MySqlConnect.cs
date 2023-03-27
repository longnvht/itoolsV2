using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace itools_source.Utils
{
    public class MySqlConnect
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(MySqlConnect).Name);

        private static string _strHOST = null;
        private static string _strPORT = null;
        private static string _strDATABASE_MAME = null;
        private static string _strUSER_NAME = null;
        private static string _strPASSWORD = null;

        public static string ConnectionString()
        {
            _strHOST = "192.168.0.50";
            _strPORT = "3306";
            _strDATABASE_MAME = "itooldtb";
            _strUSER_NAME = "admin";
            _strPASSWORD = "Vinam@12345";
            return ("server=" + _strHOST + ";Port=" + _strPORT + ";Database=" + _strDATABASE_MAME + ";User ID=" + _strUSER_NAME + ";Password=" + _strPASSWORD);
        }
        public static string ConnectionStringTwo()
        {
            _strHOST = "192.168.0.50";
            _strPORT = "3306";
            _strDATABASE_MAME = "tqteamne_itools";
            _strUSER_NAME = "admin";
            _strPASSWORD = "Vinam@12345";
            return ("server=" + _strHOST + ";Port=" + _strPORT + ";Database=" + _strDATABASE_MAME + ";User ID=" + _strUSER_NAME + ";Password=" + _strPASSWORD);
        }

        public static MySqlConnection Open()
        {
            try
            {
                if (ConnectionString() == null)
                {
                    return null;
                }
                MySqlConnection conn = new MySqlConnection(ConnectionString());
                conn.Open();
                return conn;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }
        public static MySqlConnection OpenTwo()
        {
            try
            {
                if (ConnectionStringTwo() == null)
                {
                    return null;
                }
                MySqlConnection conn = new MySqlConnection(ConnectionStringTwo());
                conn.Open();
                return conn;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public static async Task<MySqlConnection> OpenAsync()
        {
            try
            {
                if (ConnectionString() == null)
                {
                    return null;
                }
                MySqlConnection conn = new MySqlConnection(ConnectionString());
                await conn.OpenAsync();
                return conn;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }
        public static async Task<MySqlConnection> OpenAsyncTwo()
        {
            try
            {
                if (ConnectionStringTwo() == null)
                {
                    return null;
                }
                MySqlConnection conn = new MySqlConnection(ConnectionStringTwo());
                await conn.OpenAsync();
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

        public static async Task<MySqlDataReader> DataQueryAsync(string strQuery, MySqlConnection mySqlConn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strQuery, mySqlConn);
                return (MySqlDataReader)await cmd.ExecuteReaderAsync();
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public static MySqlDataReader DataQueryProcedure(string strStoreProcedure, MySqlConnection mySqlConn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strStoreProcedure, mySqlConn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                return cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public static async Task<MySqlDataReader> DataQueryProcedureAsync(string strStoreProcedure, MySqlConnection mySqlConn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strStoreProcedure, mySqlConn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                return (MySqlDataReader)await cmd.ExecuteReaderAsync();
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public static MySqlDataReader DataQuery(string strQuery, MySqlParameter[] paramerter, MySqlConnection mySqlConn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strQuery, mySqlConn);
                cmd.Parameters.AddRange(paramerter);
                return cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public static async Task<MySqlDataReader> DataQueryAsync(string strQuery, MySqlParameter[] paramerter, MySqlConnection mySqlConn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strQuery, mySqlConn);
                cmd.Parameters.AddRange(paramerter);
                return (MySqlDataReader)await cmd.ExecuteReaderAsync();
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public static MySqlDataReader DataQueryProcedure(string strStoreProcedure, MySqlParameter[] paramerter, MySqlConnection mySqlConn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strStoreProcedure, mySqlConn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddRange(paramerter);
                return cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return null;
        }

        public static async Task<MySqlDataReader> DataQueryProcedureAsync(string strStoreProcedure, MySqlParameter[] paramerter, MySqlConnection mySqlConn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strStoreProcedure, mySqlConn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddRange(paramerter);
                return (MySqlDataReader)await cmd.ExecuteReaderAsync();
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
            }
            return false;
        }

        public static async Task<bool> CmdExecutionAsync(string strQuery, MySqlConnection mySqlConn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strQuery, mySqlConn);
                return await cmd.ExecuteNonQueryAsync() != 0;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return false;
        }

        public static bool CmdExecutionProcedure(string strStoredProcedure, MySqlConnection mySqlConn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strStoredProcedure, mySqlConn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                return (cmd.ExecuteNonQuery() != 0);
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return false;
        }

        public static async Task<bool> CmdExecutionProcedureAsync(string strStoredProcedure, MySqlConnection mySqlConn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strStoredProcedure, mySqlConn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                return await cmd.ExecuteNonQueryAsync() != 0;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return false;
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
            }
            return false;
        }

        public static async Task<bool> CmdExecutionAsync(string strQuery, MySqlParameter[] parameter, MySqlConnection mySqlConn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strQuery, mySqlConn);
                cmd.Parameters.AddRange(parameter);
                return await cmd.ExecuteNonQueryAsync() != 0;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return false;
        }

        public static bool CmdExecutionProcedure(string strStoredProcedure, MySqlParameter[] parameter, MySqlConnection mySqlConn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strStoredProcedure, mySqlConn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameter);
                return (cmd.ExecuteNonQuery() != 0);
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return false;
        }

        public static async Task<bool> CmdExecutionProcedureAsync(string strStoredProcedure, MySqlParameter[] parameter, MySqlConnection mySqlConn)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(strStoredProcedure, mySqlConn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameter);
                return await cmd.ExecuteNonQueryAsync() != 0;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return false;
        }
    }
}
