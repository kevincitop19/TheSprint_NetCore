using POS.Dominio.Models;
using POS.Infrastructura.Bases;
using POS.Infrastructura.Commons.Config.Context;
using POS.Infrastructura.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructura.Repository
{
    internal class PersonaRepository : IPersonaRepository
    {
        private readonly PruebabackendContext _pruebabackendContext;
        public PersonaRepository(PruebabackendContext pruebabackend)
        {
            _pruebabackendContext=pruebabackend;    
        }
        

        public async Task<BaseResponse<Persona>> CreatePersona(Persona persona)
        {
            var response = new BaseResponse<Persona>();
            try
            {
                var query = await _pruebabackendContext.Personas.AddAsync(persona); 
                await _pruebabackendContext.SaveChangesAsync();
                if (query.Entity != null)
                {
                    response.Data.Add("insert", persona);
                    response.Message = "Se guardo correctamente ";//agregar mss
                    response.Code = "200"; //agregar el codigo
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Code = "404";

            }
            return response;
        }

        public Task<BaseResponse<Persona>> DeletePersona(int id)
        {
            throw new NotImplementedException();
        }


        public Task<BaseResponse<Persona>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Persona>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Persona>> UpdatePersona(Persona usuario)
        {
            throw new NotImplementedException();
        }
    }
}
