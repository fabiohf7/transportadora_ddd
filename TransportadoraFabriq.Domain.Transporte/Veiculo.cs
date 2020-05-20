using TransportadoraFabriq.Domain.Transporte.Validations;
using TransportadoraFabriq.Domain.Transporte.ValueObjects;
using TransportadoraFabriq.Shared.Entities;

namespace TransportadoraFabriq.Domain.Transporte
{
    public class Veiculo : Entity
    {
        public CRLV CRLV { get; private set; }

        public double CapacidadeCarga { get; private set; }

        public bool Refrigerado { get; private set; }

        public bool Ativo { get; private set; }

        protected Veiculo()
        {

        }

        public Veiculo(CRLV cRLV, double capacidadeCarga, bool refrigerado)
        {
            CRLV = cRLV;
            CapacidadeCarga = capacidadeCarga;
            Refrigerado = refrigerado;
            Ativo = true;

            Validar();
        }

        public void Validar()
        {
            if (!CRLV.IsValid())
                AddDomainNotification("Motorista", "Documento de CNH é inválido.");

            Validate(this, new VeiculoValidation());
        }
    }
}
