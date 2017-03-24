using Application.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PessoaController : Controller
    {
        private IPessoaAppService _pessoaAppService;

        public PessoaController(IPessoaAppService pessoaAppService)
        {
            _pessoaAppService = pessoaAppService;
        }

        
        public IActionResult Get()
        {
            return Ok(_pessoaAppService.SelecionarTodos());
        }
    }
}