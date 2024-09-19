using AutoMapper;
using POS.Dominio.Dtos.Request;
using POS.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructura.Mapper
{
    public class MappingUsuario: Profile
    {
        public MappingUsuario()
        {
            CreateMap<UsuarioRequest, Usuario>()
                .ForMember(dest => dest.id_usuario , opt => opt.Ignore()); // Ignorar el Id si se genera automáticamente
        }

    }
}
