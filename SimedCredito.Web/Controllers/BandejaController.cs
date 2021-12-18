using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Simed.Entity.Response;
using Simed.Utilities.General;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SimedCredito.Web.Controllers
{
    public class BandejaController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly IHostingEnvironment HostingEnvironment;
        private readonly ILogger Logger;

        public BandejaController(IConfiguration IConfiguration, ILoggerFactory LoggerFactory, IHostingEnvironment IHostingEnvironment)
        {
            HostingEnvironment = IHostingEnvironment;
            Configuration = IConfiguration;
            Logger = LoggerFactory.CreateLogger<LoginController>();
            GeneralModel.UrlWebApi = Configuration["Urls:UrlWebApi"];
        }

        [HttpGet]
        public IActionResult GetBandejaCliente(string StartDate, string EndDate, int PerfilId)
        {
            var Response = new GenericObjectResponse();
            try
            {
                if (!string.IsNullOrEmpty(StartDate))
                {
                    DateTime CDate1 = DateTime.ParseExact(StartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    StartDate = string.Format("{0:yyyy-MM-dd}", CDate1);
                }

                if (!string.IsNullOrEmpty(EndDate))
                {
                    DateTime CDate2 = DateTime.ParseExact(EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    EndDate = string.Format("{0:yyyy-MM-dd}", CDate2);
                }
                var Url = GeneralModel.UrlWebApi + "Bandeja/GetBandejaCliente/" + StartDate + "/" + EndDate + "/" + PerfilId;
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
