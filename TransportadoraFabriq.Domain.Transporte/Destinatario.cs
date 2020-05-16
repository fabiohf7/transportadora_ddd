using TransportadoraFabriq.Shared.Entities;

namespace TransportadoraFabriq.Domain.Transporte
{
    public class Destinatario : Entity
    {
        protected Destinatario()
        {
        }

        public Destinatario(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
        }

        public string Nome { get; private set; }

        public string Endereco { get; private set; }
    }
}
