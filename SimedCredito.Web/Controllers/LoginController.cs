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
using Simed.Utilities.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimedCredito.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly IHostingEnvironment HostingEnvironment;
        private readonly ILogger Logger;

        public LoginController(IConfiguration IConfiguration, ILoggerFactory LoggerFactory, IHostingEnvironment IHostingEnvironment)
        {
            HostingEnvironment = IHostingEnvironment;
            Configuration = IConfiguration;
            Logger = LoggerFactory.CreateLogger<LoginController>();
            GeneralModel.UrlWebApi = Configuration["Urls:UrlWebApi"];
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Validate(LoginRequest Request)
        {
            var Response = new GenericObjectResponse();
            try
            {
                var Url = GeneralModel.UrlWebApi + "seguridad/Login";
                var Result = Simed.Utilities.Rest.RestClient.ProcessPostRequest(Url, Request);

                Response.data = Result;

                var ResultJson = JsonConvert.SerializeObject(Response.data);
                var User = JsonConvert.DeserializeObject<GenericResponse>(ResultJson);

                switch (User.code)
                {
                    case (int)Enums.eCodeError.OK:
                        var UrlUser = GeneralModel.UrlWebApi + "User/GetUserDataByToken";
                        var ResultUser = Simed.Utilities.Rest.RestClient.ProcessGetRequest(UrlUser, User.data);
                        var ResultUserJson = JsonConvert.SerializeObject(ResultUser);
                        var UserData = JsonConvert.DeserializeObject<UserResponse>(ResultUserJson);

                        HttpContext.Session.SetString("TOKEN", User.data);
                        HttpContext.Session.SetInt32("PROFILE_ID", UserData.ProfileId);
                        break;
                    default:
                        Response.message = User.message;
                        break;
                }
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
