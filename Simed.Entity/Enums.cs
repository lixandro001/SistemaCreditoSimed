using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity
{
    public static class Enums
    {
        public enum eCodeError : int
        {
            OK = 0,
            ERROR = 1,
            VAL = 2
        }

        public enum TokenType : int
        {
            LOGIN = 1,
            PASSWORD = 2
        }

        public enum Profile : int
        {
            GESTOR = 1,
            FACTURADOR = 2,
            USUARIO = 3
        }

    }
}
