using FluentValidation;

namespace Calculo.Domain.Interfaces
{
    public interface IServicoCalculoBase<TEntrada, TValidacao>
            where TValidacao : AbstractValidator<TEntrada>
            where TEntrada : class
    {
        double Calcular(TEntrada inputModel);
    }
}
