using RepositoryEUnitOfWorkCasamentoPerfeito.Entities;
using RepositoryEUnitOfWorkCasamentoPerfeito.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace RepositoryEUnitOfWorkCasamentoPerfeito.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext _context;
        protected Repository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            //_context.Set<T>().Update(entity);
        }

        public List<T> GetAll()
        {
            return new List<T>()
            {};
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).AsEnumerable<T>();
        }

        public T GetById(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().SingleOrDefault(predicate);
        }
    }
}
