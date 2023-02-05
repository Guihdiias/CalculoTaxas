using Calculo.Domain.Entities;
using FluentValidation;

namespace Layer.Architecture.Service.Validators
{
    public class ValidacaoJuros : AbstractValidator<Juros>
    {
        public ValidacaoJuros()
        {
            RuleFor(c => c.ValorInicial)
                .NotEmpty().WithMessage("Por favor, insira o valor incial")
                .NotNull().WithMessage("Por favor, insira o valor incial")
                .GreaterThan(0).WithMessage("O valor incial tem que ser maior que zero");

            RuleFor(c => c.TaxaJuros)
                .NotEmpty().WithMessage("Não foi possivel obter a taxa de juros")
                .NotNull().WithMessage("Não foi possivel obter a taxa de juros");

            RuleFor(c => c.Tempo)
                .NotEmpty().WithMessage("Por favor, insira o tempo")
                .NotNull().WithMessage("Não foi possivel o tempo")
                .GreaterThan(0).WithMessage("O Tempo tem que ser maior que zero");
        }
    }
}
