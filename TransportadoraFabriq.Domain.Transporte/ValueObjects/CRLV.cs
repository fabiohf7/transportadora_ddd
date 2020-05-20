using System.Collections.Generic;
using TransportadoraFabriq.Shared.Entities;

namespace TransportadoraFabriq.Domain.Transporte.ValueObjects
{
    public class CRLV : ValueObject
    {
        public string Placa { get; private set; }

        public string Renavam { get; private set; }

        public string Chassi { get; private set; }

        public string Marca { get; private set; }

        public CRLV(string placa, string renavam, string chassi, string marca)
        {
            Placa = placa;
            Renavam = renavam;
            Chassi = chassi;
            Marca = marca;
        }

        private CRLV()
        { }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Placa;
            yield return Renavam;
            yield return Chassi;
            yield return Marca;
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(Placa) || string.IsNullOrEmpty(Renavam) || string.IsNullOrEmpty(Chassi) || string.IsNullOrEmpty(Marca))
            {
                return false;
            }

            return true;
        }
    }
}
