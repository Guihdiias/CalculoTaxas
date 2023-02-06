using Calculo.Domain.Entidades;
using Calculo.Domain.Entities;
using Calculo.Domain.Interfaces;
using FluentValidation;
using Layer.Architecture.Service.Validators;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Service.Servicos
{
    public class ServicoCalculoJuros : IServicoCalculoBase<Juros, ValidacaoJuros>
    {
        private readonly IServicoExternoBase _servicoExterno;
        public ServicoCalculoJuros(IServicoExternoBase servicoExterno)
        {
            _servicoExterno = servicoExterno;
        }

        public double Calcular(Juros juros)
        {
            juros.TaxaJuros = _servicoExterno.BuscarDados<TaxaJuros, object>(null);
            ValidarEntrada(juros, Activator.CreateInstance<ValidacaoJuros>());

            double calc = Calculo(Operacao, juros);
            return calc;
        }





        delegate double LogicalOperator(Juros juros);

        static double Operacao(Juros juros)
        {
            double taxaJuros = juros.TaxaJuros?.ValorTaxa ?? 0;

            return juros.ValorInicial * Math.Pow((1 + taxaJuros), juros.Tempo);
        }
        static double Calculo(LogicalOperator op, Juros juros)
        {
            return op(juros);
        }

        private void ValidarEntrada(Juros obj, AbstractValidator<Juros> validator)
        {
            if (obj == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(obj);
        }
    }
}
