using System;
using System.Collections.Generic;
using System.Text;

namespace Simed.Entity.Response
{
    public class GenericObjectResponse
    {

        public int code { get; set; }
        public string message { get; set; }
        public object data { get; set; }


    }
}
