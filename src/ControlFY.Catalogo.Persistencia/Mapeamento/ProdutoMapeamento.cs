using ControlFY.Catalogo.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControlFY.Catalogo.Persistencia.Mapeamento
{
    public class ProdutoMapeamento : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("PRODUTO");

            builder.Property(x => x.Id)
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

            builder.Property(x => x.DataCadastro)
                .IsRequired()
                .HasColumnName("DATA_CADASTRO")
                .HasColumnType("timestamp");

            builder.Property(x => x.DataAtualizacao)
                .IsRequired(false)
                .HasColumnName("DATA_ATUALIZACAO")
                .HasColumnType("timestamp");

            builder.Property(x => x.CategoriaId)
                .IsRequired()
                .HasColumnName("FK_PRODUTO_CATEGORIA");

            builder.Property(x => x.FornecedorId)
                .IsRequired()
                .HasColumnName("FK_PRODUTO_FORNECEDOR");

            builder.HasOne(x => x.Categoria)
                .WithMany(x => x.Produtos)
                .HasForeignKey(x => x.CategoriaId);

            builder.HasOne(x => x.Fornecedor)
                .WithMany(x => x.Produtos)
                .HasForeignKey(x => x.FornecedorId);
        }
    }
}
