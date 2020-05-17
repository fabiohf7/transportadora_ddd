using System;
using TransportadoraFabriq.Domain.Transporte.Validations;
using TransportadoraFabriq.Shared.Entities;

namespace TransportadoraFabriq.Domain.Transporte
{
    public class Comprovante : Entity
    {        
        public DateTime DataEntrega { get; private set; }

        public Entrega Entrega { get; private set; }

        public Guid EntregaId { get; private set; }

        protected Comprovante()
        {
            
        }

        public Comprovante(Entrega entrega)
        {
            Entrega = entrega;
            DataEntrega = DateTime.Now;
        }

        public void Validar()
        {
            Validate(this, new ComprovanteValidation());
        }
    }
}
