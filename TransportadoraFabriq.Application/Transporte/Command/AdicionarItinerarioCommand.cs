using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TransportadoraFabriq.Domain.Transporte;
using TransportadoraFabriq.Shared.Commands.Interfaces;

namespace TransportadoraFabriq.Application.Transporte.Command
{
    [DataContract]
    public class AdicionarItinerarioCommand : ICommand
    {
        [DataMember]
        public Guid MotoristaId { get; private set; }

        [DataMember]
        public Guid VeiculoId { get; private set; }

        [DataMember]
        public List<EntregaCommand> Entregas { get; private set; }

        public class EntregaCommand
        {
            public EntregaCommand(DateTime dataEntrega, DestinatarioCommand destinatario)
            {
                DataEntrega = dataEntrega;
                Destinatario = destinatario;
            }

            public DateTime DataEntrega { get; private set; }

            public DestinatarioCommand Destinatario { get; private set; }
        }

        public class DestinatarioCommand
        {
            public DestinatarioCommand(string nome, string endereco)
            {
                Nome = nome;
                Endereco = endereco;
            }

            public string Nome { get; private set; }

            public string Endereco { get; private set; }
        }
    }
}
