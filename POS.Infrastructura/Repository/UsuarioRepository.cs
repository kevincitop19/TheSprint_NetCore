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
    public class UsuarioRepository : IUsuarioRepository
    {

        public readonly PruebabackendContext _pruebabackendContext;

        public UsuarioRepository(PruebabackendContext pruebabackend)
        {
            _pruebabackendContext = pruebabackend;
        }
        public async Task<BaseResponse<Usuario>> CreateUser(Usuario user)
        {
            var response = new BaseResponse<Usuario>();
            try
            {
                var query = await _pruebabackendContext.Usuarios.AddAsync(user );
                if (query != null)
                {
                    response.Data.Add("insert", user);
                    response.Message = "Se guardo correctamente el usuario";//agregar mss
                    response.Code = "200"; //agregar el codigo
                }
                
            }catch (Exception ex){
                response.Message=ex.Message;
                response.Code = "404";
            
            }
            return response;
        }

        public Task<BaseResponse<Usuario>> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Usuario>> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Usuario>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<Usuario>> UpdateUser(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
