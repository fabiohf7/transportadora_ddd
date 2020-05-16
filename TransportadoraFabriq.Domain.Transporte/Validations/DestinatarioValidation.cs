using FluentValidation;

namespace TransportadoraFabriq.Domain.Transporte.Validations
{
    public class DestinatarioValidation : AbstractValidator<Destinatario>
    {
        public DestinatarioValidation()
        {
            RuleFor(x => x.Nome).NotNull().WithMessage("Nome do destinatário é obrigatório.");
            RuleFor(x => x.Endereco).NotNull().WithMessage("Endereço do destinatário é obrigatório.");
        }
    }
}
