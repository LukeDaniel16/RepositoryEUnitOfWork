using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepositoryEUnitOfWorkCasamentoPerfeito.Entities;
using RepositoryEUnitOfWorkCasamentoPerfeito.Repositories;
using System.Collections.Generic;

namespace RepositoryEUnitOfWorkCasamentoPerfeito.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Usuario> GetUserByName(string name)
        {
            var dbContext = new AppDbContext();
            UnitOfWork uow = new UnitOfWork(dbContext, new UsuarioRepository(dbContext));
            return uow.Usuarios.GetUsuarioPorNome(name);
        }
    }
}
