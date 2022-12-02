using itools_source.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace itools_source.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public T Find(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetApplyEagerLoading(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] childrens)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<T>> GetApplyEagerLoadingAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, bool>>[] childrens)
        {
            throw new NotImplementedException();
        }

        public BindingList<T> GetBindingList()
        {
            throw new NotImplementedException();
        }

        public Task<BindingList<T>> GetBindingListApplyEagerLoadingAsync(params Expression<Func<T, object>>[] childrens)
        {
            throw new NotImplementedException();
        }

        public Task<BindingList<T>> GetBindingListAsync()
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetList()
        {
            throw new NotImplementedException();
        }

        public IList<T> GetList(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> GetListAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Insert(T data)
        {
            throw new NotImplementedException();
        }

        public void Update(T data)
        {
            throw new NotImplementedException();
        }

        public void Delete(T data)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
