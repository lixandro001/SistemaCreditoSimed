using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Simed.Business;
using Simed.Entity;
using Simed.Entity.Request;
using Simed.Entity.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimedCredito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormularioClienteController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly ILogger Logger;
        private FormularioClienteBL objFormularioClienteBL;

        public FormularioClienteController(IConfiguration IConfiguration, ILoggerFactory LoggerFactory)
        {
            Configuration = IConfiguration;
            Logger = LoggerFactory.CreateLogger<FormularioClienteController>();
            objFormularioClienteBL = new FormularioClienteBL(Configuration["ConnectionStrings:SIMED"]);

        }


        [HttpPost]
        [Route("GuardarClienteFormulario")]
        public IActionResult GuardarClienteFormulario(FormularioRequestCliente request)
        {
            try
            {
                EnviarFromulatioRequestCliente Body = new EnviarFromulatioRequestCliente();

                string secretTokenName = "Auth-Token";
                var tokenCode = HttpContext.Request.Headers[secretTokenName].ToString();
                request.tokenCode = tokenCode;

                Body.IdUsuario = request.IdUsuario;
                Body.IdPerfil = request.IdPerfil;
                Body.NombreRazonSocialDG = request.NombreRazonSocialDG;
                Body.DireccionDG = request.DireccionDG;
                Body.PaisId = request.PaisId;
                Body.CiudadPrinciaplDDG = request.CiudadPrinciaplDDG;
                Body.TelefonoFijoDG = request.TelefonoFijoDG;
                Body.CelularDG = request.CelularDG;
                Body.CorreoElecontronicoDG = request.CorreoElecontronicoDG;
                Body.DireccionFacturaDG = request.DireccionFacturaDG;
                Body.CiudadFacturaDG = request.CiudadFacturaDG;
                Body.DireccionPedidoDG = request.DireccionPedidoDG;
                Body.CiudadPedidoDG = request.CiudadPedidoDG;
                Body.DireccionPedidoSecundarioDG = request.DireccionPedidoSecundarioDG;
                Body.CiudadPedidoSecundarioDG = request.CiudadPedidoSecundarioDG;
                Body.NombreContactoAreaCobranza = request.NombreContactoAreaCobranza;
                Body.TelefonoContactoAreaCobranza = request.TelefonoContactoAreaCobranza;
                Body.CorreoContactoAreaCobranza = request.CorreoContactoAreaCobranza;
                Body.NombreContactoAreaFinanciera = request.NombreContactoAreaFinanciera;
                Body.TelefonoContactoAreaFinanciera = request.TelefonoContactoAreaFinanciera;
                Body.CorreoContactoAreaFinanciera = request.CorreoContactoAreaFinanciera;
                Body.NombreContactoAreaComercial = request.NombreContactoAreaComercial;
                Body.TelefonoContactoAreaComercial = request.TelefonoContactoAreaComercial;
                Body.CorreoContactoAreaComercial = request.CorreoContactoAreaComercial;
                Body.TipoIdentificacionIdIT = request.TipoIdentificacionIdIT == "" ? 0 : Convert.ToInt32(request.TipoIdentificacionIdIT);
                Body.CualIdentificacionIT = request.CualIdentificacionIT;
                Body.NumeroIdentificacionIT = request.NumeroIdentificacionIT;
                Body.cboTipoContribuyente = request.cboTipoContribuyente == "" ? 0 : Convert.ToInt32(request.cboTipoContribuyente);
                Body.cboTipoSociedad = request.cboTipoSociedad == "" ? 0 : Convert.ToInt32(request.cboTipoSociedad);
                Body.txtCualSociedadIT = request.txtCualSociedadIT;
                Body.cboOrigenCapital = request.cboOrigenCapital == "" ? 0 : Convert.ToInt32(request.cboOrigenCapital);
                Body.cboActividadEconomica = request.cboActividadEconomica == "" ? 0 : Convert.ToInt32(request.cboActividadEconomica);
                Body.txtCualEconomicaIT = request.txtCualEconomicaIT;
                Body.txtSuperIntendenciaIT = request.txtSuperIntendenciaIT;
                Body.txtFechaConstitucionIT = request.txtFechaConstitucionIT == "" ? DateTime.Now : Convert.ToDateTime(request.txtFechaConstitucionIT);
                Body.cboRegimen = request.cboRegimen == "" ? 0 : Convert.ToInt32(request.cboRegimen);
                Body.txtActividadPrincipalIAE = request.txtActividadPrincipalIAE;
                Body.txtActividadSecundariaIAE = request.txtActividadSecundariaIAE;
                Body.txtNombreRepresentanteLegalIRL = request.txtNombreRepresentanteLegalIRL;
                Body.cboTipoIdenticacionLegal = request.cboTipoIdenticacionLegal == "" ? 0 : Convert.ToInt32(request.cboTipoIdenticacionLegal);
                Body.txtNumeroIdentificacionIRL = request.txtNumeroIdentificacionIRL;
                Body.cboNacionalidad = request.cboNacionalidad == "" ? 0 : Convert.ToInt32(request.cboNacionalidad);
                Body.txtCualIRL = request.txtCualIRL;
                Body.txtFechaExpedicionDocumentoIRL = request.txtFechaExpedicionDocumentoIRL == "" ? DateTime.Now : Convert.ToDateTime(request.txtFechaExpedicionDocumentoIRL);
                Body.txtDireccionResidenciaIRL = request.txtDireccionResidenciaIRL;
                Body.txtCiudadIRL = request.txtCiudadIRL;
                Body.checkGozaPEP = request.checkGozaPEP;
                Body.txtEspecifiqueGozaPEP = request.txtEspecifiqueGozaPEP;
                Body.checkManejaPEP = request.checkManejaPEP;
                Body.txtEspecifiqueManejaPEP = request.txtEspecifiqueManejaPEP;
                Body.checkOcupaPEP = request.checkOcupaPEP;
                Body.txtEspecifiqueOcupaPEP = request.txtEspecifiqueOcupaPEP;
                Body.checkVinculo1PEP = request.checkVinculo1PEP;
                Body.txtEspecifiqueVinculo1PEP = request.txtEspecifiqueVinculo1PEP;
                Body.checkVinculo2PEP = request.checkVinculo2PEP;
                Body.txtEspecifiqueVinculo2PEP = request.txtEspecifiqueVinculo2PEP;
                Body.txtNombreApellidoPEP = request.txtNombreApellidoPEP;
                Body.txtCargoPEP = request.txtCargoPEP;
                Body.FechaCorte = request.FechaCorte == "" ? DateTime.Now : Convert.ToDateTime(request.FechaCorte);
                Body.checkSolesIF = request.checkSolesIF;
                Body.checkDolaresIF = request.checkDolaresIF;
                Body.txtActivosIF = request.txtActivosIF == "" ? 0 : Convert.ToDecimal(request.txtActivosIF);
                Body.txtIngresosMensualesIF = request.txtIngresosMensualesIF == "" ? 0 : Convert.ToDecimal(request.txtIngresosMensualesIF);
                Body.txtPasivosIF = request.txtPasivosIF == "" ? 0 : Convert.ToDecimal(request.txtPasivosIF);
                Body.txtEgresosMensualesIF = request.txtEgresosMensualesIF == "" ? 0 : Convert.ToDecimal(request.txtEgresosMensualesIF);
                Body.txtPatrimonioIF = request.txtPatrimonioIF == "" ? 0 : Convert.ToDecimal(request.txtPatrimonioIF);
                Body.txtOtrosIngresosIF = request.txtOtrosIngresosIF == "" ? 0 : Convert.ToDecimal(request.txtOtrosIngresosIF);
                Body.txtConceptoOtrosIngresosIF = request.txtConceptoOtrosIngresosIF;
                Body.txtInstitucionRB = request.txtInstitucionRB;
                Body.txtNroCuentaRB = request.txtNroCuentaRB;
                Body.txtTipoCuentaRB = request.txtTipoCuentaRB;
                Body.txtBeneficiarioRB = request.txtBeneficiarioRB;
                Body.txtEmpresaRB = request.txtEmpresaRB;
                Body.txtRucRB = request.txtRucRB;
                Body.txtTelefonoRB = request.txtTelefonoRB;
                Body.txtDireccionRB = request.txtDireccionRB;
                Body.cboUnidad = request.cboUnidad == "" ? 0 : Convert.ToInt32(request.cboUnidad);
                Body.cboSubUnidad = request.cboSubUnidad == "" ? 0 : Convert.ToInt32(request.cboSubUnidad);
                Body.cboAsesorComercial = request.cboAsesorComercial == "" ? 0 : Convert.ToInt32(request.cboAsesorComercial);
                Body.txtDescripcion = request.txtDescripcion;
                Body.cboTipoPago = request.cboTipoPago == "" ? 0 : Convert.ToInt32(request.cboTipoPago);
                Body.cuposolicitado = request.cuposolicitado;
                Body.txtAsesorComercialVUI = request.txtAsesorComercialVUI;
                Body.Filename1 = request.Filename1;
                Body.Filename2 = request.Filename2;
                Body.Filename3 = request.Filename3;
                Body.Filename4 = request.Filename4;
                Body.Filename5 = request.Filename5;
                Body.Filename6 = request.Filename6;
                Body.Filename7 = request.Filename7;
                Body.Filename8 = request.Filename8;
                Body.Filename9 = request.Filename9;
                Body.Filename10 = request.Filename10;
                Body.Filename11 = request.Filename11;
                Body.Filename12 = request.Filename12;
                Body.Filename13 = request.Filename13;
                Body.ruta1 = request.ruta1;
                Body.ruta2 = request.ruta2;
                Body.ruta3 = request.ruta3;
                Body.ruta4 = request.ruta4;
                Body.ruta5 = request.ruta5;
                Body.ruta6 = request.ruta6;
                Body.ruta7 = request.ruta7;
                Body.ruta8 = request.ruta8;
                Body.ruta9 = request.ruta9;
                Body.ruta10 = request.ruta10;
                Body.ruta11 = request.ruta11;
                Body.ruta12 = request.ruta12;
                Body.ruta13 = request.ruta13;
                Body.IdEstadosCliente = request.IdEstadosCliente;
                Body.code = request.code;
                Body.tokenCode = request.tokenCode;
                Body.DetalleReferenciasComerciales = request.DetalleReferenciasComerciales;
                Body.DetalleUnicamentePersonaJuridicas = request.DetalleUnicamentePersonaJuridicas;
                Body.btnEnvio = request.btnEnvio;

                int resul = objFormularioClienteBL.GuardarFormulario(Body);
                return Ok(resul);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                throw ex;
            }
        }

        [HttpGet]
        [Route("DataByCode/{Code}")]
        public IActionResult DataByCode(string Code)
        {
            try
            {
                var response = new GenericResponse();
                var data = objFormularioClienteBL.DataByCode(Code);
                response.code = (int)Enums.eCodeError.OK;
                response.Data = data;
                return Ok(response);
            }
            catch (Exception ex)
            {
                Logger.LogWarning(ex.Message);
                Logger.LogError(ex.Message);
                throw ex;
            }
        }

        [HttpGet]
        [Route("DataUsuario/{CodeUsuario}")]
        public IActionResult DataUsuario(string CodeUsuario)
        {
            try
            {
                var response = new GenericResponse();
                var data = objFormularioClienteBL.DataUsuario(CodeUsuario);
                response.code = (int)Enums.eCodeError.OK;
                response.Data = data;
                return Ok(response);
            }
            catch (Exception ex)
            {
                Logger.LogWarning(ex.Message);
                Logger.LogError(ex.Message);
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetListadoUsuario")]
        public IActionResult GetListadoUsuario()
        {
            try
            { 
                var response = new GenericResponse();
                var data = objFormularioClienteBL.GetListadoUsuario();
                response.code = (int)Enums.eCodeError.OK;
                response.Data = data;
                return Ok(response);
            }
            catch (Exception ex)
            {
                Logger.LogWarning(ex.Message);
                Logger.LogError(ex.Message);
                throw ex;
            }
        }
         
        [HttpPost]
        [Route("AprobarFormularioCliente")]
        public IActionResult AprobarFormularioCliente(UpdateEstadoYPerfilRequest request)
        {
            try
            {
                GenericResponse response = new GenericResponse();

                if (objFormularioClienteBL.AprobarFormularioCliente(request))
                {
                    response.code = (int)Enums.eCodeError.OK;
                    response.message = "Se Aprobó Correctamente";
                }
                else
                {
                    response.code = (int)Enums.eCodeError.ERROR;
                    response.message = "No se pudo Aprobar";
                }
                return Ok(response);

            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                throw ex;
            }
        }

        [HttpPost]
        [Route("RechazarFormularioCliente")]
        public IActionResult RechazarFormularioCliente(UpdateEstadoYPerfilRequest request)
        {
            try
            {
                GenericResponse response = new GenericResponse();

                if (objFormularioClienteBL.RechazarFormularioCliente(request))
                {
                    response.code = (int)Enums.eCodeError.OK;
                    response.message = "Se Rechazó Correctamente";
                }
                else
                {
                    response.code = (int)Enums.eCodeError.ERROR;
                    response.message = "No se pudo Rechazar";
                }
                return Ok(response);

            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                throw ex;
            }
        }



        [HttpPost]
        [Route("eliminarUsuarios")]
        public IActionResult eliminarUsuarios(EliminarUsuarioRequest request)
        {
            try
            {
                GenericResponse response = new GenericResponse();

                if (objFormularioClienteBL.eliminarUsuarios(request))
                {
                    response.code = (int)Enums.eCodeError.OK;
                    response.message = "Se Rechazó Correctamente";
                }
                else
                {
                    response.code = (int)Enums.eCodeError.ERROR;
                    response.message = "No se pudo Rechazar";
                }
                return Ok(response);

            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                throw ex;
            }
        }


        [HttpPost]
        [Route("InsertarEvaluacionDocumento")]
        public IActionResult InsertarEvaluacionDocumento(InsertarEvaluacionDocumento request)
        {
            try
            {
                GenericResponse response = new GenericResponse();
                var valor = objFormularioClienteBL.InsertarEvaluacionDocumento(request);

                if (valor== "guardado")
                {
                    response.code = (int)Enums.eCodeError.OK;
                    response.message = "Se Guardo Correctmante";
                }
                else if(valor== "existe")
                {
                    response.code = (int)Enums.eCodeError.ERROR;
                    response.message = "Este Documento Ya Existe";
                }
                else
                {
                    response.code = (int)Enums.eCodeError.VAL;
                    response.message = "No se Pudo Guardar Comuniquese con el area de sistemas";
                }
                return Ok(response);

            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                throw ex;
            }
        } 

        [HttpPost]
        [Route("guardarUsuarios")]
        public IActionResult guardarUsuarios(UsuariosRequest request)
        {
            try
            {
                GenericResponse response = new GenericResponse();
                var valor = objFormularioClienteBL.guardarUsuarios(request);

                if (valor == "guardado")
                {
                    response.code = (int)Enums.eCodeError.OK;
                    response.message = "Se Guardo Correctmante";
                }
                else if (valor == "existe")
                {
                    response.code = (int)Enums.eCodeError.ERROR;
                    response.message = "Este Usuario Ya Existe";
                }
                else
                {
                    response.code = (int)Enums.eCodeError.VAL;
                    response.message = "No se Pudo Guardar Comuniquese con el area de sistemas";
                }
                return Ok(response);

            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                throw ex;
            }
        }
         

    }
}
