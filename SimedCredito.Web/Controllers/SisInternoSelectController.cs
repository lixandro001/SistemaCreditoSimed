using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Simed.Entity.Response;
using Simed.Utilities.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimedCredito.Web.Controllers
{
    public class SisInternoSelectController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly IHostingEnvironment HostingEnvironment;
        private readonly ILogger Logger;

        public SisInternoSelectController(IConfiguration IConfiguration, ILoggerFactory LoggerFactory, IHostingEnvironment IHostingEnvironment)
        {
            HostingEnvironment = IHostingEnvironment;
            Configuration = IConfiguration;
            Logger = LoggerFactory.CreateLogger<LoginController>();
            GeneralModel.UrlWebApi = Configuration["Urls:UrlWebApi"];
        }

        [HttpGet]
        public IActionResult GetCategoriaCliente()
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "SisInternoSelect/GetCategoriaCliente";
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

        [HttpGet]
        public IActionResult GetPrecios()
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "SisInternoSelect/GetPrecios";
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

        [HttpGet]
        public IActionResult GetTipoIdentificacion()
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "SisInternoSelect/GetTipoIdentificacion";
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

        [HttpGet]
        public IActionResult GetTipoContribuyente()
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "SisInternoSelect/GetTipoContribuyente";
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

        [HttpGet]
        public IActionResult GetTipoSociedad()
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "SisInternoSelect/GetTipoSociedad";
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

        [HttpGet]
        public IActionResult GetOrigenCapital()
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "SisInternoSelect/GetOrigenCapital";
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

        [HttpGet]
        public IActionResult GetPais()
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "SisInternoSelect/GetPais";
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

        [HttpGet]
        public IActionResult GetActividadEconomica()
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "SisInternoSelect/GetActividadEconomica";
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

        [HttpGet]
        public IActionResult GetRegimen()
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "SisInternoSelect/GetRegimen";
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

        [HttpGet]
        public IActionResult GetNacionalidad()
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "SisInternoSelect/GetNacionalidad";
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

        [HttpGet]
        public IActionResult GetBiociencias()
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "SisInternoSelect/GetBiociencias";
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

        [HttpGet]
        public IActionResult GetSubUnidad()
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "SisInternoSelect/GetSubUnidad";
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

        [HttpGet]
        public IActionResult GetAsesorComercial()
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "SisInternoSelect/GetAsesorComercial";
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
