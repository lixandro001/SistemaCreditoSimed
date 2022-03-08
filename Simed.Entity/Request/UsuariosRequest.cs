using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity.Request
{
   public class UsuariosRequest
    {
       public int idperfil { get; set; }
       public string login { get; set; } 
       public string password { get; set; }
        public string nombrecompleto { get; set; }
        public string documentoidentidad { get; set; }
        public string email { get; set; }
        public string sexo { get; set; }
        public string mensaje { get; set; }
        public int UsuarioId { get; set; }
    }
}
