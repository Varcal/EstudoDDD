using System.Collections.Generic;
using Domain.Contracts.Repositories.Base;
using Domain.Entities;

namespace Domain.Contracts.Repositories
{
    public interface IPessoaRepository: IRepositoryBase<Pessoa>
    {
        IEnumerable<Pessoa> SelecionarTodos();
    }
}
