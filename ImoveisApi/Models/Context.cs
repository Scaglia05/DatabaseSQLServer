using Microsoft.EntityFrameworkCore;
using System;
using Bogus;
using Bogus.Extensions.Brazil; // Adicione esta linha para usar a biblioteca Bogus

namespace ImoveisApi.Models {
    public class Context : DbContext {
        public Context(DbContextOptions<Context> options) : base(options) {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Imovel> Imovel { get; set; }
        public DbSet<Contrato> Contrato { get; set; } = default!;
        public DbSet<Pagamento> Pagamento { get; set; } = default!;
        public DbSet<Proprietario> Proprietario { get; set; } = default!;
        public DbSet<VendedorImovel> VendedorImovel { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            // Criando um gerador de dados fictícios
            var faker = new Faker("pt_BR"); // Definindo o local para português do Brasil

            // Seeding de dados estruturado para a entidade Cliente
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente {
                    Id = 1,
                    Nome = "Guilherme",
                    CPF = "123.456.789.10",
                    Endereco = "Av.12a, Araras-SP",
                    DataNascimento = new DateOnly(2002, 10, 10),
                    Email_Cliente = "cliente@gmail.com"
                },
                new Cliente {
                    Id = 2,
                    Nome = faker.Name.FullName(), // Nome aleatório
                    CPF = faker.Person.Cpf(), // CPF aleatório
                    Endereco = faker.Address.FullAddress(), // Endereço aleatório
                    DataNascimento = DateOnly.FromDateTime(faker.Date.Past(20)), // Converte DateTime para DateOnly
                    Email_Cliente = faker.Internet.Email() // Email aleatório
                }
            );

            // Você pode adicionar seeding para outras entidades de forma estruturada aqui, se desejar.
        }
    }
}
