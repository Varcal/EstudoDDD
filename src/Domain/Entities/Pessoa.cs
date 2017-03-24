using System;
using SharedKernel.BaseObjects;

namespace Domain.Entities
{
    public class Pessoa: Entity
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public DateTime DataNascimento { get; private set; }

        protected Pessoa()
        {
            
        }

        public Pessoa(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }
    }
}
