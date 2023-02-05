using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Taxas.Application.Interfaces;
using Taxas.Domain.Entidades;

namespace TaxasAPI.Application.Controllers
{
    [ApiController]
    [Route("")]
    public class TaxasController : ControllerBase
    {
        private readonly IServicoTaxaBase<TaxaJurosCompostos> _servicoTaxaJurosCompostos;
        public TaxasController(IServicoTaxaBase<TaxaJurosCompostos> servicoTaxaJurosCompostos)
        {
            _servicoTaxaJurosCompostos = servicoTaxaJurosCompostos;
        }

        [HttpGet("buscartaxajuroscompostos")]
        public TaxaJurosCompostos BuscarTaxaJurosCompostos()
        {
            return _servicoTaxaJurosCompostos.BuscarTaxa();
        }

    }
}