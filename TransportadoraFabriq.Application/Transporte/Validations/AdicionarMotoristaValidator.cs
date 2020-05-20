using FluentValidation;
using System;
using TransportadoraFabriq.Application.Transporte.Command;

namespace TransportadoraFabriq.Application.Transporte.Validations
{
    public class AdicionarMotoristaValidator : AbstractValidator<AdicionarMotoristaCommand>
    {
        public AdicionarMotoristaValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Nome não pode ser vazio.");
            RuleFor(x => x.Sobrenome).NotEmpty().WithMessage("Sobrenome não pode ser vazio.");
            RuleFor(x => x.DataNascimento).Must(BeAValidDate).WithMessage("Data de nascimento deve ser uma data válida.");
            RuleFor(x => x.DataValidadeCnh).Must(BeAValidDate).WithMessage("Data de validade da CNH deve ser uma data válida.");
            RuleFor(x => x.NumeroDeRegistroCnh).NotEmpty().WithMessage("Número de registro da CNH deve ser válido.");
        }

        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }
    }
}
