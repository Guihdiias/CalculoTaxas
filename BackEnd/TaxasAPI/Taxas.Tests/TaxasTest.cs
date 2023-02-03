using Xunit;
using Taxas.Application.Services;

namespace Taxas.Tests
{
    public class TaxasTest
    {
        [Fact]
        public void GetTaxa()
        {
            TaxasService taxasService = new TaxasService(); 
            Assert.Equal(0.01, taxasService.GetTaxa());
        }
    }
}