using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using TransportadoraFabriq.Domain.Transporte.ValueObjects;
using TransportadoraFabriq.Shared.Commands.Interfaces;

namespace TransportadoraFabriq.Application.Transporte.Command
{
    [DataContract]
    public class AdicionarVeiculoCommand : ICommand
    {
        [DataMember]
        public CRLV CRLV { get; private set; }

        [DataMember]
        public double CapacidadeCarga { get; private set; }

        [DataMember]
        public bool Refrigerado { get; private set; }
    }
}
