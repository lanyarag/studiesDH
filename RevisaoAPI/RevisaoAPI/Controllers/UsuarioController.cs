using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RevisaoAPI.Model;

namespace RevisaoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext;
        [HttpGet]
        public ActionResult RequererTodos()
        {
            var Usuarios = DbSistema.Usuarios.ToList();
            return Ok(Usuarios);
        }
    }
}
