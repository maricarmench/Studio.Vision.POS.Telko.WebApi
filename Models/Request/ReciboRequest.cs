using Studio.Vision.POS.Telko.WebApi.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Studio.Vision.POS.Telko.WebApi.Models.Request
{
    public class ReciboRequest
    {
        public string Numero { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaEmision { get; set; }
        public int MonedaId { get; set; }
        public decimal Importe { get; set; }
        public string Observaciones { get; set; }
        public List<CobroDTO> Cobros { get; set; }

        public ReciboRequest()
        {

        }
    }

    public class CobroDTO
    {
        public int PlanFinancieroId { get; set; }
        public int MonedaId { get; set; }
        public decimal TipodeCambio { get; set; }
        public decimal Monto { get; set; }
        public List<CobroAtributoDTO> Atributos { get; set; }

        public CobroDTO()
        {

        }
    }

    public class CobroAtributoDTO
    {
        public int AtributoId { get; set; }
        public string Valor { get; set; }

        public CobroAtributoDTO()
        {

        }
    }
}