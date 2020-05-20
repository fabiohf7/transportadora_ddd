using System.Runtime.Serialization;
using TransportadoraFabriq.Shared.Commands.Interfaces;

namespace TransportadoraFabriq.Application.Transporte.Command
{
    public class AdicionarVeiculoCommand : ICommand
    {
        [DataMember]
        public string Renavam { get; private set; }

        [DataMember]
        public string Chassi { get; private set; }

        [DataMember]
        public string Marca { get; private set; }

        [DataMember]
        public string Placa { get; private set; }

        [DataMember]
        public double CapacidadeCarga { get; private set; }

        [DataMember]
        public bool Refrigerado { get; private set; }
    }
}
