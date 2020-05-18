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
        public Motorista Motorista { get; private set; }

        public Veiculo Veiculo { get; private set; }

        public List<Entrega> Entregas { get; private set; }

        public AdicionarItinerarioCommand(Motorista motorista, Veiculo veiculo, List<Entrega> entregas)
        {
            Motorista = motorista;
            Veiculo = veiculo;
            Entregas = entregas;
        }
    }
}
