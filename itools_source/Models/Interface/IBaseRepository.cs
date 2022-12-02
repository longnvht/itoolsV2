using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(object id);
        IList<T> GetList();
        Task<IList<T>> GetListAsync();
        T Find(Expression<Func<T, bool>> expression);
        Task<T> FindAsync(Expression<Func<T, bool>> expression);
        IList<T> GetList(Expression<Func<T, bool>> expression);
        Task<IList<T>> GetListAsync(Expression<Func<T, bool>> expression);
        BindingList<T> GetBindingList();
        Task<BindingList<T>> GetBindingListAsync();
        IQueryable<T> GetApplyEagerLoading(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] childrens);
        Task<IQueryable<T>> GetApplyEagerLoadingAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, bool>>[] childrens);
        Task<BindingList<T>> GetBindingListApplyEagerLoadingAsync(params Expression<Func<T, object>>[] childrens);
        void Insert(T data);
        void Update(T data);
        void Delete(T data);
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
