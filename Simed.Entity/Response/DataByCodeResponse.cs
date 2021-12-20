using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity.Response
{
    public class DataByCodeResponse
    {
        //---Datos generales
        public string Nombre_RazonSocialDatosGenerales { get; set; }
        public string DireccionDatosGenerales { get; set; }
        public string Nombre_S_PAIS { get; set; }
        public string CiudadSedePrincipalDatosGenerales { get; set; }
        public string TelefonoFijoDatosGenerales { get; set; }
        public string CelularDatosGenerales { get; set; }
        public string CorreoEnvioFacturaElectronicaDatosGenerales { get; set; }
        public string DireccionEntregaFacturaDatosGenerales { get; set; }
        public string CiudadDireccionEntregaFacturaDatosGenerales { get; set; }
        public string DireccionEntregaPedidoDatosGenerales { get; set; }
        public string CiudadDireccionEntregaPedidoDatosGenerales { get; set; }
        public string DireccionSecundariaEntregaPedidoDatosGenerales { get; set; }
        public string CiudadDireccionSecundariaEntregaPedidoDatosGenerales { get; set; }
        //--INFORMACIÓN DE CONTACTOS
        public string NombreContactoAreaCobranza { get; set; }
        public string TelefonoContactoAreaCobranza { get; set; }
        public string CorreoElectronicoContactoAreaCobranza { get; set; }
        public string NombreContactoAreaFinanciera { get; set; }
        public string TelefonoContactoAreaFinanciera { get; set; }
        public string CorreoContactoAreaFinanciera { get; set; }
        public string NombreContactoAreaComercial { get; set; }
        public string TelefonoContactoAreaComercial { get; set; }
        public string CorreoContactoAreaComercial { get; set; }
        //-- INFORMACIÓN TRIBUTARIA
        public string Nombre_S_TIPO_IDENTIFICACION { get; set; }
        public string CualTipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Nombre_S_TIPO_CONTRIBUYENTE { get; set; }
        public string Nombre_S_TIPO_SOCIEDAD { get; set; }
        public string CualTipoSociedad { get; set; }
        public string Nombre_S_ORIGEN_CAPITAL { get; set; }
        public string Nombre_S_ACTIVIDAD_ECONOMICA { get; set; }
        public string CualActividadEconomica { get; set; }
        public string TitularVigiladoPorAlgunaSuperIntendencia { get; set; }
        public DateTime FechaConstitucion { get; set; }
        public string Nombre_S_REGIMEN { get; set; }
        public string CFechaConstitucion
        {
            get
            {
                if (FechaConstitucion != null)
                {
                    return string.Format("{0:dd/MM/yyyy}", FechaConstitucion);
                }
                return string.Empty;
            }
        }
        //--INFORMACIÓN ACTIVIDAD ECONÓMICA
        public string ActidadPrincipal { get; set; }
        public string ActividadSecundaria { get; set; }
        //--INFORMACION DE REPRESENTACION LEGAL
        public string NombreRepresentanteLegal { get; set; }
        public string Nombre_S_TIPO_IDENTIFICACION_RL { get; set; }
        public string NumeroIdentificacion_RL { get; set; }
        public string Nombre_S_NACIONALIDAD { get; set; }
        public string CualNacionalidad { get; set; }
        public DateTime FechaExpedicionDocumento { get; set; }
        public string DireccionResidencia { get; set; }
        public string Ciudad_RL { get; set; }
        public string CFechaExpedicionDocumento
        {
            get
            {
                if (FechaExpedicionDocumento != null)
                {
                    return string.Format("{0:dd/MM/yyyy}", FechaExpedicionDocumento);
                }
                return string.Empty;
            }
        }
        //--PREGUNTAS PEP
        public bool GozaReconocimientoPublico { get; set; }
        public string EspecifiqueGozaReconocimientoPublico { get; set; }
        public bool ManejaRecursosPublicos { get; set; }
        public string EspecifiqueManejaRecursosPublicos { get; set; }
        public bool OcupaCargosPublicos { get; set; }
        public string EspecifiqueOcupaCargosPublicos { get; set; }
        public bool ExisteVinculoEntreUstedPersonaPublicamenteExpuesta { get; set; }
        public string EspecifiqueExisteVinculoEntreUstedPersonaPublicamenteExpuesta { get; set; }
        public bool ExisteVinculoDiferenteComercialFamiliarPersonalEmpleadoSimed { get; set; }
        public string EspecifiqueExisteVinculoDiferenteComercialFamiliarPersonalEmpleadoSimed { get; set; }
        public string CasoAfirmativoEspecifiquePersonaConVinculo { get; set; }
        public string Cargo { get; set; }
        //--INFORMACIÓN DE SOCIOS O ACCIONISTAS (UNICAMENTE APLICA PARA PERSONAS JURIDICAS) --- pendiente --- G
        //--INFORMACIÓN FINANCIERA
        public DateTime FechaCorte { get; set; }
        public bool InformacionDebeSoles { get; set; }
        public bool InformacionDebeDolares { get; set; }
        public decimal Activos { get; set; }
        public decimal Pasivos { get; set; }
        public decimal Patrimonio { get; set; }
        public decimal IngresoMensual { get; set; }
        public decimal EgresoMensual { get; set; }
        public decimal OtrosIngresos { get; set; }
        public string ConceptoOtrosIngresos { get; set; }
        public string CFechaCorte
        {
            get
            {
                if (FechaCorte != null)
                {
                    return string.Format("{0:dd/MM/yyyy}", FechaCorte);
                }
                return string.Empty;
            }
        }
    }
}
