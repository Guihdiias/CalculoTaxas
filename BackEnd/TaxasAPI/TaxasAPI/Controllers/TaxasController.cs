using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Taxas.Application.Interfaces;

namespace TaxasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxasController : ControllerBase
    {
        private readonly ITaxasService _taxas;
        public TaxasController(ITaxasService taxas)
        {
            _taxas = taxas;
        }

        [HttpGet(Name = "taxa")]
        public object GetTaxa()
        {
            double taxa = _taxas.GetTaxa();

            return new { taxa = taxa };
        }

    }
}