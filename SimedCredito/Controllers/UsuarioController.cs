using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Simed.Business;
using Simed.Entity;
using Simed.Entity.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimedCredito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IConfiguration Configuration;
        private readonly ILogger Logger;
        private SeguridadBL objSecurityBL;
        private TokenBL objTokenBL;
      

        public UsuarioController(IConfiguration IConfiguration, ILoggerFactory LoggerFactory)
        {
            Configuration = IConfiguration;
            Logger = LoggerFactory.CreateLogger<UsuarioController>();
            objSecurityBL = new SeguridadBL(Configuration["ConnectionStrings:SIMED"]);
            objTokenBL = new TokenBL(Configuration["ConnectionStrings:SIMED"]);
           
        }

        [HttpGet]
        [Route("GetUserDataByToken")]
        public IActionResult GetUserDataByToken()
        {
            try
            {
                //Obtener el Token
                string secretTokenName = "Auth-Token";
                var tokenCode = HttpContext.Request.Headers[secretTokenName].ToString();

                TokenRequest Request = new TokenRequest();
                Request.TokenCode = tokenCode;
                Request.TokenType = (int)Enums.TokenType.LOGIN;

                var Result = objTokenBL.GetUserByToken(Request);

                return Ok(Result);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                throw ex;
            }
        }


    }
}
