using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity.Response
{
    public class GenericResponse
    {
        public int code { get; set; }
        public string message { get; set; }
        public string data { get; set; }
        public object Data { get; set; }
       

    }
}
