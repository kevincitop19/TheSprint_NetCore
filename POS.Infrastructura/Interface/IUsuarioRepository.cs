using POS.Dominio.Dtos.Request;
using POS.Dominio.Models;
using POS.Infrastructura.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructura.Interface
{
    public interface IUsuarioRepository
    {
        Task<BaseResponse<Usuario>> GetAll();
       
        Task<BaseResponse<Usuario>> Get(int id);
        Task<BaseResponse<Usuario>> CreateUser(UsuarioRequest usuario);
        Task<BaseResponse<Usuario>> UpdateUser(Usuario usuario);
        Task<BaseResponse<Usuario>> DeleteUser(int id); 

    }
}
