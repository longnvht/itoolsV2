using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source.Utils
{
    public class ServerTime
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(ServerTime).Name);

        private static string[] strServerIPs = { "132.163.96.1", "132.163.96.2", "129.6.15.28", "129.6.15.29" };

        public static DateTime GetServerTime()
        {
            foreach (string strServerIP in strServerIPs)
            {
                DateTime dtResult = ConnectServer(strServerIP);
                if (dtResult > DateTime.MinValue)
                {
                    return dtResult;
                }
            }
            return DateTime.MinValue;
        }

        private static DateTime ConnectServer(string strHost)
        {
            string strTime;

            try
            {
                StreamReader read = new StreamReader(new TcpClient(strHost, 13).GetStream());
                DateTime systemTime = DateTime.UtcNow;
                strTime = read.ReadToEnd();
            }
            catch (Exception ex)
            {
                _log.Error("Get Server Time Fail: " + ex.Message);
                return DateTime.MinValue;
            }

            //MessageBox.Show(strTime + ", " + strTime.Length.ToString());
            if (strTime.Length <= 38)
            {
                return DateTime.MinValue;
            }

            if (strTime.Substring(38, 9) != "UTC(NIST)")
            {
                return DateTime.MinValue;
            }
            if (strTime.Substring(30, 1) != "0")
            {
                return DateTime.MinValue;
            }

            int jd = int.Parse(strTime.Substring(1, 5));
            int yr = int.Parse(strTime.Substring(7, 2));
            int mo = int.Parse(strTime.Substring(10, 2));
            int dy = int.Parse(strTime.Substring(13, 2));
            int hr = int.Parse(strTime.Substring(16, 2));
            int mm = int.Parse(strTime.Substring(19, 2));
            int sc = int.Parse(strTime.Substring(22, 2));

            if (jd < 15020)
            {
                return DateTime.MinValue; // After 1900
            }

            if (jd > 51544)
            {
                yr += 2000;
            }
            else
            {
                yr += 1900;
            }

            return new DateTime(yr, mo, dy, hr, mm, sc);
        }
    }
}
