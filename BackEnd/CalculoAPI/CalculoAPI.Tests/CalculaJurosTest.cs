using Calculo.Application.Services;
using Xunit;
namespace CalculoAPI.Tests
{
    public class CalculaJurosTest
    {
        [Fact]
        public void CalculaJuros()
        {
            CalculaJurosService calculaJurosService = new CalculaJurosService();
            Assert.Equal("105.10", calculaJurosService.CalcularJuros(100, 0.01, 5));
        }
    }
}