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
                string secretTokenName = "Auth-Token";
                var tokenCode = HttpContext.Request.Headers[secretTokenName].ToString();

                request.tokenCode = tokenCode;

                int resul = objFormularioClienteBL.GuardarFormulario(request);
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

    }
}
