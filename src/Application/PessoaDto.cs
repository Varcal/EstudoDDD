using System;
using Domain.Entities;

namespace Application
{
    public class PessoaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public PessoaDto(Pessoa pessoa)
        {
            Id = pessoa.Id;
            Nome = pessoa.Nome;
            DataNascimento = pessoa.DataNascimento;
        }
    }
}
