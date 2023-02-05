using Calculo.Domain.Entidades;
using Calculo.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Calculo.Infra.Externo
{
    public class ServicoTaxaJuros: IServicoExternoBase
    {
        private readonly IConfiguration _config;

        public ServicoTaxaJuros(IConfiguration config)
        {
            _config = config;
        }

        public TSaida? BuscarDados<TSaida, TEntrada>(TEntrada? parametros)
            where TSaida : class
            where TEntrada : class
        {
            var url = _config["URL:urlApiTaxa"];
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            using (var client = new HttpClient())
            {
                var response = client.Send(request);
                var contentResp = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<TSaida>(contentResp);
                return result;
            }
        }
    }
}
