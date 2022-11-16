using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IWorkingTransactionRepository
    {
        bool AddWorkingTransaction(WorkingTransaction workingTransaction);
        bool UpdateWorkingTransaction(WorkingTransaction workingTransaction);
        bool DeleteWorkingTransaction(WorkingTransaction workingTransaction);
    }
}
