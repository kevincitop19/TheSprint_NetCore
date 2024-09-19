using POS.Dominio.Models;
using POS.Infrastructura.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructura.Interface
{
    public interface IPersonaRepository
    {
        Task<BaseResponse<Persona>> GetAll();

        Task<BaseResponse<Persona>> Get(int id);
        Task<BaseResponse<Persona>> CreatePersona(Persona persona);
        Task<BaseResponse<Persona>> UpdatePersona(Persona persona);
        Task<BaseResponse<Persona>> DeletePersona(int id);
    }
}
