using Data.Mappings;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data.Contexts
{
    public class EfContext: DbContext
    {
        private readonly IConfigurationRoot _configuration;

        public EfContext(IConfigurationRoot configuration)
        {
            _configuration = configuration;
        }


        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionstring = _configuration["ConnectionString:Local"];
            optionsBuilder.UseSqlServer(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            PessoaMap.Configure(modelBuilder);
        }
    }
}
