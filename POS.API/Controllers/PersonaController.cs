using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POS.Dominio.Models;
using POS.Infrastructura.Bases;
using POS.Infrastructura.Interface;
using POS.Infrastructura.Repository;

namespace POS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaController(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository; 
        }

        [HttpPost]
        public Task<BaseResponse<Persona>> CreatePersona([FromBody] Persona persona)
        {
            return _personaRepository.CreatePersona(persona);   
        }

    }
}
