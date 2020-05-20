using System;
using TransportadoraFabriq.Domain.Transporte.Validations;
using TransportadoraFabriq.Shared.Entities;

namespace TransportadoraFabriq.Domain.Transporte
{
    public class Entrega : Entity
    {        
        public Itinerario Itinerario { get; private set; }

        public Guid ItinerarioId { get; private set; }

        public DateTime DataEntrega { get; private set; }

        public Destinatario Destinatario { get; private set; }

        public Comprovante Comprovate { get; private set; }

        protected Entrega()
        {
        }

        public Entrega(string nomeCliente, string endereco, DateTime dataEntrega)
        {
            Destinatario = new Destinatario(nomeCliente, endereco, this);
            DataEntrega = dataEntrega;

            Validar();
        }

        public void AdicionarComprovante()
        {
            //this.Comprovate = new Comprovante(this);
        }

        public void Validar()
        {
            Validate(this, new EntregaValidation());
        }

        // tem status
    }
}
