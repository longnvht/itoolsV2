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
        public BindingList<Assessor> LoadAssessor()
        {
            BindingList<Assessor> assessorList = new BindingList<Assessor>();
            string strSelect = "select";
            MySqlConnection conn = MySqlConnect.Open();
            MySqlDataReader mySqlDataReader = MySqlConnect.DataQuery(strSelect, conn);
            Assessor assessor = new Assessor();
            while (mySqlDataReader.Read())
            {
                
            }
            mySqlDataReader.Close();
            conn.Close();
            return assessorList;
        }
    }
}
