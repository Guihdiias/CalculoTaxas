using Taxas.Application.Interfaces;

namespace Taxas.Application.Services
{
    public class TaxasService : ITaxasService 
    {
        public double GetTaxa()
        {
            var a = 0.01;
            return a;   
        }
    }
}