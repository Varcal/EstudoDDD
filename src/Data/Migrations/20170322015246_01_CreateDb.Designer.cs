using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Data.Contexts;

namespace Data.Migrations
{
    [DbContext(typeof(EfContext))]
    [Migration("20170322015246_01_CreateDb")]
    partial class _01_CreateDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo")
                        .HasColumnName("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnName("DataCadastro")
                        .HasColumnType("datetime2(3)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnName("DataNascimento")
                        .HasColumnType("date");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });
        }
    }
}
