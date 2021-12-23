using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity.Response
{
    public class BandejaClienteResponse
    {
        public string CodeClienteDatosGenerales { get; set; }
        public string Nombre_RazonSocialDatosGenerales { get; set; }
        public string DireccionDatosGenerales { get; set; }
        public string CiudadSedePrincipalDatosGenerales { get; set; }
        public string CelularDatosGenerales { get; set; }
        public string Nombre_S_PAIS { get; set; }
        public string EstadoComercial { get; set; }
        public string EstadoCredito { get; set; }
        public string EstadoVenta { get; set; }
        public string EstadoFinanza { get; set; }
        public string NombreCompleto { get; set; }
        public int IdEstadoComercial { get; set; }
    }
}
