using System.Collections.Generic;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IMenuRepository
    {
        Task<IEnumerable<Menu>> GetListMenuByUserLogin(string strUserLogin);
        Task<IEnumerable<string>> GetListFormByMenuId(string strMenuId);
    }
}
