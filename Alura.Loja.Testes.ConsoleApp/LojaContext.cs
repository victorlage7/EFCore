using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class LojaContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<PromocaoProduto>()
                .HasKey(pp => new { pp.PromocaoId, pp.ProdutoId });

            modelBuilder
                .Entity<Endereco>()
                .ToTable("Enderecos");

            modelBuilder
                .Entity<Endereco>()
                .Property<int>("ClienteId");

            modelBuilder
                .Entity<Endereco>()
                .HasKey("ClienteId");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R2J37NJ\\MSSQLSERVER02;Database=LojaDB;Trusted_Connection=true;");
        }
    }
    
}