using Simed.Data;
using Simed.Entity.SisInternoSelect.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Business
{
    public class SisInternoSelectBL : IDisposable
    {
        private SisInternoSelectDA objSisInternoSelectDL;

        public SisInternoSelectBL(string ConStr)
        {
            objSisInternoSelectDL = new SisInternoSelectDA(ConStr);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<CategoriaClienteListResponse> GetCategoriaCliente ()
        {
            var Data = objSisInternoSelectDL.GetCategoriaCliente();
            return Data;
        }

        public List<PreciosListResponse> GetPrecios()
        {
            var Data = objSisInternoSelectDL.GetPrecios();
            return Data;
        }

        public List<TipoIdentificacionListResponse> GetTipoIdentificacion()
        {
            var Data = objSisInternoSelectDL.GetTipoIdentificacion();
            return Data;
        }

        public List<TipoContribuyenteListResponse> GetTipoContribuyente()
        {
            var Data = objSisInternoSelectDL.GetTipoContribuyente();
            return Data;
        }

        public List<TipoSociedadListResponse> GetTipoSociedad()
        {
            var Data = objSisInternoSelectDL.GetTipoSociedad();
            return Data;
        }

        public List<OrigenCapitalListResponse> GetOrigenCapital()
        {
            var Data = objSisInternoSelectDL.GetOrigenCapital();
            return Data;
        }
        public List<PaisListResponse> GetPais()
        {
            var Data = objSisInternoSelectDL.GetPais();
            return Data;
        }

        public List<ActividadEconomicaListResponse> GetActividadEconomica()
        {
            var Data = objSisInternoSelectDL.GetActividadEconomica();
            return Data;
        }

        public List<RegimenListResponse> GetRegimen()
        {
            var Data = objSisInternoSelectDL.GetRegimen();
            return Data;
        }

        public List<NacionalidadListResponse> GetNacionalidad()
        {
            var Data = objSisInternoSelectDL.GetNacionalidad();
            return Data;
        }

        public List<BiocienciasListResponse> GetBiociencias()
        {
            var Data = objSisInternoSelectDL.GetBiociencias();
            return Data;
        }

        public List<SubUnidadListResponse> GetSubUnidad()
        {
            var Data = objSisInternoSelectDL.GetSubUnidad();
            return Data;
        }

        public List<AsesorComercialListResponse> GetAsesorComercial()
        {
            var Data = objSisInternoSelectDL.GetAsesorComercial();
            return Data;
        }
    }
}
