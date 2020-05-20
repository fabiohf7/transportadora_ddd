using FluentValidation;
using System;
using TransportadoraFabriq.Application.Transporte.Command;

namespace TransportadoraFabriq.Application.Transporte.Validations
{
    public class AdicionarItinerarioValidator : AbstractValidator<AdicionarItinerarioCommand>
    {
        public AdicionarItinerarioValidator()
        {
        }

        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }
    }
}
