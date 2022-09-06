using ControlFY.Catalogo.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControlFY.Catalogo.Persistencia.Mapeamento
{
    public class CategoriaMapeamento : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("CATEGORIA");

            builder.Property(x => x.Id)
                .HasColumnName("ID_CATEGORIA");

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasColumnName("NOME")
                .HasColumnType("varchar(200)");

            builder.Property(x => x.DataCadastro)
                .IsRequired()
                .HasColumnName("DATA_CADASTRO")
                .HasColumnType("timestamp");

            builder.Property(x => x.DataAtualizacao)
                .IsRequired(false)
                .HasColumnName("DATA_ATUALIZACAO")
                .HasColumnType("timestamp");
        }
    }
}
