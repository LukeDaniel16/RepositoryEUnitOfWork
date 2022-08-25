using RepositoryEUnitOfWorkCasamentoPerfeito.Entities;
using System.Data.Entity;

namespace RepositoryEUnitOfWorkCasamentoPerfeito
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        { }
        public AppDbContext()
        { }
    }
}
