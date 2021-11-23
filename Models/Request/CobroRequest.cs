using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Studio.Vision.POS.Telko.WebApi.Models.Request

{
    public class CobroRequest
    {
        public int PlanFinancieroId { get; set; }
        public int MonedaId { get; set; }
        public decimal TipodeCambio { get; set; }
        public decimal Monto { get; set; }
        public List<CobroAtributoRequest> Atributos { get; set; }

        public CobroRequest()
        {

        }
    }
}