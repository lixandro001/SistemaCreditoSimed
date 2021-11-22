using Simed.Entity.Request;
using Simed.Entity.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Simed.Data
{
    public class TokenDA : IDisposable
    {
        private string ConStr;
        public TokenDA(string ConStr)
        {
            this.ConStr = ConStr;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public UsuarioResponse GetUserByToken(TokenRequest Token)
        {
            UsuarioResponse Entity = null;

            using (var Ado = new SQLServer(ConStr))
            {
                var Parameters = new SqlParameter[]
                {
                    new SqlParameter{ParameterName="@TokenCode",SqlDbType=SqlDbType.VarChar,Size=50,SqlValue=Token.TokenCode},
                    new SqlParameter{ParameterName="@TokenType",SqlDbType=SqlDbType.Int,SqlValue=Token.TokenType}
                };
                var Dr = Ado.ExecDataReader("usp_GetUserByToken @TokenCode,@TokenType ", Parameters);

                if (!Dr.HasRows) return Entity;
                while (Dr.Read())
                {
                    Entity = new UsuarioResponse();
                    Entity.UserCode = Convert.ToString(Dr["UserCode"]);
                    Entity.Login = (string)Dr["Login"];
                    Entity.Fullname = (string)Dr["Fullname"];
                    Entity.DocumentType = Convert.ToInt32(Dr["DocumentType"]);
                    Entity.DocumentNumber = (string)Dr["DocumentNumber"];
                    Entity.Email = (string)Dr["Email"];
                    Entity.ProfileId = (int)Dr["ProfileId"];
                    Entity.Status = Convert.ToInt32(Dr["Status"]);

                    break;
                }
                Dr.Close();
            }
            return Entity;
        }

    }
}
