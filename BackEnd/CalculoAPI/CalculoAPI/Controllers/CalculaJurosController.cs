using Calculo.Application.Interfaces;
using CalculoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;

namespace CalculoAPI.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ICalculaJuros _calculajuros;
        public CalculaJurosController(ICalculaJuros calculajuros)
        {
            _calculajuros = calculajuros;
        }

        [HttpGet(Name = "calculajuros")]
        public string CalcularJuros([FromQuery] double valorInicial, double taxaJuros, int tempo)
        {
            return _calculajuros.CalcularJuros(valorInicial, taxaJuros, tempo);
        }
        //static async Task<string> GetTaxa()
        //{
        //    var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:49174/taxas");

        //    using (var client = new HttpClient())
        //    {
        //        var response = await client.SendAsync(request);
        //        var contentResp =await response.Content.ReadAsStringAsync();    
        //    }
        //    return "";
        //}
        //public async Task<double> GetTaxa()
        //{

        //    using (var client = new HttpClient())
        //    {
        //        try
        //        {
        //            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:49174/");

        //            var response =  await client.SendAsync(request);
        //            var contentResp =await response.Content.ReadAsStringAsync();    
        //            if (response.IsSuccessStatusCode)
        //            {
        //                var content = await response.Content.ReadAsStringAsync();

        //                //double.TryParse(content, out double result);
        //                return 0;
        //            }
        //        }
        //        catch (Exception ex)    
        //        {
        //            return 0;
        //        }
        //        return 0;

        //    }
        //}

    }
}
