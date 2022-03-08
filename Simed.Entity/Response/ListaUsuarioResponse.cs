using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity.Response
{
    public class ListaUsuarioResponse
    {
        public int IdUsuario { get; set; }
        public int IdPerfil { get; set; }
        public Guid UsuarioCodeGuid { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string NombreCompleto { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string Email { get; set; }
        public string nombrePerfil { get; set; }
    }
}
