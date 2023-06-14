using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace VinamiToolUser.Utils
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
            _strHOST = "localhost";
            _strPORT = "3306";
            _strDATABASE_MAME = "itools_v1p0";
            _strUSER_NAME = "admin";
            _strPASSWORD = "1qazxsw2";
            return ("server=" + _strHOST + ";Port=" + _strPORT + ";Database=" + _strDATABASE_MAME + ";User ID=" + _strUSER_NAME + ";Password=" + _strPASSWORD);


            //_strHOST = "192.168.0.50";
            //_strPORT = "3306";
            //_strDATABASE_MAME = "vm1data";
            //_strUSER_NAME = "admin";
            //_strPASSWORD = "Vinam@12345";
            //return ("server=" + _strHOST + ";Port=" + _strPORT + ";Database=" + _strDATABASE_MAME + ";User ID=" + _strUSER_NAME + ";Password=" + _strPASSWORD);
        }

        #region SqlParameter CreateInputParameterForSQL(MySqlCommand dbCmd, string prmName, MySqlDbType MySqlDbType, object value)
        public static MySqlParameter CreateInputParameterForSQL(MySqlCommand sqlDbCmd, string prmName, MySqlDbType MySqlDbType, object value)
        {
            MySqlParameter sPrm = sqlDbCmd.CreateParameter();
            sPrm.ParameterName = prmName;
            sPrm.MySqlDbType = MySqlDbType;
            //sPrm.IsNullable = true;
            sPrm.Direction = ParameterDirection.Input;
            sPrm.Value = value;
            return sPrm;
        }
        #endregion

        #region SqlParameter CreateOutParameterForSQL(MySqlCommand dbCmd, string prmName, MySqlDbType MySqlDbType, object value)
        public static MySqlParameter CreateOutParameterForSQL(MySqlCommand sqlDbCmd, string prmName, MySqlDbType MySqlDbType, object value)
        {
            MySqlParameter sPrm = sqlDbCmd.CreateParameter();
            sPrm.ParameterName = prmName;
            sPrm.MySqlDbType = MySqlDbType;
            //sPrm.IsNullable = true;
            sPrm.Direction = ParameterDirection.Output;
            sPrm.Value = value;
            return sPrm;
        }
        #endregion

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

        #region SqlDataReader ExecuteReaderForSQL(MySqlCommand sCmd)
        public static MySqlDataReader ExecuteReaderForSQL(MySqlCommand sCmd)
        {
            try
            {
                if (sCmd.Connection.State != ConnectionState.Closed) sCmd.Connection.Close();
                if (sCmd.Connection.State != ConnectionState.Open)
                {
                    try
                    {
                        sCmd.Connection.Open();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                MySqlDataReader rv = sCmd.ExecuteReader(CommandBehavior.CloseConnection);
                sCmd.Parameters.Clear();
                return rv;
            }
            catch (Exception ex)
            {
                sCmd.Connection.Close();
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region SqlDataReader Async ExecuteReaderForSQL(MySqlCommand sCmd)
        public static async Task<MySqlDataReader> ExecuteReaderForSQLAsync(MySqlCommand sCmd)
        {
            try
            {
                if (sCmd.Connection.State != ConnectionState.Open)
                {
                    try
                    {
                        await sCmd.Connection.OpenAsync();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                return (MySqlDataReader) await sCmd.ExecuteReaderAsync(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                await sCmd.Connection.CloseAsync();
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Execute NonQuery Async ForSQL(MySqlCommand sCmd)
        public static async Task<bool> CmdExecutionProcedureAsync(MySqlCommand sCmd)
        {
            try
            {
                if (sCmd.Connection.State != ConnectionState.Open)
                {
                    try
                    {
                        await sCmd.Connection.OpenAsync();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }
                return await sCmd.ExecuteNonQueryAsync() != 0;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return false;
        }
        #endregion

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
