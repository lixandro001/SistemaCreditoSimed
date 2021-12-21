using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity.Response
{
    public class listadoDetalleInformacionSocios
    {
        public int IdClienteDatosGenerales { get; set; }
        public bool CompañiaCuentaAccionistas { get; set; }
        public string NombreApellidoAccionistas { get; set; }
        public string TipoId { get; set; }
        public string NroDocumento { get; set; }
        public string Participacion { get; set; }
        public string Nacionalidad { get; set; }
    }
}
