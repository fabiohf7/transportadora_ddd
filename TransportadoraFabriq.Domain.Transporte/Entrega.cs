using System;
using TransportadoraFabriq.Shared.Entities;

namespace TransportadoraFabriq.Domain.Transporte
{
    public class Entrega : Entity
    {
        protected Entrega()
        {
        }

        public Entrega(Destinatario cliente, DateTime dataEntrega)
        {
            Destinatario = cliente;
            DataEntrega = dataEntrega;
        }

        public DateTime DataEntrega { get; private set; }

        public Comprovante Comprovate { get; private set; }

        public Destinatario Destinatario { get; private set; }

        // tem status
    }
}
