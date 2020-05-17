using System;
using System.Collections.Generic;
using TransportadoraFabriq.Shared.Entities;

namespace TransportadoraFabriq.Domain.Transporte.ValueObjects
{
    public class CNH : ValueObject
    {
        public string NumeroDeRegistro { get; private set; }

        public DateTime DataValidade { get; private set; }

        public CNH(string numeroDeRegistro, DateTime dataValidade)
        {
            NumeroDeRegistro = numeroDeRegistro;
            DataValidade = dataValidade;
        }

        private CNH()
        { }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return NumeroDeRegistro;
            yield return DataValidade;
        }
    }
}
