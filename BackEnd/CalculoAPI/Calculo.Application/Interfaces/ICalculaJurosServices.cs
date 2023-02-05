namespace Calculo.Application.Interfaces
{
    public interface ICalculaJurosServices
    {
       string CalcularJuros(double valorInicial, double taxaJuros, int tempo);
    }
}
