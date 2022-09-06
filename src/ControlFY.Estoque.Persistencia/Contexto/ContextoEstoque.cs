using Microsoft.EntityFrameworkCore;
using ControlFY.Estoque.Dominio.Entidades;
using System.Reflection;

namespace ControlFY.Estoque.Persistencia.Contexto
{
    public class ContextoEstoque : DbContext
    {
        public ContextoEstoque(DbContextOptions<ContextoEstoque> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
