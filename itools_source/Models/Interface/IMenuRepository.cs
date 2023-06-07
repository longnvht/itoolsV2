using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models.Interface
{
    public interface IMenuRepository
    {
        Task<IEnumerable<MenuModel>> GetAll();
        Task<IEnumerable<MenuModel>> GetByPermission(string value);//Searchs
    }
}
