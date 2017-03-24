using System.Collections.Generic;

namespace Application.Contracts
{
    public interface IPessoaAppService
    {
        IEnumerable<PessoaDto> SelecionarTodos();
    }
}
