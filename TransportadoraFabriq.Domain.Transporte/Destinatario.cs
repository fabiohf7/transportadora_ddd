using System;
using TransportadoraFabriq.Shared.Entities;

namespace TransportadoraFabriq.Domain.Transporte
{
    public class Destinatario : Entity
    {
        public Entrega Entrega { get; private set; }

        public Guid EntregaId { get; private set; }

        public string Nome { get; private set; }

        public string Endereco { get; private set; }

        protected Destinatario()
        {
        }

        public Destinatario(string nome, string endereco, Entrega entrega)
        {
            Nome = nome;
            Endereco = endereco;
            Entrega = entrega;
        }
    }
}
