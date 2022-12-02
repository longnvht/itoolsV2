using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IUserAccountRepository
    {
        Task AddUserAccount(UserAccount userAccount);
        Task UpdateUserAccount(UserAccount userAccount);
        Task DeleteUserAccount(UserAccount userAccount);
        Task<UserAccount> GetUserAccount(string strUserName, string strPassword);
        Task<int?> GetById(string strUserName, string strPassword);
        Task<IEnumerable<UserAccount>> GetAllUserAccount();
        Task<IEnumerable<UserAccount>> GetByValue(); // Search
    }
}
