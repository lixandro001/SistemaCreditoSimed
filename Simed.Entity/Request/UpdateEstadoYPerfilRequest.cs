using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity.Request
{
    public class UpdateEstadoYPerfilRequest
    {
        public int IdPerfil { get; set; }
        public string Code { get; set; }
        public int UsuarioId { get; set; }
        public string MensajeRechazado { get; set; }
    }
}
