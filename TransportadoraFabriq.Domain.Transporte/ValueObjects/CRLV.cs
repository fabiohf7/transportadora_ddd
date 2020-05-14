using System;
using System.Collections.Generic;
using TransportadoraFabriq.Shared.Entities;

namespace TransportadoraFabriq.Domain.Transporte.ValueObjects
{
    public class CRLV : ValueObject
    {
        public CRLV(string placa, string renavam, string chassi, string marca, DateTime anoFabricacao, DateTime anoModelo, DateTime ultimoIPVA)
        {
            Placa = placa;
            Renavam = renavam;
            Chassi = chassi;
            Marca = marca;
        }

        private CRLV()
        { }

        public string Placa { get; private set; }

        public string Renavam { get; private set; }

        public string Chassi { get; private set; }

        public string Marca { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Placa;
            yield return Renavam;
            yield return Chassi;
            yield return Marca;
        }
    }
}
