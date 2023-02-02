using Microsoft.AspNetCore.Mvc;

namespace TaxasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxasController : ControllerBase
    {
        [HttpGet(Name = "taxa")]
        public double Taxa()
        {
            double taxa = 0.01;

            return taxa;
        }

    }
}