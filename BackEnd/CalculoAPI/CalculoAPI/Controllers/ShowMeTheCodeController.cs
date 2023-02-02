using CalculoAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace CalculoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet(Name = "showmethecode")]
        public string ShowMeTheCode()
        {
            string url = "https://github.com/Guihdiias";

            return url;
        }

    }
}
