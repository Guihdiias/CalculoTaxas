using Microsoft.Extensions.Configuration;

namespace Calculo.Domain.Interfaces
{
    public interface IServicoExternoBase
    {
        public TSaida? BuscarDados<TSaida, TEntrada>(TEntrada? parametros)
            where TEntrada : class
            where TSaida : class;
    }
}
