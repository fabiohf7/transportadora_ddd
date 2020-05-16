using System;
using System.Collections.Generic;
using System.Text;
using TransportadoraFabriq.Shared.Entities;

namespace TransportadoraFabriq.Domain.Transporte
{
    public class Motorista : Entity
    {
        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public int CNH { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public bool Ativo { get; private set; }
    }
}
