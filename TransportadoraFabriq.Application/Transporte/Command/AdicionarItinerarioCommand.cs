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

        
        //[DataMember]
        //public List<EntregaCommand> EntregaCommand { get; private set; }
    }
}
