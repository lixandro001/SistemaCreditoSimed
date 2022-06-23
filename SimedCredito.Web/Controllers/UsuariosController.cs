using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Simed.Entity;
using Simed.Entity.Request;
using Simed.Entity.Response;
using Simed.Utilities.General;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimedCredito.Web.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly ILogger Logger;
        private readonly IHostingEnvironment HostingEnvironment;

        public UsuariosController(IConfiguration IConfiguration, ILoggerFactory LoggerFactory, IHostingEnvironment IHostingEnvironment)
        {
            HostingEnvironment = IHostingEnvironment;
            Configuration = IConfiguration;
            Logger = LoggerFactory.CreateLogger<UsuariosController>();
            GeneralModel.UrlWebApi = Configuration["Urls:UrlWebApi"];

        }

        public IActionResult guardarUsuarios(UsuariosRequest request)
        {
            var Response = new GenericObjectResponse();
            try
            {
                var IdUsuario = HttpContext.Session.GetInt32("USUARIO_ID");
                request.UsuarioId = Convert.ToInt32(IdUsuario);
                var Url = GeneralModel.UrlWebApi + "FormularioCliente/guardarUsuarios";
                var Result = Simed.Utilities.Rest.RestClient.ProcessPostRequest(Url, request);
                Response.data = Result;

                var ResultJson = JsonConvert.SerializeObject(Response.data);
                var User = JsonConvert.DeserializeObject<GenericResponse>(ResultJson);

                if (User.code == 0)
                {
                    Response.code = (int)Enums.eCodeError.OK;
                    Response.data = Result;
                    Response.message = User.message;
                    return Json(Response);
                }
                else if (User.code == 1)
                {
                    Response.code = (int)Enums.eCodeError.ERROR;
                    Response.data = Result;
                    Response.message = User.message;
                    return Json(Response);
                }
                else
                {
                    Response.code = (int)Enums.eCodeError.VAL;
                    Response.data = Result;
                    Response.message = User.message;
                    return Json(Response);
                }

            }
            catch (Exception ex)
            {
                Logger.LogWarning(ex, ex.Message);
                Response.message = ex.Message;
                return Json(Response);
            }
             
        }
         
        public IActionResult guardarinformacionfinanciera(InformacionFinancieraRequest request)
        {
            var Response = new GenericObjectResponse();
            try
            {

                if (request.FechaCorte==null)
                {
                     DateTime fecha = DateTime.Now;
                     request.FechaCorte = Convert.ToString(fecha);
                }

                var IdUsuario = HttpContext.Session.GetInt32("USUARIO_ID");
                request.UsuarioId = Convert.ToInt32(IdUsuario);
                var Url = GeneralModel.UrlWebApi + "FormularioCliente/guardarinformacionfinanciera";
                var Result = Simed.Utilities.Rest.RestClient.ProcessPostRequest(Url, request);
                Response.data = Result;

                var ResultJson = JsonConvert.SerializeObject(Response.data);
                var User = JsonConvert.DeserializeObject<GenericResponse>(ResultJson);

                if (User.code == 0)
                {
                    Response.code = (int)Enums.eCodeError.OK;
                    Response.data = Result;
                    Response.message = User.message;
                    return Json(Response);
                }
                else if (User.code == 1)
                {
                    Response.code = (int)Enums.eCodeError.ERROR;
                    Response.data = Result;
                    Response.message = User.message;
                    return Json(Response);
                }
                else
                {
                    Response.code = (int)Enums.eCodeError.VAL;
                    Response.data = Result;
                    Response.message = User.message;
                    return Json(Response);
                }

            }
            catch (Exception ex)
            {
                Logger.LogWarning(ex, ex.Message);
                Response.message = ex.Message;
                return Json(Response);
            }

        }
         
        [HttpGet]
        public IActionResult GetListadoUsuario()
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "FormularioCliente/GetListadoUsuario";
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
        public IActionResult DataUsuario(string CodeUsuario)
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "FormularioCliente/DataUsuario/" + CodeUsuario;
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



        [HttpPost]
        public IActionResult eliminarUsuarios(EliminarUsuarioRequest request)
        {
            var Response = new GenericObjectResponse();
            try
            {
                var IdUsuario = HttpContext.Session.GetInt32("USUARIO_ID");
                request.UsuarioId = Convert.ToInt32(IdUsuario);
                var Url = GeneralModel.UrlWebApi + "FormularioCliente/eliminarUsuarios";
                var Result = Simed.Utilities.Rest.RestClient.ProcessPostRequest(Url, request);
                Response.data = Result;

                var ResultJson = JsonConvert.SerializeObject(Response.data);
                var User = JsonConvert.DeserializeObject<GenericResponse>(ResultJson);
            }
            catch (Exception ex)
            {
                Logger.LogWarning(ex, ex.Message);
                Response.message = ex.Message;
            }
            return Json(Response);
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult NuevoUsuario()
        {
            return View();
        }
    }
}
