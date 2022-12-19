using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Utils;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace itools_source.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly log4net.ILog _log = log4net.LogManager.GetLogger(typeof(CompanyRepository).Name);

        public async Task<IEnumerable<Company>> GetCompanies()
        {
            BindingList<Company> lstCompany = null;
            string strQueryProcedure = @"GetCompanyIdAndName";
            _log.Info("Get list id and name in table company: " + strQueryProcedure);

            try
            {
                using (MySqlConnection mySqlConnection = await MySqlConnect.OpenAsync())
                {
                    using (MySqlDataReader mySqlDataReader = await MySqlConnect.DataQueryProcedureAsync(strQueryProcedure, mySqlConnection))
                    {
                        if (mySqlDataReader != null)
                        {
                            Company company = null;
                            while (await mySqlDataReader.ReadAsync())
                            {
                                if (lstCompany == null)
                                {
                                    lstCompany = new BindingList<Company>();
                                }
                                company = new Company();

                                Menu menu = new Menu();
                                if (!await mySqlDataReader.IsDBNullAsync(0))
                                {
                                    company.iCompanyId = mySqlDataReader.GetInt32(0);
                                }

                                if (!await mySqlDataReader.IsDBNullAsync(1))
                                {
                                    company.strCompanyName = mySqlDataReader.GetString(1);
                                }
                                lstCompany.Add(company);
                            }
                            mySqlDataReader.Close();
                        }
                        await mySqlConnection.CloseAsync();
                    }
                }

                return lstCompany;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
            }
            return lstCompany; // null
        }
    }
}
