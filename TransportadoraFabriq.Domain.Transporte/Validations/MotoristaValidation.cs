using FluentValidation;
using System;

namespace TransportadoraFabriq.Domain.Transporte.Validations
{
    public class MotoristaValidation : AbstractValidator<Motorista>
    {
        public MotoristaValidation()
        {
            RuleFor(x => x.Nome).NotNull().WithMessage("Nome do motorista é obrigatório.");
            RuleFor(x => x.Sobrenome).NotNull().WithMessage("Sobrenome do motorista é obrigatório.");
            RuleFor(x => x.DataNascimento).Must(BeAValidDate).WithMessage("Deve ser uma data válida.");
            RuleFor(x => x.CNH).NotNull().WithMessage("Nome do motorista é obrigatório.");
        }

        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }
    }
}
