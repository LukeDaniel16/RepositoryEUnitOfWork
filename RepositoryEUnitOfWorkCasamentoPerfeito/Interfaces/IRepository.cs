using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RepositoryEUnitOfWorkCasamentoPerfeito.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        T GetById(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
