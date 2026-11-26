using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuarioApi.models.Enuns;

namespace UsuarioApi.models
{
    public class Usuario
    {
        public int id { get; set; }
        public TipoUsuarioEnum idTipoUsuario { get; set; }
        public int telefone { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
    }
}