using System;
TransportadoraFabriq.Domain.Transporte.ValueObject

namespace TransportadoraFabriq.Domain.Transporte.ValueObject
{
    public class CRLV : ValueObject
    {
        public CRLV(string placa, string renavam, string chassi, string marca, DateTime anoFabricacao, DateTime anoModelo, DateTime ultimoIPVA)
        {
            Placa = placa;
            Renavam = renavam;
            Chassi = chassi;
            Marca = marca;
            AnoFabricacao = anoFabricacao;
            AnoModelo = anoModelo;
            UltimoIPVA = ultimoIPVA;
        }

        private CRLV()
        { }

        public string Placa { get; private set; }

        public string Renavam { get; private set; }

        public string Chassi { get; private set; }

        public string Marca { get; private set; }

        public DateTime AnoFabricacao { get; private set; }

        public DateTime AnoModelo { get; private set; }

        public DateTime UltimoIPVA { get; private set; }
    }
}
