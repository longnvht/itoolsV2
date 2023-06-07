using System.Collections.Generic;
using System.Threading.Tasks;

namespace VinamiToolUser.Models.Interface
{
    public interface ILoginRepository
    {
        Task<IEnumerable<UserAccount>> GetUserAccount(string strUserName, string strPassword);
    }
}
