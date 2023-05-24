using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models.Interface
{
    public interface IMenuRepositoryNew
    {
        Task<IEnumerable<MenuModel>> GetAll();
        Task<IEnumerable<MenuModel>> GetByValue(string value);//Searchs
    }
}
