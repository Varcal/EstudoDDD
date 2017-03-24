using System.Collections.Generic;
using System.Linq;
using Data.Contexts;
using Data.Repositories.Base;
using Domain.Contracts.Repositories;
using Domain.Entities;

namespace Data.Repositories
{
    public class PessoaRepository: Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(EfContext context) 
            : base(context)
        {
            _context = context;
        }

        public IEnumerable<Pessoa> SelecionarTodos()
        {
            return _context.Pessoas.ToList();
        }
    }
}
