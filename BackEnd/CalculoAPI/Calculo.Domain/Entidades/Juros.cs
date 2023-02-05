using Calculo.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Domain.Entities
{
    public class Juros
    {
        public double ValorInicial { get; set; }
        public TaxaJuros? TaxaJuros { get; set; }
        public int Tempo { get; set; }
    }
}
