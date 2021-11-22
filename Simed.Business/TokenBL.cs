using Simed.Data;
using Simed.Entity.Request;
using Simed.Entity.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Business
{
   public class TokenBL
    {
        private TokenDA objTokenDL;

        public TokenBL(string ConStr)
        {
            objTokenDL = new TokenDA(ConStr);
        }
        public void Disponse()
        {
            GC.SuppressFinalize(this);
        }
        public UsuarioResponse GetUserByToken(TokenRequest Token)
        {
            return objTokenDL.GetUserByToken(Token);
        }

    }
}
