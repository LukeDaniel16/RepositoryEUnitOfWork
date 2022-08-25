using RepositoryEUnitOfWorkCasamentoPerfeito.Interfaces;
using System;
using System.Data.Entity;

namespace RepositoryEUnitOfWorkCasamentoPerfeito
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public IUsuarioRepository Usuarios { get; }

        public UnitOfWork(DbContext context, IUsuarioRepository usuarios)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            Usuarios = usuarios ?? throw new ArgumentNullException(nameof(usuarios));
        }

        public void Commit()
        {
            _context.SaveChanges();
            Dispose();
        }

        public void Rollback()
        {
            _context.Database.CurrentTransaction.Rollback();
            Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
