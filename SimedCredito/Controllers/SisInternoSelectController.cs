using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Simed.Business;
using Simed.Entity;
using Simed.Entity.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimedCredito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SisInternoSelectController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly ILogger Logger;
        private SisInternoSelectBL objSisInternoSelectBL;
        public SisInternoSelectController(IConfiguration IConfiguration, ILoggerFactory LoggerFactory)
        {
            Configuration = IConfiguration;
            Logger = LoggerFactory.CreateLogger<SisInternoSelectController>();
            objSisInternoSelectBL = new SisInternoSelectBL(Configuration["ConnectionStrings:SIMED"]);
        }

        [HttpGet]
        [Route("GetCategoriaCliente")]
        public IActionResult GetCategoriaCliente()
        {
            try
            {
                var response = new GenericResponse();
                var data = objSisInternoSelectBL.GetCategoriaCliente();
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
        [Route("GetPrecios")]
        public IActionResult GetPrecios()
        {
            try
            {
                var response = new GenericResponse();
                var data = objSisInternoSelectBL.GetPrecios();
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
        [Route("GetTipoIdentificacion")]
        public IActionResult GetTipoIdentificacion()
        {
            try
            {
                var response = new GenericResponse();
                var data = objSisInternoSelectBL.GetTipoIdentificacion();
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
        [Route("GetTipoContribuyente")]
        public IActionResult GetTipoContribuyente()
        {
            try
            {
                var response = new GenericResponse();
                var data = objSisInternoSelectBL.GetTipoContribuyente();
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
        [Route("GetTipoSociedad")]
        public IActionResult GetTipoSociedad()
        {
            try
            {
                var response = new GenericResponse();
                var data = objSisInternoSelectBL.GetTipoSociedad();
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
        [Route("GetOrigenCapital")]
        public IActionResult GetOrigenCapital()
        {
            try
            {
                var response = new GenericResponse();
                var data = objSisInternoSelectBL.GetOrigenCapital();
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
        [Route("GetPais")]
        public IActionResult GetPais()
        {
            try
            {
                var response = new GenericResponse();
                var data = objSisInternoSelectBL.GetPais();
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
        [Route("GetActividadEconomica")]
        public IActionResult GetActividadEconomica()
        {
            try
            {
                var response = new GenericResponse();
                var data = objSisInternoSelectBL.GetActividadEconomica();
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
        [Route("GetRegimen")]
        public IActionResult GetRegimen()
        {
            try
            {
                var response = new GenericResponse();
                var data = objSisInternoSelectBL.GetRegimen();
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
        [Route("GetNacionalidad")]
        public IActionResult GetNacionalidad()
        {
            try
            {
                var response = new GenericResponse();
                var data = objSisInternoSelectBL.GetNacionalidad();
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
        [Route("GetBiociencias")]
        public IActionResult GetBiociencias()
        {
            try
            {
                var response = new GenericResponse();
                var data = objSisInternoSelectBL.GetBiociencias();
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
        [Route("GetSubUnidad")]
        public IActionResult GetSubUnidad()
        {
            try
            {
                var response = new GenericResponse();
                var data = objSisInternoSelectBL.GetSubUnidad();
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
        [Route("GetAsesorComercial")]
        public IActionResult GetAsesorComercial()
        {
            try
            {
                var response = new GenericResponse();
                var data = objSisInternoSelectBL.GetAsesorComercial();
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
