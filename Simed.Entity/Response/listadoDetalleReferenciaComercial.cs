using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity.Response
{
    public class listadoDetalleReferenciaComercial
    {
        public int IdClienteDatosGenerales { get; set; }
        public string Empresa { get; set; }
        public string Ruc { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
    }
}
