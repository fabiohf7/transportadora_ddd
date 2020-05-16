using TransportadoraFabriq.Domain.Transporte.ValueObjects;
using TransportadoraFabriq.Shared.Entities;

namespace TransportadoraFabriq.Domain.Transporte
{
    public class Veiculo : Entity
    {
        public Veiculo(CRLV cRLV, double capacidadeCarga, bool refrigerado)
        {
            CRLV = cRLV;
            CapacidadeCarga = capacidadeCarga;
            Refrigerado = refrigerado;
            Ativo = true;
        }

        public CRLV CRLV { get; private set; }

        public double CapacidadeCarga { get; private set; }

        public bool Refrigerado { get; private set; }

        public bool Ativo { get; private set; }
    }
}
