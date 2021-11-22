using Simed.Data;
using Simed.Entity;
using Simed.Entity.Request;
using Simed.Entity.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Business
{
   public class SeguridadBL:IDisposable
    {
        private SeguridadDA objSeguridadDL;

        public SeguridadBL(string ConStr)
        {
            objSeguridadDL = new SeguridadDA(ConStr);
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public SeguridadResponse GetLogin(LoginRequest Login)
        {
            SeguridadResponse Security = objSeguridadDL.GetLogin(Login);

            if (Security != null)
            {
                if (!Security.Locked)
                {
                    TokenResponse Token = objSeguridadDL.GetNewToken(Security.UsuarioCodeGuid, (int)Enums.TokenType.LOGIN);
                    Security.TokenCode = Token.TokenCode;

                }
            }

            return Security;
        }




    }

}
