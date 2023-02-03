using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Taxas.Application.Interfaces;

namespace TaxasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxasController : ControllerBase
    {
        private readonly ITaxas _taxas;
        public TaxasController(ITaxas taxas)
        {
            _taxas = taxas;
        }

        [HttpGet(Name = "taxa")]
        public double GetTaxa()
        {
            double taxa = _taxas.GetTaxa();

            return taxa;
        }

    }
}