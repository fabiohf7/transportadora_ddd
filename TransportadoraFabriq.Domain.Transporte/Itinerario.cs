using System.Collections.Generic;
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

    }
}
