using System;
using TransportadoraFabriq.Shared.Entities;

namespace TransportadoraFabriq.Domain.Transporte
{
    public class Comprovante : Entity
    {

        protected Comprovante()
        {
        }

        public Comprovante(DateTime dataEntrega)
        {
            DataEntrega = dataEntrega;
        }

        public DateTime DataEntrega { get; private set; }
    }
}
