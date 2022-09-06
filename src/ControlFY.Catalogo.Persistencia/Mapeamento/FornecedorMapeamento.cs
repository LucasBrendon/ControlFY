using ControlFY.Catalogo.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControlFY.Catalogo.Persistencia.Mapeamento
{
    public class FornecedorMapeamento : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("FORNECEDOR");

            builder.Property(x => x.Id)
                .HasColumnName("ID_FORNECEDOR");

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("NOME")
                .HasColumnType("varchar(300)");

            builder.Property(x => x.Documento)
                .IsRequired()
                .HasColumnName("DOCUMENTO")
                .HasColumnType("varchar(14)");

            builder.Property(x => x.TipoDocumento)
                .IsRequired()
                .HasColumnName("TIPO_DOCUMENTO");

            builder.Property(x => x.Telefone)
                .IsRequired()
                .HasColumnName("TELEFONE")
                .HasColumnType("varchar(30)");

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnName("EMAIL")
                .HasColumnType("varchar(150)");

            builder.Property(x => x.DataCadastro)
                .IsRequired()
                .HasColumnName("DATA_CADASTRO")
                .HasColumnType("timestamp");

            builder.Property(x => x.DataAtualizacao)
                .IsRequired(false)
                .HasColumnName("DATA_ATUALIZACAO")
                .HasColumnType("timestamp");

            builder.HasOne(x => x.Endereco)
                .WithOne(x => x.Fornecedor)
                .HasForeignKey<Endereco>(x => x.FornecedorId);
        }
    }
}
