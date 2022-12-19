using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IPermissionRepository
    {
        Task<string> GetPermissionNameById(string strId);
    }
}
