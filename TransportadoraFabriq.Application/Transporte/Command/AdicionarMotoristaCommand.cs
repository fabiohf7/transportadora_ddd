using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using TransportadoraFabriq.Shared.Commands.Interfaces;

namespace TransportadoraFabriq.Application.Transporte.Command
{
    [DataContract]
    public class AdicionarMotoristaCommand : ICommand
    {
        [DataMember]
        public string Nome { get; private set; }

        [DataMember]
        public string Sobrenome { get; private set; }

        [DataMember]
        public DateTime DataNascimento { get; private set; }

        [DataMember]
        public string NumeroDeRegistroCnh { get; private set; }

        [DataMember]
        public DateTime DataValidadeCnh { get; private set; }
    }
}
