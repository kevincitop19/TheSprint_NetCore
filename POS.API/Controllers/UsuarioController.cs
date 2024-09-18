
using Microsoft.AspNetCore.Mvc;
using POS.Dominio.Models;
using POS.Infrastructura.Bases;
using POS.Infrastructura.Interface;

namespace POS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost]
        public Task<BaseResponse<Usuario>> CreateUser([FromBody] Usuario user)
        {
            return _usuarioRepository.CreateUser(user);
        }
    }
}
