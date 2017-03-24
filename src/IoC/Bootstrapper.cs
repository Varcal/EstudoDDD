using Application.Contracts;
using Application.Services;
using Data.Contexts;
using Data.Repositories;
using Domain.Contracts.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public class Bootstrapper
    {
        public static void Register(IServiceCollection services)
        {
            services.AddScoped<IPessoaAppService, PessoaAppService>();

            services.AddScoped<IPessoaRepository, PessoaRepository>();

            services.AddDbContext<EfContext>();
        }
    }
}
