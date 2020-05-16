using FluentValidation;

namespace TransportadoraFabriq.Domain.Transporte.Validations
{
    public class VeiculoValidation : AbstractValidator<Veiculo>
    {
        public VeiculoValidation()
        {
            RuleFor(x => x.CapacidadeCarga).GreaterThan(0).WithMessage("Capacidade de carga do veículo deve ser maior que 0.");
            RuleFor(x => x.Refrigerado).NotNull().WithMessage("É necessário informar se o veículo é refrigerado ou não.");
        }
    }
}
