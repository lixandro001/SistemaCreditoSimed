﻿using System;
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
            ADMINISTRADOR = 1,
            ASESORCOMERCIAL=2,
            ANALISTAREDITO=3,
            GERENTENEGOCIO=4
        }

    }
}
