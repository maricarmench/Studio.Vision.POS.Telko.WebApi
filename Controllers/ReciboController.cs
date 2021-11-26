using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Studio.Vision.POS.Telko.WebApi.Models.Request;

namespace Studio.Vision.POS.Telko.WebApi.Controllers
{
    public class ReciboController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post([FromBody] ReciboRequest model)
        {
            //***Nivel Cabecera***//
            var message = "";
            var Numero = "";
            var ClienteId = 0;
            var FechaEmision = DateTime.Now;
            var Moneda = 0;
            var Importe = 0.0;
            var Observaciones = "";
            //***Nivel Cobros***//
            var PlanFinancieroId = 0;
            var MonedaId = 0;
            var TipoDeCambio = 0.0;
            var Monto = 0.0;
            //***Nivel Atributo***//
            var AtributoId = 0;
            var Valor = "";

            try
            {
                Numero = model.Numero;
                ClienteId = model.ClienteId;
                FechaEmision = model.FechaEmision;
                Moneda = model.MonedaId;
                Importe = (double)model.Importe;
                Observaciones = model.Observaciones;

                if (model.Cobros != null)
                {
                    foreach (var cobro in model.Cobros)
                    {
                        PlanFinancieroId = cobro.PlanFinancieroId;
                        MonedaId = cobro.MonedaId;
                        TipoDeCambio = (double)cobro.TipodeCambio;
                        Monto = (double)cobro.Monto;

                        if (cobro.Atributos != null)
                        {
                            foreach (var atributo in cobro.Atributos)
                            {
                                AtributoId = atributo.AtributoId;
                                Valor = atributo.Valor;
                            }
                        }
                    }
                }
                message = "OK";
                return Request.CreateResponse(HttpStatusCode.OK, message);
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                message = "Error";
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
                throw; 
            }
        }
    }
}
