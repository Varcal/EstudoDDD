using Data.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public class Bootstrapper
    {
        public static void Register(IServiceCollection services)
        {
            services.AddDbContext<EfContext>();
        }
    }
}
