using System;
using System.Collections.Generic;
using TransportadoraFabriq.Domain.Transporte.Validations;
using TransportadoraFabriq.Shared.Entities;

namespace TransportadoraFabriq.Domain.Transporte
{
    public class Itinerario : AggregateRoot
    {
        public Motorista Motorista { get; private set; }

        public Veiculo Veiculo { get; private set; }

        private List<Entrega> _entregas = new List<Entrega>();

        public IReadOnlyCollection<Entrega> Entregas => _entregas;

        protected Itinerario()
        {
        }

        public Itinerario(Motorista motorista, Veiculo veiculo)
        {
            Motorista = motorista;
            Veiculo = veiculo;

            Validar();
        }

        public void AdicionarEntrega(string nomeCliente, string endereco, DateTime dataEntrega)
        {
            var entrega = new Entrega(nomeCliente, endereco, dataEntrega);
            _entregas.Add(entrega);
        }

        public void Validar()
        {
            Validate(this, new ItinerarioValidation());
        }
    }
}
