using System;

namespace RepositoryEUnitOfWorkCasamentoPerfeito.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUsuarioRepository Usuarios { get; }
        void Commit();
        void Rollback();
    }
}
