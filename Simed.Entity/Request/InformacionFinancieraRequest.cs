using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity.Request
{
   public class InformacionFinancieraRequest
    {
        public string FechaCorte { get; set; }
        public bool checkSolesIF { get; set; }
        public bool checkDolaresIF { get; set; }
        public string txtActivosIF { get; set; }
        public string txtIngresosMensualesIF { get; set; }
        public string txtPasivosIF { get; set; }
        public string txtEgresosMensualesIF { get; set; }
        public string txtPatrimonioIF { get; set; }
        public string txtOtrosIngresosIF { get; set; }
        public string txtConceptoOtrosIngresosIF { get; set; }
        public int UsuarioId { get; set; }
        public int IdClienteDatosGenerales { get; set; }

    }
}
