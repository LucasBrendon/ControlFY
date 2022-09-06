using ControlFY.Estoque.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControlFY.Estoque.Persistencia.Mapeamento
{
    public class ProdutoMapeamento : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("PRODUTO_ESTOQUE");

            builder.Property(x => x.Id)
                .HasColumnName("ID_PRODUTO_ESTOQUE");

            builder.Property(x => x.ProdutoId)
                .IsRequired()
                .HasColumnName("ID_PRODUTO");

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("NOME")
                .HasColumnType("varchar(200)");

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnName("DESCRICAO")
                .HasColumnType("varchar(300)");

            builder.Property(x => x.Valor)
                .IsRequired()
                .HasColumnName("VALOR")
                .HasColumnType("decimal(11,2)");

            builder.Property(x => x.Quantidade)
                .IsRequired()
                .HasColumnName("QUANTIDADE");

            builder.Property(x => x.ValorTotal)
                .IsRequired()
                .HasColumnName("VALOR_TOTAL");

            builder.Property(x => x.DataEntrada)
                .IsRequired()
                .HasColumnName("DATA_ENTRADA")
                .HasColumnType("timestamp");

            builder.Property(x => x.DataAtualizacao)
                .IsRequired(false)
                .HasColumnName("DATA_ATUALIZACAO")
                .HasColumnType("timestamp");
        }
    }
}
