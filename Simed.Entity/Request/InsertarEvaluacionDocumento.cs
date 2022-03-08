using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity.Request
{
   public class InsertarEvaluacionDocumento
    {
      public int  IdclienteDatosGenerales { get; set; }
       public string  NombreOriginal { get; set; }
       public string   NombreDocumento { get; set; }
       public  string  Guid { get; set; }
        public string ruta { get; set; }
        public int  Bites { get; set; }
        public int UsuarioId { get; set; }
        public int IdPerfil { get; set; }
    }
}
