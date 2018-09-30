using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace WebApplication1.Models
{
    class Dolar : Moneda
    {
        public override decimal getCotizacion()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
                var response = httpClient.GetStringAsync(new Uri("http://www.bancoprovincia.com.ar/Principal/Dolar")).Result;
                var respuesta = Newtonsoft.Json.Linq.JArray.Parse(response);
                return decimal.Parse(respuesta[0].ToString());
            }
        }
    }
}