using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Studio.Vision.POS.Telko.WebApi.Models.Request
{
    public class CobroAtributoRequest
    {
        public int AtributoId { get; set; }
        public string Valor { get; set; }


        public CobroAtributoRequest()
        {

        }
    }
}