using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Simed.Entity;
using Simed.Entity.Request;
using Simed.Entity.Response;
using Simed.Utilities.General;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimedCredito.Web.Controllers
{
    public class FormularioClienteController : Controller
    {

        private readonly IConfiguration Configuration;
        private readonly ILogger Logger;
        private readonly IHostingEnvironment HostingEnvironment;

        public FormularioClienteController(IConfiguration IConfiguration, ILoggerFactory LoggerFactory, IHostingEnvironment IHostingEnvironment)
        {
            HostingEnvironment = IHostingEnvironment;
            Configuration = IConfiguration;
            Logger = LoggerFactory.CreateLogger<FormularioClienteController>();
            GeneralModel.UrlWebApi = Configuration["Urls:UrlWebApi"];
  
        }

        public IActionResult GuardarFormularioCliente(IFormFile FormFile1, IFormFile FormFile2, IFormFile FormFile3, IFormFile FormFile4, IFormFile FormFile5,
            IFormFile FormFile6, IFormFile FormFile7, IFormFile FormFile8, IFormFile FormFile9, IFormFile FormFile10, 
            IFormFile FormFile11, IFormFile FormFile12, IFormFile FormFile13)
        {
            var Response = new GenericObjectResponse();

            try
            {
                var NombreRazonSocialDG = Request.Form["NombreRazonSocialDG"];
                var DireccionDG = Request.Form["DireccionDG"];
                var PaisId = Request.Form["PaisId"];
                var CiudadPrinciaplDDG = Request.Form["CiudadPrinciaplDDG"];
                var TelefonoFijoDG = Request.Form["TelefonoFijoDG"];
                var CelularDG = Request.Form["CelularDG"];
                var CorreoElecontronicoDG = Request.Form["CorreoElecontronicoDG"];
                var DireccionFacturaDG = Request.Form["DireccionFacturaDG"];
                var CiudadFacturaDG = Request.Form["CiudadFacturaDG"];
                var DireccionPedidoDG = Request.Form["DireccionPedidoDG"];
                var CiudadPedidoDG = Request.Form["CiudadPedidoDG"];
                var DireccionPedidoSecundarioDG = Request.Form["DireccionPedidoSecundarioDG"];
                var CiudadPedidoSecundarioDG = Request.Form["CiudadPedidoSecundarioDG"];
                var NombreContactoAreaCobranza = Request.Form["NombreContactoAreaCobranza"];
                var TelefonoContactoAreaCobranza = Request.Form["TelefonoContactoAreaCobranza"];
                var CorreoContactoAreaCobranza = Request.Form["CorreoContactoAreaCobranza"];
                var NombreContactoAreaFinanciera = Request.Form["NombreContactoAreaFinanciera"];
                var TelefonoContactoAreaFinanciera = Request.Form["TelefonoContactoAreaFinanciera"];
                var CorreoContactoAreaFinanciera = Request.Form["CorreoContactoAreaFinanciera"];
                var NombreContactoAreaComercial = Request.Form["NombreContactoAreaComercial"];
                var TelefonoContactoAreaComercial = Request.Form["TelefonoContactoAreaComercial"];
                var CorreoContactoAreaComercial = Request.Form["CorreoContactoAreaComercial"];
                var TipoIdentificacionIdIT = Request.Form["TipoIdentificacionIdIT"];
                var CualIdentificacionIT = Request.Form["CualIdentificacionIT"];
                var NumeroIdentificacionIT = Request.Form["NumeroIdentificacionIT"];
                var cboTipoContribuyente = Request.Form["cboTipoContribuyente"];
                var cboTipoSociedad = Request.Form["cboTipoSociedad"];
                var txtCualSociedadIT = Request.Form["txtCualSociedadIT"];
                var cboOrigenCapital = Request.Form["cboOrigenCapital"];
                var cboActividadEconomica = Request.Form["cboActividadEconomica"];
                var txtCualEconomicaIT = Request.Form["txtCualEconomicaIT"];
                var txtSuperIntendenciaIT = Request.Form["txtSuperIntendenciaIT"];
                var txtFechaConstitucionIT = Request.Form["txtFechaConstitucionIT"];
                var cboRegimen = Request.Form["cboRegimen"];
                var txtActividadPrincipalIAE = Request.Form["txtActividadPrincipalIAE"];
                var txtActividadSecundariaIAE = Request.Form["txtActividadSecundariaIAE"];
                var txtNombreRepresentanteLegalIRL = Request.Form["txtNombreRepresentanteLegalIRL"];
                var cboTipoIdenticacionLegal = Request.Form["cboTipoIdenticacionLegal"];
                var txtNumeroIdentificacionIRL = Request.Form["txtNumeroIdentificacionIRL"];
                var cboNacionalidad = Request.Form["cboNacionalidad"];
                var txtCualIRL = Request.Form["txtCualIRL"];
                var txtFechaExpedicionDocumentoIRL = Request.Form["txtFechaExpedicionDocumentoIRL"];
                var txtDireccionResidenciaIRL = Request.Form["txtDireccionResidenciaIRL"];
                var txtCiudadIRL = Request.Form["txtCiudadIRL"];
                var checkGozaPEP = Request.Form["checkGozaPEP"];
                var txtEspecifiqueGozaPEP = Request.Form["txtEspecifiqueGozaPEP"];
                var checkManejaPEP = Request.Form["checkManejaPEP"];
                var txtEspecifiqueManejaPEP = Request.Form["txtEspecifiqueManejaPEP"];
                var checkOcupaPEP = Request.Form["checkOcupaPEP"];
                var txtEspecifiqueOcupaPEP = Request.Form["txtEspecifiqueOcupaPEP"];
                var checkVinculo1PEP = Request.Form["checkVinculo1PEP"];
                var txtEspecifiqueVinculo1PEP = Request.Form["txtEspecifiqueVinculo1PEP"];
                var checkVinculo2PEP = Request.Form["checkVinculo2PEP"];
                var txtEspecifiqueVinculo2PEP = Request.Form["txtEspecifiqueVinculo2PEP"];
                var txtNombreApellidoPEP = Request.Form["txtNombreApellidoPEP"];
                var txtCargoPEP = Request.Form["txtCargoPEP"];
                var checkAccionistaISA = Request.Form["checkAccionistaISA"];
                var txtNombreApellidoAccionista1ISA = Request.Form["txtNombreApellidoAccionista1ISA"];
                var txtTipoIdAccionista1ISA = Request.Form["txtTipoIdAccionista1ISA"];
                var txtNroDocumentoAccionista1ISA = Request.Form["txtNroDocumentoAccionista1ISA"];
                var txtParticipacionAccionista1ISA = Request.Form["txtParticipacionAccionista1ISA"];
                var txtNacionalidadAccionista1ISA = Request.Form["txtNacionalidadAccionista1ISA"];
                var txtNombreApellidoAccionista2ISA = Request.Form["txtNombreApellidoAccionista2ISA"];
                var txtTipoIdAccionista2ISA = Request.Form["txtTipoIdAccionista2ISA"];
                var txtNroDocumentoAccionista2ISA = Request.Form["txtNroDocumentoAccionista2ISA"];
                var txtParticipacionAccionista2ISA = Request.Form["txtParticipacionAccionista2ISA"];
                var txtNacionalidadAccionista2ISA = Request.Form["txtNacionalidadAccionista2ISA"];
                var txtNombreApellidoAccionista3ISA = Request.Form["txtNombreApellidoAccionista3ISA"];
                var txtTipoIdAccionista3ISA = Request.Form["txtTipoIdAccionista3ISA"];
                var txtNroDocumentoAccionista3ISA = Request.Form["txtNroDocumentoAccionista3ISA"];
                var txtParticipacionAccionista3ISA = Request.Form["txtParticipacionAccionista3ISA"];
                var txtNacionalidadAccionista3ISA = Request.Form["txtNacionalidadAccionista3ISA"];
                var txtNombreApellidoAccionista4ISA = Request.Form["txtNombreApellidoAccionista4ISA"];
                var txtTipoIdAccionista4ISA = Request.Form["txtTipoIdAccionista4ISA"];
                var txtNroDocumentoAccionista4ISA = Request.Form["txtNroDocumentoAccionista4ISA"];
                var txtParticipacionAccionista4ISA = Request.Form["txtParticipacionAccionista4ISA"];
                var txtNacionalidadAccionista4ISA = Request.Form["txtNacionalidadAccionista4ISA"];
                var FechaCorte = Request.Form["FechaCorte"];
                var checkSolesIF = Request.Form["checkSolesIF"];
                var checkDolaresIF = Request.Form["checkDolaresIF"];
                var txtActivosIF = Request.Form["txtActivosIF"];
                var txtIngresosMensualesIF = Request.Form["txtIngresosMensualesIF"];
                var txtPasivosIF = Request.Form["txtPasivosIF"];
                var txtEgresosMensualesIF = Request.Form["txtEgresosMensualesIF"];
                var txtPatrimonioIF = Request.Form["txtPatrimonioIF"];
                var txtOtrosIngresosIF = Request.Form["txtOtrosIngresosIF"];
                var txtConceptoOtrosIngresosIF = Request.Form["txtConceptoOtrosIngresosIF"];
                var txtEmpresa1RC = Request.Form["txtEmpresa1RC"];
                var txtRuc1RC = Request.Form["txtRuc1RC"];
                var txtTelefono1RC = Request.Form["txtTelefono1RC"];
                var txtDireccion1RC = Request.Form["txtDireccion1RC"];
                var txtCiudad1RC = Request.Form["txtCiudad1RC"];
                var txtEmpresa2RC = Request.Form["txtEmpresa2RC"];
                var txtRuc2RC = Request.Form["txtRuc2RC"];
                var txtTelefono2RC = Request.Form["txtTelefono2RC"];
                var txtDireccion2RC = Request.Form["txtDireccion2RC"];
                var txtCiudad2RC = Request.Form["txtCiudad2RC"];
                var txtInstitucionRB = Request.Form["txtInstitucionRB"];
                var txtNroCuentaRB = Request.Form["txtNroCuentaRB"];
                var txtTipoCuentaRB = Request.Form["txtTipoCuentaRB"];
                var txtBeneficiarioRB = Request.Form["txtBeneficiarioRB"];
                var txtEmpresaRB = Request.Form["txtEmpresaRB"];
                var txtRucRB = Request.Form["txtRucRB"];
                var txtTelefonoRB = Request.Form["txtTelefonoRB"];
                var txtDireccionRB = Request.Form["txtDireccionRB"];
                var cboUnidad = Request.Form["cboUnidad"];
                var cboSubUnidad = Request.Form["cboSubUnidad"];
                var cboAsesorComercial = Request.Form["cboAsesorComercial"];
                var txtDescripcion = Request.Form["txtDescripcion"];
                var cboTipoPago = Request.Form["cboTipoPago"];
                var cuposolicitado = Request.Form["cuposolicitado"];
                var txtAsesorComercialVUI = Request.Form["txtAsesorComercialVUI"];

                var exten1 = "";
                var exten2 = "";
                var exten3 = "";
                var exten4 = "";
                var exten5 = "";
                var exten6 = "";
                var exten7 = "";
                var exten8 = "";
                var exten9 = "";
                var exten10 = "";
                var exten11 = "";
                var exten12 = "";
                var exten13 = "";

                if (FormFile1 != null)
                {
                    var extension1 = FormFile1.ContentType;
                    var separar1 = extension1.Split("/");
                    var ext1 = separar1[1];
                    exten1 = ext1;
                }

                if (FormFile2 != null)
                {
                    var extension2 = FormFile2.ContentType;
                    var separar2 = extension2.Split("/");
                    var ext2 = separar2[1];
                    exten2 = ext2;
                }

                if (FormFile3 != null)
                {
                    var extension3 = FormFile3.ContentType;
                    var separar3 = extension3.Split("/");
                    var ext3 = separar3[1];
                    exten3 = ext3;
                }

                if (FormFile4 != null)
                {
                    var extension4 = FormFile4.ContentType;
                    var separar4 = extension4.Split("/");
                    var ext4 = separar4[1];
                    exten4 = ext4;
                }
                if (FormFile5 != null)
                {
                    var extension5 = FormFile5.ContentType;
                    var separar5 = extension5.Split("/");
                    var ext5 = separar5[1];
                    exten5 = ext5;
                }
                if (FormFile6 != null)
                {
                    var extension6 = FormFile6.ContentType;
                    var separar6 = extension6.Split("/");
                    var ext6 = separar6[1];
                    exten6 = ext6;
                }
                if (FormFile7 != null)
                {
                    var extension7 = FormFile7.ContentType;
                    var separar7 = extension7.Split("/");
                    var ext7 = separar7[1];
                    exten7 = ext7;
                }
                if (FormFile8 != null)
                {
                    var extension8 = FormFile8.ContentType;
                    var separar8 = extension8.Split("/");
                    var ext8 = separar8[1];
                    exten8 = ext8;
                }
                if (FormFile9 != null)
                {
                    var extension9 = FormFile9.ContentType;
                    var separar9 = extension9.Split("/");
                    var ext9 = separar9[1];
                    exten9 = ext9;
                }
                if (FormFile10 != null)
                {
                    var extension10 = FormFile10.ContentType;
                    var separar10 = extension10.Split("/");
                    var ext10 = separar10[1];
                    exten10 = ext10;
                }
                if (FormFile11 != null)
                {
                    var extension11 = FormFile11.ContentType;
                    var separar11 = extension11.Split("/");
                    var ext11 = separar11[1];
                    exten11 = ext11;
                }
                if (FormFile12 != null)
                {
                    var extension12 = FormFile12.ContentType;
                    var separar12 = extension12.Split("/");
                    var ext12 = separar12[1];
                    exten12 = ext12;
                }
                if (FormFile13 != null)
                {
                    var extension13 = FormFile13.ContentType;
                    var separar13 = extension13.Split("/");
                    var ext13 = separar13[1];
                    exten13 = ext13;
                }

                var BasePath = Path.Combine(HostingEnvironment.WebRootPath, "files");
                var fecha = DateTime.Now;
                var formatfecha = string.Format("{0:yyyyMMdd}", fecha);
                var formathora = string.Format("{0:HHmmss}", fecha);

                var Filename1 = "";
                var Filename2 = "";
                var Filename3 = "";
                var Filename4 = "";
                var Filename5 = "";
                var Filename6 = "";
                var Filename7 = "";
                var Filename8 = "";
                var Filename9 = "";
                var Filename10 = "";
                var Filename11 = "";
                var Filename12 = "";
                var Filename13 = "";
                var PathFilename1 = "";
                var PathFilename2 = "";
                var PathFilename3 = "";
                var PathFilename4 = "";
                var PathFilename5 = "";
                var PathFilename6 = "";
                var PathFilename7 = "";
                var PathFilename8 = "";
                var PathFilename9 = "";
                var PathFilename10 = "";
                var PathFilename11 = "";
                var PathFilename12 = "";
                var PathFilename13 = "";


                if (FormFile1 != null)
                {
                    Filename1 = string.Format("{0}_{1}_{2}_{3}.{4}", Guid.NewGuid(), txtRucRB, formatfecha, formathora, exten1);
                    PathFilename1 = Path.Combine(BasePath, Filename1);
                    //Preguntar si existe para Eliminarlo
                    if (System.IO.File.Exists(PathFilename1))
                    {
                        System.IO.File.Delete(PathFilename1);
                    }
                    //Copiar 
                    var document = new FileStream(PathFilename1, FileMode.Create);
                    FormFile1.CopyTo(document);
                    document.Flush();
                    document.Dispose();

                }
                if (FormFile2 != null)
                {
                    Filename2 = string.Format("{0}_{1}_{2}_{3}.{4}", Guid.NewGuid(), txtRucRB, formatfecha, formathora, exten2);
                    PathFilename2 = Path.Combine(BasePath, Filename2);
                    //Preguntar si existe para Eliminarlo
                    if (System.IO.File.Exists(PathFilename2))
                    {
                        System.IO.File.Delete(PathFilename2);
                    }
                    //Copiar 
                    var document = new FileStream(PathFilename2, FileMode.Create);
                    FormFile2.CopyTo(document);
                    document.Flush();
                    document.Dispose();

                }
                if (FormFile3 != null)
                {
                    Filename3 = string.Format("{0}_{1}_{2}_{3}.{4}", Guid.NewGuid(), txtRucRB, formatfecha, formathora, exten3);
                    PathFilename3 = Path.Combine(BasePath, Filename3);
                    //Preguntar si existe para Eliminarlo
                    if (System.IO.File.Exists(PathFilename3))
                    {
                        System.IO.File.Delete(PathFilename3);
                    }
                    //Copiar 
                    var document = new FileStream(PathFilename3, FileMode.Create);
                    FormFile3.CopyTo(document);
                    document.Flush();
                    document.Dispose();

                }
                if (FormFile4 != null)
                {
                    Filename4 = string.Format("{0}_{1}_{2}_{3}.{4}", Guid.NewGuid(), txtRucRB, formatfecha, formathora, exten4);
                    PathFilename4 = Path.Combine(BasePath, Filename4);
                    //Preguntar si existe para Eliminarlo
                    if (System.IO.File.Exists(PathFilename4))
                    {
                        System.IO.File.Delete(PathFilename4);
                    }
                    //Copiar 
                    var document = new FileStream(PathFilename4, FileMode.Create);
                    FormFile4.CopyTo(document);
                    document.Flush();
                    document.Dispose();

                }
                if (FormFile5 != null)
                {
                    Filename5 = string.Format("{0}_{1}_{2}_{3}.{4}", Guid.NewGuid(), txtRucRB, formatfecha, formathora, exten5);
                    PathFilename5 = Path.Combine(BasePath, Filename5);
                    //Preguntar si existe para Eliminarlo
                    if (System.IO.File.Exists(PathFilename5))
                    {
                        System.IO.File.Delete(PathFilename5);
                    }
                    //Copiar 
                    var document = new FileStream(PathFilename5, FileMode.Create);
                    FormFile5.CopyTo(document);
                    document.Flush();
                    document.Dispose();

                }
                if (FormFile6 != null)
                {
                    Filename6 = string.Format("{0}_{1}_{2}_{3}.{4}", Guid.NewGuid(), txtRucRB, formatfecha, formathora, exten6);
                    PathFilename6 = Path.Combine(BasePath, Filename6);
                    //Preguntar si existe para Eliminarlo
                    if (System.IO.File.Exists(PathFilename6))
                    {
                        System.IO.File.Delete(PathFilename6);
                    }
                    //Copiar 
                    var document = new FileStream(PathFilename6, FileMode.Create);
                    FormFile6.CopyTo(document);
                    document.Flush();
                    document.Dispose();

                }
                if (FormFile7 != null)
                {
                    Filename7 = string.Format("{0}_{1}_{2}_{3}.{4}", Guid.NewGuid(), txtRucRB, formatfecha, formathora, exten7);
                    PathFilename7 = Path.Combine(BasePath, Filename7);
                    //Preguntar si existe para Eliminarlo
                    if (System.IO.File.Exists(PathFilename7))
                    {
                        System.IO.File.Delete(PathFilename7);
                    }
                    //Copiar 
                    var document = new FileStream(PathFilename7, FileMode.Create);
                    FormFile7.CopyTo(document);
                    document.Flush();
                    document.Dispose();

                }
                if (FormFile8 != null)
                {
                    Filename8 = string.Format("{0}_{1}_{2}_{3}.{4}", Guid.NewGuid(), txtRucRB, formatfecha, formathora, exten8);
                    PathFilename8 = Path.Combine(BasePath, Filename8);
                    //Preguntar si existe para Eliminarlo
                    if (System.IO.File.Exists(PathFilename8))
                    {
                        System.IO.File.Delete(PathFilename8);
                    }
                    //Copiar 
                    var document = new FileStream(PathFilename8, FileMode.Create);
                    FormFile8.CopyTo(document);
                    document.Flush();
                    document.Dispose();

                }
                if (FormFile9 != null)
                {
                    Filename9 = string.Format("{0}_{1}_{2}_{3}.{4}", Guid.NewGuid(), txtRucRB, formatfecha, formathora, exten9);
                    PathFilename9 = Path.Combine(BasePath, Filename9);
                    //Preguntar si existe para Eliminarlo
                    if (System.IO.File.Exists(PathFilename9))
                    {
                        System.IO.File.Delete(PathFilename9);
                    }
                    //Copiar 
                    var document = new FileStream(PathFilename9, FileMode.Create);
                    FormFile9.CopyTo(document);
                    document.Flush();
                    document.Dispose();

                }
                if (FormFile10 != null)
                {
                    Filename10 = string.Format("{0}_{1}_{2}_{3}.{4}", Guid.NewGuid(), txtRucRB, formatfecha, formathora, exten10);
                    PathFilename10 = Path.Combine(BasePath, Filename10);
                    //Preguntar si existe para Eliminarlo
                    if (System.IO.File.Exists(PathFilename10))
                    {
                        System.IO.File.Delete(PathFilename10);
                    }
                    //Copiar 
                    var document = new FileStream(PathFilename10, FileMode.Create);
                    FormFile10.CopyTo(document);
                    document.Flush();
                    document.Dispose();

                }
                if (FormFile11 != null)
                {
                    Filename11 = string.Format("{0}_{1}_{2}_{3}.{4}", Guid.NewGuid(), txtRucRB, formatfecha, formathora, exten11);
                    PathFilename11 = Path.Combine(BasePath, Filename11);
                    //Preguntar si existe para Eliminarlo
                    if (System.IO.File.Exists(PathFilename11))
                    {
                        System.IO.File.Delete(PathFilename11);
                    }
                    //Copiar 
                    var document = new FileStream(PathFilename11, FileMode.Create);
                    FormFile11.CopyTo(document);
                    document.Flush();
                    document.Dispose();

                }
                if (FormFile12 != null)
                {
                    Filename12 = string.Format("{0}_{1}_{2}_{3}.{4}", Guid.NewGuid(), txtRucRB, formatfecha, formathora, exten12);
                    PathFilename12 = Path.Combine(BasePath, Filename12);
                    //Preguntar si existe para Eliminarlo
                    if (System.IO.File.Exists(PathFilename12))
                    {
                        System.IO.File.Delete(PathFilename12);
                    }
                    //Copiar 
                    var document = new FileStream(PathFilename12, FileMode.Create);
                    FormFile12.CopyTo(document);
                    document.Flush();
                    document.Dispose();

                }
                if (FormFile13 != null)
                {
                    Filename13 = string.Format("{0}_{1}_{2}_{3}.{4}", Guid.NewGuid(), txtRucRB, formatfecha, formathora, exten13);
                    PathFilename13 = Path.Combine(BasePath, Filename13);
                    //Preguntar si existe para Eliminarlo
                    if (System.IO.File.Exists(PathFilename13))
                    {
                        System.IO.File.Delete(PathFilename13);
                    }
                    //Copiar 
                    var document = new FileStream(PathFilename13, FileMode.Create);
                    FormFile13.CopyTo(document);
                    document.Flush();
                    document.Dispose();

                }

                FormularioRequestCliente request = new FormularioRequestCliente();

                var token = HttpContext.Session.GetString("TOKEN");

                request.NombreRazonSocialDG = NombreRazonSocialDG;
                request.DireccionDG = DireccionDG;
                request.PaisId = PaisId;
                request.CiudadPrinciaplDDG = CiudadPrinciaplDDG;
                request.TelefonoFijoDG = TelefonoFijoDG;
                request.CelularDG = CelularDG;
                request.CorreoElecontronicoDG = CorreoElecontronicoDG;
                request.DireccionFacturaDG = DireccionFacturaDG;
                request.CiudadFacturaDG = CiudadFacturaDG;
                request.DireccionPedidoDG = DireccionPedidoDG;
                request.CiudadPedidoDG = CiudadPedidoDG;
                request.DireccionPedidoSecundarioDG = DireccionPedidoSecundarioDG;
                request.CiudadPedidoSecundarioDG = CiudadPedidoSecundarioDG;
                request.NombreContactoAreaCobranza = NombreContactoAreaCobranza;
                request.TelefonoContactoAreaCobranza = TelefonoContactoAreaCobranza;
                request.CorreoContactoAreaCobranza = CorreoContactoAreaCobranza;
                request.NombreContactoAreaFinanciera = NombreContactoAreaFinanciera;
                request.TelefonoContactoAreaFinanciera = TelefonoContactoAreaFinanciera;
                request.CorreoContactoAreaFinanciera = CorreoContactoAreaFinanciera;
                request.NombreContactoAreaComercial = NombreContactoAreaComercial;
                request.TelefonoContactoAreaComercial = TelefonoContactoAreaComercial;
                request.CorreoContactoAreaComercial = CorreoContactoAreaComercial;
                request.TipoIdentificacionIdIT = TipoIdentificacionIdIT;
                request.CualIdentificacionIT = CualIdentificacionIT;
                request.NumeroIdentificacionIT = NumeroIdentificacionIT;
                request.cboTipoContribuyente = Convert.ToInt32(cboTipoContribuyente);
                request.cboTipoSociedad = Convert.ToInt32(cboTipoSociedad);
                request.txtCualSociedadIT = txtCualSociedadIT;
                request.cboOrigenCapital = Convert.ToInt32(cboOrigenCapital);
                request.cboActividadEconomica = Convert.ToInt32(cboActividadEconomica);
                request.txtCualEconomicaIT = txtCualEconomicaIT;
                request.txtSuperIntendenciaIT = txtSuperIntendenciaIT;
                request.txtFechaConstitucionIT = Convert.ToDateTime(txtFechaConstitucionIT);
                request.cboRegimen = Convert.ToInt32(cboRegimen);
                request.txtActividadPrincipalIAE = txtActividadPrincipalIAE;
                request.txtActividadSecundariaIAE = txtActividadSecundariaIAE;
                request.txtNombreRepresentanteLegalIRL = txtNombreRepresentanteLegalIRL;
                request.cboTipoIdenticacionLegal = Convert.ToInt32(cboTipoIdenticacionLegal);
                request.txtNumeroIdentificacionIRL = txtNumeroIdentificacionIRL;
                request.cboNacionalidad = Convert.ToInt32(cboNacionalidad);
                request.txtCualIRL = txtCualIRL;
                request.txtFechaExpedicionDocumentoIRL = Convert.ToDateTime(txtFechaExpedicionDocumentoIRL);
                request.txtDireccionResidenciaIRL = txtDireccionResidenciaIRL;
                request.txtCiudadIRL = txtCiudadIRL;
                request.checkGozaPEP = Convert.ToBoolean(checkGozaPEP);
                request.txtEspecifiqueGozaPEP = txtEspecifiqueGozaPEP;
                request.checkManejaPEP = Convert.ToBoolean(checkManejaPEP);
                request.txtEspecifiqueManejaPEP = txtEspecifiqueManejaPEP;
                request.checkOcupaPEP = Convert.ToBoolean(checkOcupaPEP);
                request.txtEspecifiqueOcupaPEP = txtEspecifiqueOcupaPEP;
                request.checkVinculo1PEP = Convert.ToBoolean(checkVinculo1PEP);
                request.txtEspecifiqueVinculo1PEP = txtEspecifiqueVinculo1PEP;
                request.checkVinculo2PEP = Convert.ToBoolean(checkVinculo2PEP);
                request.txtEspecifiqueVinculo2PEP = txtEspecifiqueVinculo2PEP;
                request.txtNombreApellidoPEP = txtNombreApellidoPEP;
                request.txtCargoPEP = txtCargoPEP;
                             
                var ArrayDetalleUPJ = new List<UnicamentePersonaJuridicas>();
 
                var itemDetalleUPJ = new UnicamentePersonaJuridicas();
                itemDetalleUPJ.CompañiaCuentaAccionistas = Convert.ToBoolean(checkAccionistaISA);
                itemDetalleUPJ.NombreApellidoAccionistas = txtNombreApellidoAccionista1ISA;
                itemDetalleUPJ.TipoId = txtTipoIdAccionista1ISA;
                itemDetalleUPJ.NroDocumento = txtNroDocumentoAccionista1ISA;
                itemDetalleUPJ.Participacion = txtParticipacionAccionista1ISA;
                itemDetalleUPJ.Nacionalidad = txtNacionalidadAccionista1ISA;
                ArrayDetalleUPJ.Add(itemDetalleUPJ);
                itemDetalleUPJ.CompañiaCuentaAccionistas = Convert.ToBoolean(checkAccionistaISA);
                itemDetalleUPJ.NombreApellidoAccionistas = txtNombreApellidoAccionista2ISA;
                itemDetalleUPJ.TipoId = txtTipoIdAccionista2ISA;
                itemDetalleUPJ.NroDocumento = txtNroDocumentoAccionista2ISA;
                itemDetalleUPJ.Participacion = txtParticipacionAccionista2ISA;
                itemDetalleUPJ.Nacionalidad = txtNacionalidadAccionista2ISA;
                ArrayDetalleUPJ.Add(itemDetalleUPJ);
                itemDetalleUPJ.CompañiaCuentaAccionistas = Convert.ToBoolean(checkAccionistaISA);
                itemDetalleUPJ.NombreApellidoAccionistas = txtNombreApellidoAccionista3ISA;
                itemDetalleUPJ.TipoId = txtTipoIdAccionista3ISA;
                itemDetalleUPJ.NroDocumento = txtNroDocumentoAccionista3ISA;
                itemDetalleUPJ.Participacion = txtParticipacionAccionista3ISA;
                itemDetalleUPJ.Nacionalidad = txtNacionalidadAccionista3ISA;
                ArrayDetalleUPJ.Add(itemDetalleUPJ);
                itemDetalleUPJ.CompañiaCuentaAccionistas = Convert.ToBoolean(checkAccionistaISA);
                itemDetalleUPJ.NombreApellidoAccionistas = txtNombreApellidoAccionista4ISA;
                itemDetalleUPJ.TipoId = txtTipoIdAccionista4ISA;
                itemDetalleUPJ.NroDocumento = txtNroDocumentoAccionista4ISA;
                itemDetalleUPJ.Participacion = txtParticipacionAccionista4ISA;
                itemDetalleUPJ.Nacionalidad = txtNacionalidadAccionista4ISA;
                ArrayDetalleUPJ.Add(itemDetalleUPJ);

                request.DetalleUnicamentePersonaJuridicas = ArrayDetalleUPJ;

                request.FechaCorte = Convert.ToDateTime(FechaCorte);
                request.checkSolesIF = Convert.ToBoolean(checkSolesIF);
                request.checkDolaresIF = Convert.ToBoolean(checkDolaresIF);
                request.txtActivosIF = Convert.ToDecimal(txtActivosIF);
                request.txtIngresosMensualesIF = Convert.ToDecimal(txtIngresosMensualesIF);
                request.txtPasivosIF = Convert.ToDecimal(txtPasivosIF);
                request.txtEgresosMensualesIF = Convert.ToDecimal(txtEgresosMensualesIF);
                request.txtPatrimonioIF = Convert.ToDecimal(txtPatrimonioIF);
                request.txtOtrosIngresosIF = Convert.ToDecimal(txtOtrosIngresosIF);
                request.txtConceptoOtrosIngresosIF = txtConceptoOtrosIngresosIF;
                //------Referencia comerciales------//
                var ArrayDetalleRC = new List<ReferenciasComercialesArray>();
                var itemDetalleReferenciaComercial = new ReferenciasComercialesArray();
                itemDetalleReferenciaComercial.Empresa = txtEmpresa1RC;
                itemDetalleReferenciaComercial.Ruc = txtRuc1RC;
                itemDetalleReferenciaComercial.Telefono = txtTelefono1RC;
                itemDetalleReferenciaComercial.Direccion = txtDireccion1RC;
                itemDetalleReferenciaComercial.Ciudad = txtCiudad1RC;
                ArrayDetalleRC.Add(itemDetalleReferenciaComercial);
                itemDetalleReferenciaComercial.Empresa = txtEmpresa2RC;
                itemDetalleReferenciaComercial.Ruc = txtRuc2RC;
                itemDetalleReferenciaComercial.Telefono = txtTelefono2RC;
                itemDetalleReferenciaComercial.Direccion = txtDireccion2RC;
                itemDetalleReferenciaComercial.Ciudad = txtCiudad2RC;
                ArrayDetalleRC.Add(itemDetalleReferenciaComercial);
                request.DetalleReferenciasComerciales = ArrayDetalleRC;
                request.txtInstitucionRB = txtInstitucionRB;
                request.txtNroCuentaRB = txtNroCuentaRB;
                request.txtTipoCuentaRB = txtTipoCuentaRB;
                request.txtBeneficiarioRB = txtBeneficiarioRB;
                request.txtEmpresaRB = txtEmpresaRB;
                request.txtRucRB = txtRucRB;
                request.txtTelefonoRB = txtTelefonoRB;
                request.txtDireccionRB = txtDireccionRB;
                request.cboUnidad = Convert.ToInt32(cboUnidad);

                request.cboSubUnidad = Convert.ToInt32 (cboSubUnidad);
                request.cboAsesorComercial = Convert.ToInt32 (cboAsesorComercial);
                request.txtDescripcion = txtDescripcion;
                request.cboTipoPago = Convert.ToInt32(cboTipoPago);
                request.cuposolicitado = cuposolicitado;
                request.txtAsesorComercialVUI = txtAsesorComercialVUI;
               
                request.Filename1 = Filename1;
                request.Filename2 = Filename2;
                request.Filename3 = Filename3;
                request.Filename4 = Filename4;
                request.Filename5 = Filename5;
                request.Filename6 = Filename6;
                request.Filename7 = Filename7;
                request.Filename8 = Filename8;
                request.Filename9 = Filename9;
                request.Filename10 = Filename10;
                request.Filename11 = Filename11;
                request.Filename12 = Filename12;
                request.Filename13 = Filename13;
                request.ruta1 = PathFilename1;
                request.ruta2 = PathFilename2;
                request.ruta3 = PathFilename3;
                request.ruta4 = PathFilename4;
                request.ruta5 = PathFilename5;
                request.ruta6 = PathFilename6;
                request.ruta7 = PathFilename7;
                request.ruta8 = PathFilename8;
                request.ruta9 = PathFilename9;
                request.ruta10 = PathFilename10;
                request.ruta11 = PathFilename11;
                request.ruta12 = PathFilename12;
                request.ruta13 = PathFilename13;

                 
                var Url = GeneralModel.UrlWebApi + "FormularioCliente/GuardarClienteFormulario";
                var Result = Simed.Utilities.Rest.RestClient.ProcessPostRequest(Url, request, token);

                if (Result!=null)
                {
                    Response.code = (int)Enums.eCodeError.OK;
                    Response.data = Result;
                }
                 
            }
            catch (Exception ex)
            {
                Logger.LogWarning(ex, ex.Message);

            }
            return Json(Response);
        }

        [HttpGet]
        public IActionResult DataByCode(string Code)
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "FormularioCliente/DataByCode/" + Code;
                var Result = Simed.Utilities.Rest.RestClient.ProcessGetRequest(Url);
                Response.data = Result;
            }
            catch (Exception ex)
            {
                Logger.LogWarning(ex, ex.Message);
                Response.message = ex.Message;
            }
            return Json(Response);
        }
    }
}
