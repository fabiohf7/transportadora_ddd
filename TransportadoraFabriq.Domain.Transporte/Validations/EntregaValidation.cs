using FluentValidation;
using System;

namespace TransportadoraFabriq.Domain.Transporte.Validations
{
    public class EntregaValidation : AbstractValidator<Entrega>
    {
        public EntregaValidation()
        {
            RuleFor(x => x.DataEntrega).Must(BeAValidDate).WithMessage("Deve ser uma data válida.");
        }

        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }
    }
}
