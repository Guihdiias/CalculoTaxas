using Microsoft.AspNetCore.Mvc;

namespace CalculoAPI.Application.Controllers
{
    [ApiController]
    [Route("")]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet("showmethecode")]
        public string ShowMeTheCode()
        {
            string url = "https://github.com/Guihdiias/CalculoTaxas";

            return url;
        }

    }
}
