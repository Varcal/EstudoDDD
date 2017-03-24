using System.Collections.Generic;
using System.Linq;
using Application.Contracts;
using Domain.Contracts.Repositories;

namespace Application.Services
{
    public class PessoaAppService : IPessoaAppService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaAppService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public IEnumerable<PessoaDto> SelecionarTodos()
        {
            return _pessoaRepository.SelecionarTodos().Select(p => new PessoaDto(p)).ToList();
        }
    }
}
