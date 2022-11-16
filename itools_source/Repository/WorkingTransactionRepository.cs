using itools_source.Models;
using itools_source.Models.Interface;
using itools_source.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Repository
{
    public class WorkingTransactionRepository : IWorkingTransactionRepository
    {
        private static log4net.ILog _log = log4net.LogManager.GetLogger(typeof(WorkingTransactionRepository).Name);

        public bool AddWorkingTransaction(WorkingTransaction workingTransaction)
        {
            string strInsert = @"INSERT INTO workingtransaction(TransactionDate, MachineCode, CompanyCode, AssessorID, JobNumber, OPNumber, ToolCode, TrayIndex, Quantity, TransactionStatus, TransactionType) VALUES (@TransactionDate, @MachineCode, @CompanyCode, @AssessorID, @JobNumber, @OPNumber, @ToolCode, @TrayIndex, @Quantity, @TransactionStatus, @TransactionType)";
            _log.Info(strInsert);

            List<MySqlParameter> lstpar = new List<MySqlParameter>();
            lstpar.Add(new MySqlParameter("@MaLoaiNV", workingTransaction.dtTransactionDate));
            lstpar.Add(new MySqlParameter("@MachineCode", workingTransaction.strMachineCode));
            lstpar.Add(new MySqlParameter("@CompanyCode", workingTransaction.strCompanyCode));
            lstpar.Add(new MySqlParameter("@AssessorID", workingTransaction.strAssessorId));
            lstpar.Add(new MySqlParameter("@JobNumber", workingTransaction.strJobNumber));
            lstpar.Add(new MySqlParameter("@OPNumber", workingTransaction.strOPNumber));
            lstpar.Add(new MySqlParameter("@ToolCode", workingTransaction.strToolCode));
            lstpar.Add(new MySqlParameter("@TrayIndex", workingTransaction.strTrayIndex));
            lstpar.Add(new MySqlParameter("@Quantity", workingTransaction.iQuantity));
            lstpar.Add(new MySqlParameter("@TransactionStatus", workingTransaction.strTransactionStatus));
            lstpar.Add(new MySqlParameter("@TransactionType", workingTransaction.strTransactiomType));

            if (lstpar[0].Value == null)
            {
                return false;
            }

            foreach (var parCheck in lstpar)
            {
                if (parCheck.Value == null)
                {
                    parCheck.Value = DBNull.Value;
                }
            }

            try
            {
                bool bResult = false;
                using (MySqlConnection mySqlConnection = MySqlConnect.Open())
                {
                    bResult = MySqlConnect.CmdExecution(strInsert, lstpar.ToArray(), mySqlConnection);
                    mySqlConnection.Close();
                }

                if (bResult == true)
                {
                    _log.Info("Add WorkingTransation Successfully!");
                }
                return bResult;
            }
            catch (MySqlException e)
            {
                _log.Error(e.Message);
                return false;
            }
        }

        public bool DeleteWorkingTransaction(WorkingTransaction workingTransaction)
        {
            throw new NotImplementedException();
        }

        public bool UpdateWorkingTransaction(WorkingTransaction workingTransaction)
        {
            throw new NotImplementedException();
        }
    }
}
