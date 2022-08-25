using RepositoryEUnitOfWorkCasamentoPerfeito.Entities;
using RepositoryEUnitOfWorkCasamentoPerfeito.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RepositoryEUnitOfWorkCasamentoPerfeito.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<Usuario> GetUsuarioPorNome(string nome)
        {
            return GetAll().Where(u => u.Nome == nome);
        }
    }
}