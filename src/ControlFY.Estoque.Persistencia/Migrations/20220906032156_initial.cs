using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ControlFY.Estoque.Persistencia.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PRODUTO_ESTOQUE",
                columns: table => new
                {
                    ID_PRODUTO_ESTOQUE = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ID_PRODUTO = table.Column<long>(type: "bigint", nullable: false),
                    NOME = table.Column<string>(type: "varchar(200)", nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(300)", nullable: false),
                    VALOR = table.Column<decimal>(type: "numeric(11,2)", nullable: false),
                    QUANTIDADE = table.Column<int>(type: "integer", nullable: false),
                    VALOR_TOTAL = table.Column<decimal>(type: "numeric", nullable: false),
                    DATA_ENTRADA = table.Column<DateTime>(type: "timestamp", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTO_ESTOQUE", x => x.ID_PRODUTO_ESTOQUE);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRODUTO_ESTOQUE");
        }
    }
}
