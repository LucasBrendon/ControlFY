using ControlFY.Catalogo.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFY.Catalogo.Persistencia.Mapeamento
{
    public class EnderecoMapeamento : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("ENDERECO");

            builder.Property(x => x.Id)
                .HasColumnName("ID_ENDERECO");

            builder.Property(x => x.Cep)
                .IsRequired()
                .HasColumnName("CEP")
                .HasColumnType("varchar(11)");

            builder.Property(x => x.Logradouro)
                .IsRequired()
                .HasColumnName("LOGRADOURO")
                .HasColumnType("varchar(250)");

            builder.Property(x => x.Numero)
                .IsRequired()
                .HasColumnName("NUMERO")
                .HasColumnType("varchar(10)");

            builder.Property(x => x.Bairro)
                .IsRequired()
                .HasColumnName("BAIRRO")
                .HasColumnType("varchar(250)");

            builder.Property(x => x.Cidade)
                .IsRequired()
                .HasColumnName("CIDADE")
                .HasColumnType("varchar(250)");

            builder.Property(x => x.Estado)
                .IsRequired()
                .HasColumnName("ESTADO")
                .HasColumnType("varchar(250)");

            builder.Property(x => x.Pais)
                .IsRequired()
                .HasColumnName("PAIS")
                .HasColumnType("varchar(250)");

            builder.Property(x => x.FornecedorId)
                .IsRequired()
                .HasColumnName("FK_ENDERECO_FORNECEDOR");
        }
    }
}
