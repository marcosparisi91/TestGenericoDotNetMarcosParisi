using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/cotizacion")]
    public class CotizacionController : ApiController
    {
        [HttpPost]
        public bool AddEmpDetails()
        {
            return true;
            //write insert logic  

        }
        [Route("{moneda}")]
        [HttpGet]
        public IHttpActionResult GetEmpDetails(string moneda)
        {
            switch (moneda.ToUpper())
            {
                case "DOLAR":
                    Dolar dolar = new Dolar();
                    return this.Ok(new { Cotizacion = dolar.getCotizacion() });
                case "PESOS":
                    return this.Unauthorized();
                case "REAL":
                    return this.Unauthorized();
                default:
                    return this.Unauthorized();

            }

        }
        [HttpDelete]
        public string DeleteEmpDetails(string id)
        {
            return "Employee details deleted having Id " + id;

        }
        [HttpPut]
        public string UpdateEmpDetails(string Name, String Id)
        {
            return "Employee details Updated with Name " + Name + " and Id " + Id;

        }
    }
}
