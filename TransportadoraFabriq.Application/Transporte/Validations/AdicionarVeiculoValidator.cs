using FluentValidation;
using System;
using TransportadoraFabriq.Application.Transporte.Command;

namespace TransportadoraFabriq.Application.Transporte.Validations
{
    public class AdicionarVeiculoValidator : AbstractValidator<AdicionarVeiculoCommand>
    {
        public AdicionarVeiculoValidator()
        {
            RuleFor(x => x.Refrigerado).Must(x => x == false || x == true).WithMessage("É necessário informar se o veículo é refrigerado.");
            RuleFor(x => x.CapacidadeCarga).GreaterThan(0).WithMessage("É necessário informar a capacidade de carga do veículo.");
            RuleFor(x => x.Chassi).NotEmpty().WithMessage("É necessário informar o chassi do veículo.");
            RuleFor(x => x.Marca).NotEmpty().WithMessage("É necessário informar a marca do veículo.");
            RuleFor(x => x.Placa).NotEmpty().WithMessage("É necessário informar a placa do veículo.");
            RuleFor(x => x.Renavam).NotEmpty().WithMessage("É necessário informar o RENAVAM do veículo.");
        }

        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }
    }
}
