using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IWorkingTransactionRepository
    {
        Task<bool> AddWorkingTransaction(WorkingTransaction workingTransaction);
        bool UpdateWorkingTransaction(WorkingTransaction workingTransaction);
        bool DeleteWorkingTransaction(WorkingTransaction workingTransaction);
    }
}
