using FluentValidation;
using System;
using TransportadoraFabriq.Application.Transporte.Command;

namespace TransportadoraFabriq.Application.Transporte.Validations
{
    public class AdicionarItinerarioValidator : AbstractValidator<AdicionarItinerarioCommand>
    {
        public AdicionarItinerarioValidator()
        {
            RuleFor(x => x.MotoristaId).NotNull().WithMessage("ID do motorista é obrigatório.");
            RuleFor(x => x.VeiculoId).NotNull().WithMessage("ID do veículo é obrigatório.");
        }

        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }
    }
}
