using AutoMapper;
using Calculo.Domain.Entities;
using Calculo.Domain.Interfaces;
using CalculoAPI.Application.Models;
using Layer.Architecture.Service.Validators;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;

namespace CalculoAPI.Application.Controllers
{
    
    [ApiController]
    [Route("")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly IServicoCalculoBase<Juros, ValidacaoJuros> _servico;
        public readonly IMapper _mapper;

        public CalculaJurosController(IServicoCalculoBase<Juros, ValidacaoJuros> servico, IMapper mapper)
        {
            _servico = servico;
            _mapper = mapper;
        }

        [HttpPost("calculajuros")]
        public string CalcularJuros([FromBody] JurosModel jurosModel)
        {
            var juros = _mapper.Map<Juros>(jurosModel);
            return _servico.Calcular(juros);
        }


    }
}
