using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Simed.Business;
using Simed.Entity;
using Simed.Entity.Response;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SimedCredito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BandejaController : ControllerBase
    {
        private readonly IConfiguration Configuration;
        private readonly ILogger Logger;
        private BandejaBL objBandejaBL;
        public BandejaController(IConfiguration IConfiguration, ILoggerFactory LoggerFactory)
        {
            Configuration = IConfiguration;
            Logger = LoggerFactory.CreateLogger<BandejaController>();
            objBandejaBL = new BandejaBL(Configuration["ConnectionStrings:SIMED"]);
        }

        [HttpGet]
        [Route("GetBandejaCliente/{StartDate?}/{EndDate?}/{PerfilId?}/{UsuarioCreacion?}")]
        public IActionResult GetBandejaCliente(string StartDate, string EndDate, int PerfilId, int UsuarioCreacion)
        {
            try
            {
                var response = new GenericResponse();
                DateTime fechaIniDate = DateTime.ParseExact(StartDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                DateTime fechaFinDate = DateTime.ParseExact(EndDate, "yyyy-MM-dd", CultureInfo.InvariantCulture); ;
                var data = objBandejaBL.GetBandejaCliente(fechaIniDate, fechaFinDate, PerfilId, UsuarioCreacion);
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

    }
}
