using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Dominio.Dtos.Request
{
    public class UsuarioRequest
    {
        public int? IntentosFallidos { get; set; }

        public string? Mail { get; set; }

        public string? Password { get; set; }

        public string? SessionActive { get; set; }

        public string? Status { get; set; }

        public string? UserName { get; set; }

        public int? PersonaIdPersona2 { get; set; }
    }
}
