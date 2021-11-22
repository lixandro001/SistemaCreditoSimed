using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity.Response
{
    public class SeguridadResponse
    {
        public int IdPerfil { get; set; }
        public string UsuarioCodeGuid { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string NombreCompleto { get; set; }
        public int TipoDocumento { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }
        public bool Locked { get; set; }
        public string TokenCode { get; set; }
    
    }
}
