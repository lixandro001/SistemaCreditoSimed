using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity.Response
{
    public class evaluacionResponse
    {
        public int idEvaluacionDocumento { get; set; }
        public int IdclienteDatosGenerales { get; set; }
        public string NombreOriginal { get; set; }
        public string NombreDocumento { get; set; }
        public Guid Guid { get; set; }
        public string ruta { get; set; }
    }
}
