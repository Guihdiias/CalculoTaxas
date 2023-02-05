using Taxas.Domain.Entidades;

namespace Taxas.Application.Interfaces
{
    public interface IServicoTaxaBase<TEntidade>
         where TEntidade : class
    {
        TEntidade BuscarTaxa();
    }
}
