using Calculo.Application.Interfaces;
using System.Globalization;

namespace Calculo.Application.Services
{
    public class CalculaJurosService : ICalculaJuros
    {
        delegate double LogicalOperator(double valorInicial, double taxaJuros, int tempo);

        static double Operacao(double valorInicial, double taxaJuros, int tempo)
        {
            return valorInicial * Math.Pow((1 + taxaJuros), tempo);
        }
        static double Calculo(LogicalOperator op, double valorInicial, double taxaJuros, int tempo)
        {
            return op(valorInicial, taxaJuros, tempo);
        }
        public string CalcularJuros(double valorInicial, double taxaJuros, int tempo)       
        {
            double calc = Calculo(Operacao, valorInicial, taxaJuros, tempo);
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalDigits = 2;
            nfi.NumberDecimalSeparator = ".";
            string resultado = calc.ToString("F", nfi);

            return resultado;
        }
    }
}