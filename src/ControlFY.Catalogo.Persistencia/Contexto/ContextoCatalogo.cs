using ControlFY.Catalogo.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ControlFY.Catalogo.Persistencia.Contexto
{
    public class ContextoCatalogo : DbContext
    {
        public ContextoCatalogo(DbContextOptions<ContextoCatalogo> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
