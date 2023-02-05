using Calculo.Application.Interfaces;
using Calculo.Application.Services;
using CalculoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;

namespace CalculoAPI.Controllers
{
    
    [ApiController]
    [Route("")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ICalculaJurosServices _calculajurosServices;
        public CalculaJurosController(ICalculaJurosServices calculajuros)
        {
            _calculajurosServices = calculajuros;
        }

        [HttpGet("calculajuros")]
        public string CalcularJuros([FromQuery] double valorInicial, double taxaJuros, int tempo)
        {
            return _calculajurosServices.CalcularJuros(valorInicial, taxaJuros, tempo);
        }

        [HttpGet("getTaxa")]
        public string GetTaxa()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://pokeapi.co/api/v2/pokemon/ditto");

            using (var client = new HttpClient())
            {
                var response = client.Send(request);
                var contentResp = response.Content.ReadAsStringAsync().Result;
            }


            return "";
        }
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
