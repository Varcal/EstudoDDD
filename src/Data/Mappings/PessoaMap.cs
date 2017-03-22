using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Data.Mappings
{
    public class PessoaMap
    {
        public static void Configure(ModelBuilder builder)
        {
            builder.Entity<Pessoa>(config =>
            {
                config.ToTable("Pessoa");

                config.HasKey(x => x.Id);

                config.Property(x => x.Nome)
                    .HasColumnName("Nome")
                    .HasColumnType("varchar(250)")
                    .IsRequired();
                config.Property(x => x.DataNascimento)
                    .HasColumnName("DataNascimento")
                    .HasColumnType("date")
                    .IsRequired();
                config.Property(x => x.DataCadastro)
                    .HasColumnName("DataCadastro")
                    .HasColumnType("datetime2(3)")
                    .IsRequired();
                config.Property(x => x.Ativo)
                    .HasColumnName("Ativo")
                    .HasColumnType("bit")
                    .IsRequired();
            });

            
        }
    }
}
