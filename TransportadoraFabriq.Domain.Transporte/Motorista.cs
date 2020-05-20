using System;
using TransportadoraFabriq.Domain.Transporte.Validations;
using TransportadoraFabriq.Domain.Transporte.ValueObjects;
using TransportadoraFabriq.Shared.Entities;

namespace TransportadoraFabriq.Domain.Transporte
{
    public class Motorista : Entity
    {
        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public CNH CNH { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public bool Ativo { get; private set; }

        protected Motorista()
        {
        }

        public Motorista(string nome, string sobrenome, CNH cNH, DateTime dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CNH = cNH;
            DataNascimento = dataNascimento;
            Ativo = true;

            Validar();
        }

        public void Validar()
        {
            Validate(this, new MotoristaValidation());

            if (!CNH.IsValid())
            {
                AddDomainNotification("Motorista", "Documento de CNH é inválido.");
            }
        }

    }
}
