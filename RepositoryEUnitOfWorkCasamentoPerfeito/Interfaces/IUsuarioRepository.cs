using RepositoryEUnitOfWorkCasamentoPerfeito.Entities;
using System.Collections.Generic;

namespace RepositoryEUnitOfWorkCasamentoPerfeito.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        IEnumerable<Usuario> GetUsuarioPorNome(string nome);
    }
}
