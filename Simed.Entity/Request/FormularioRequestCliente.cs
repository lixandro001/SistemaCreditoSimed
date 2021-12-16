using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity.Request
{
    public class FormularioRequestCliente
    {
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
        public int cboTipoContribuyente { get; set; }
        public int cboTipoSociedad { get; set; }
        public string txtCualSociedadIT { get; set; }
        public int cboOrigenCapital { get; set; }
        public int cboActividadEconomica { get; set; }
        public string txtCualEconomicaIT { get; set; }
        public string txtSuperIntendenciaIT { get; set; }
        public DateTime txtFechaConstitucionIT { get; set; }
        public int cboRegimen { get; set; }
        public string txtActividadPrincipalIAE { get; set; }
        public string txtActividadSecundariaIAE { get; set; }
        public string txtNombreRepresentanteLegalIRL { get; set; }
        public int cboTipoIdenticacionLegal { get; set; }
        public string txtNumeroIdentificacionIRL { get; set; }
        public int cboNacionalidad { get; set; }
        public string txtCualIRL { get; set; }
        public DateTime txtFechaExpedicionDocumentoIRL { get; set; }
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
        public DateTime FechaCorte { get; set; }
        public bool checkSolesIF { get; set; }
        public bool checkDolaresIF { get; set; }
        public decimal txtActivosIF { get; set; }
        public decimal txtIngresosMensualesIF { get; set; }
        public decimal txtPasivosIF { get; set; }
        public decimal txtEgresosMensualesIF { get; set; }
        public decimal txtPatrimonioIF { get; set; }
        public decimal txtOtrosIngresosIF { get; set; }
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

        public string tokenCode { get; set; }

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
