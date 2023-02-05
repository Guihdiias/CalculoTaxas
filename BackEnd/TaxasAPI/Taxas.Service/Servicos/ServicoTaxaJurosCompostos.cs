using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxas.Application.Interfaces;
using Taxas.Domain.Entidades;

namespace Taxas.Service.Servicos
{
    public class ServicoTaxaJurosCompostos : IServicoTaxaBase<TaxaJurosCompostos>
    { 
        public TaxaJurosCompostos BuscarTaxa()
        {
            return new TaxaJurosCompostos { ValorTaxa = 0.01m };
        }
    }
}
