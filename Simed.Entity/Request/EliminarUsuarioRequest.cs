using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity.Request
{
    public class EliminarUsuarioRequest
    {
        public string codeUsuario { get; set; }
        public int UsuarioId { get; set; }
    }
}
