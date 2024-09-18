using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructura.Bases
{
    public class BaseResponse<T>
    {
        private String message;
        private String code;
        private Dictionary<String, T> data;

        public BaseResponse()
        {
            Data = new Dictionary<string, T>(); // Inicializa Data aquí
        }

        public string Message { get => message; set => message = value; }
        public string Code { get => code; set => code = value; }
        public Dictionary<string, T> Data { get; set; }
    }
}
