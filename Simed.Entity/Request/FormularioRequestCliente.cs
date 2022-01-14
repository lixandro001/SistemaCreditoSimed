using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity.Request
{
    public class FormularioRequestCliente
    {
        public int IdUsuario { get; set; }
        public int IdPerfil { get; set; }
        public string NombreRazonSocialDG { get; set; }
        public string DireccionDG { get; set; }
        public string PaisId { get; set; }
        public string CiudadPrinciaplDDG { get; set; }
        public string TelefonoFijoDG { get; set; }
        public string CelularDG { get; set; }
        public string CorreoElecontronicoDG { get; set; }
        public string DireccionFacturaDG { get; set; }
        public string CiudadFacturaDG { get; set; }
        public string DireccionPedidoDG { get; set; }
        public string CiudadPedidoDG { get; set; }
        public string DireccionPedidoSecundarioDG { get; set; }
        public string CiudadPedidoSecundarioDG { get; set; }
        public string NombreContactoAreaCobranza { get; set; }
        public string TelefonoContactoAreaCobranza { get; set; }
        public string CorreoContactoAreaCobranza { get; set; }
        public string NombreContactoAreaFinanciera { get; set; }
        public string TelefonoContactoAreaFinanciera { get; set; }
        public string CorreoContactoAreaFinanciera { get; set; }
        public string NombreContactoAreaComercial { get; set; }
        public string TelefonoContactoAreaComercial { get; set; }
        public string CorreoContactoAreaComercial { get; set; }
        public string TipoIdentificacionIdIT { get; set; }
        public string CualIdentificacionIT { get; set; }
        public string NumeroIdentificacionIT { get; set; }
        public string cboTipoContribuyente { get; set; }
        public string cboTipoSociedad { get; set; }
        public string txtCualSociedadIT { get; set; }
        public string cboOrigenCapital { get; set; }
        public string cboActividadEconomica { get; set; }
        public string txtCualEconomicaIT { get; set; }
        public string txtSuperIntendenciaIT { get; set; }
        public string txtFechaConstitucionIT { get; set; }
        public string cboRegimen { get; set; }
        public string txtActividadPrincipalIAE { get; set; }
        public string txtActividadSecundariaIAE { get; set; }
        public string txtNombreRepresentanteLegalIRL { get; set; }
        public string cboTipoIdenticacionLegal { get; set; }
        public string txtNumeroIdentificacionIRL { get; set; }
        public string cboNacionalidad { get; set; }
        public string txtCualIRL { get; set; }
        public string txtFechaExpedicionDocumentoIRL { get; set; }
        public string txtDireccionResidenciaIRL { get; set; }
        public string txtCiudadIRL { get; set; }
        public bool checkGozaPEP { get; set; }
        public string txtEspecifiqueGozaPEP { get; set; }
        public bool checkManejaPEP { get; set; }
        public string txtEspecifiqueManejaPEP { get; set; }
        public bool checkOcupaPEP { get; set; }
        public string txtEspecifiqueOcupaPEP { get; set; }
        public bool checkVinculo1PEP { get; set; }
        public string txtEspecifiqueVinculo1PEP { get; set; }
        public bool checkVinculo2PEP { get; set; }
        public string txtEspecifiqueVinculo2PEP { get; set; }
        public string txtNombreApellidoPEP { get; set; }
        public string txtCargoPEP { get; set; }
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
        public string txtInstitucionRB { get; set; }
        public string txtNroCuentaRB { get; set; }
        public string txtTipoCuentaRB { get; set; }
        public string txtBeneficiarioRB { get; set; }
        public string txtEmpresaRB { get; set; }
        public string txtRucRB { get; set; }
        public string txtTelefonoRB { get; set; }
        public string txtDireccionRB { get; set; }
        public string cboUnidad { get; set; }
        public string cboSubUnidad { get; set; }
        public string cboAsesorComercial { get; set; }
        public string txtDescripcion { get; set; }
        public string cboTipoPago { get; set; }
        public string cuposolicitado { get; set; }
        public string txtAsesorComercialVUI { get; set; }
        public string Filename1 { get; set; }
        public string Filename2 { get; set; }
        public string Filename3 { get; set; }
        public string Filename4 { get; set; }
        public string Filename5 { get; set; }
        public string Filename6 { get; set; }
        public string Filename7 { get; set; }
        public string Filename8 { get; set; }
        public string Filename9 { get; set; }
        public string Filename10 { get; set; }
        public string Filename11 { get; set; }
        public string Filename12 { get; set; }
        public string Filename13 { get; set; }
        public string ruta1 { get; set; }
        public string ruta2 { get; set; }
        public string ruta3 { get; set; }
        public string ruta4 { get; set; }
        public string ruta5 { get; set; }
        public string ruta6 { get; set; }
        public string ruta7 { get; set; }
        public string ruta8 { get; set; }
        public string ruta9 { get; set; }
        public string ruta10 { get; set; }
        public string ruta11 { get; set; }
        public string ruta12 { get; set; }
        public string ruta13 { get; set; }
        public int IdEstadosCliente { get; set; }
        public string code { get; set; }
        public string tokenCode { get; set; }
        public int btnEnvio { get; set; }

        //---detealle list refererncias comerciales--//
        public List<ReferenciasComercialesArray> DetalleReferenciasComerciales { get; set; }
        public List<UnicamentePersonaJuridicas> DetalleUnicamentePersonaJuridicas { get; set; }
    }

    public class ReferenciasComercialesArray
    {
        public string Empresa { get; set; }
        public string Ruc { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
    }

    public class UnicamentePersonaJuridicas
    {
        public bool CompañiaCuentaAccionistas { get; set; }
        public string NombreApellidoAccionistas { get; set; }
        public string TipoId { get; set; }
        public string NroDocumento { get; set; }
        public string Participacion { get; set; }
        public string Nacionalidad { get; set; }
    }

}
