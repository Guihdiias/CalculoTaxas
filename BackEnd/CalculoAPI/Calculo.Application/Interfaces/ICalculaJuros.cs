namespace Calculo.Application.Interfaces
{
    public interface ICalculaJuros
    {
       string CalcularJuros(double valorInicial, double taxaJuros, int tempo);
    }
}
