
using Calculo.Domain.Entidades;
using Calculo.Domain.Entities;
using Calculo.Domain.Interfaces;
using Calculo.Service;
using Calculo.Service.Servicos;
using Moq;
using Xunit;
namespace CalculoAPI.Tests
{
    public class CalculaJurosTest
    {
        public ServicoCalculoJuros _servicoCalcular;

       public Mock<IServicoExternoBase> _servicoExternoMock;

        public CalculaJurosTest()
        {
            _servicoExternoMock = new Mock<IServicoExternoBase>();
            _servicoCalcular = new ServicoCalculoJuros(_servicoExternoMock.Object);   
        }
        [Fact]
        public void CalculaJuros()
        {
            TaxaJuros taxaJuros = new TaxaJuros { ValorTaxa = 0.01};
            Juros juros = new Juros { ValorInicial = 100, Tempo = 5, TaxaJuros = taxaJuros };
            var ValorFinal = _servicoCalcular.Calcular(juros);
            Assert.Equal(105.10, ValorFinal);
        }
    }
}