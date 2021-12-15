using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Simed.Business;
using Simed.Entity.Request;
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


    }
}
