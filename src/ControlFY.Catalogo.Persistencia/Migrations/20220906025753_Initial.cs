using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ControlFY.Catalogo.Persistencia.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORIA",
                columns: table => new
                {
                    ID_CATEGORIA = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOME = table.Column<string>(type: "varchar(200)", nullable: false),
                    DATA_CADASTRO = table.Column<DateTime>(type: "timestamp", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIA", x => x.ID_CATEGORIA);
                });

            migrationBuilder.CreateTable(
                name: "FORNECEDOR",
                columns: table => new
                {
                    ID_FORNECEDOR = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOME = table.Column<string>(type: "varchar(300)", nullable: false),
                    DOCUMENTO = table.Column<string>(type: "varchar(14)", nullable: false),
                    TIPO_DOCUMENTO = table.Column<int>(type: "integer", nullable: false),
                    TELEFONE = table.Column<string>(type: "varchar(30)", nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(150)", nullable: false),
                    DATA_CADASTRO = table.Column<DateTime>(type: "timestamp", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORNECEDOR", x => x.ID_FORNECEDOR);
                });

            migrationBuilder.CreateTable(
                name: "ENDERECO",
                columns: table => new
                {
                    ID_ENDERECO = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CEP = table.Column<string>(type: "varchar(11)", nullable: false),
                    LOGRADOURO = table.Column<string>(type: "varchar(250)", nullable: false),
                    NUMERO = table.Column<string>(type: "varchar(10)", nullable: false),
                    BAIRRO = table.Column<string>(type: "varchar(250)", nullable: false),
                    CIDADE = table.Column<string>(type: "varchar(250)", nullable: false),
                    ESTADO = table.Column<string>(type: "varchar(250)", nullable: false),
                    PAIS = table.Column<string>(type: "varchar(250)", nullable: false),
                    FK_ENDERECO_FORNECEDOR = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENDERECO", x => x.ID_ENDERECO);
                    table.ForeignKey(
                        name: "FK_ENDERECO_FORNECEDOR_FK_ENDERECO_FORNECEDOR",
                        column: x => x.FK_ENDERECO_FORNECEDOR,
                        principalTable: "FORNECEDOR",
                        principalColumn: "ID_FORNECEDOR",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTO",
                columns: table => new
                {
                    ID_PRODUTO = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NOME = table.Column<string>(type: "varchar(200)", nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(300)", nullable: false),
                    VALOR = table.Column<decimal>(type: "numeric(11,2)", nullable: false),
                    DATA_CADASTRO = table.Column<DateTime>(type: "timestamp", nullable: false),
                    DATA_ATUALIZACAO = table.Column<DateTime>(type: "timestamp", nullable: true),
                    FK_PRODUTO_CATEGORIA = table.Column<long>(type: "bigint", nullable: false),
                    FK_PRODUTO_FORNECEDOR = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTO", x => x.ID_PRODUTO);
                    table.ForeignKey(
                        name: "FK_PRODUTO_CATEGORIA_FK_PRODUTO_CATEGORIA",
                        column: x => x.FK_PRODUTO_CATEGORIA,
                        principalTable: "CATEGORIA",
                        principalColumn: "ID_CATEGORIA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRODUTO_FORNECEDOR_FK_PRODUTO_FORNECEDOR",
                        column: x => x.FK_PRODUTO_FORNECEDOR,
                        principalTable: "FORNECEDOR",
                        principalColumn: "ID_FORNECEDOR",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ENDERECO_FK_ENDERECO_FORNECEDOR",
                table: "ENDERECO",
                column: "FK_ENDERECO_FORNECEDOR",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_FK_PRODUTO_CATEGORIA",
                table: "PRODUTO",
                column: "FK_PRODUTO_CATEGORIA");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_FK_PRODUTO_FORNECEDOR",
                table: "PRODUTO",
                column: "FK_PRODUTO_FORNECEDOR");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ENDERECO");

            migrationBuilder.DropTable(
                name: "PRODUTO");

            migrationBuilder.DropTable(
                name: "CATEGORIA");

            migrationBuilder.DropTable(
                name: "FORNECEDOR");
        }
    }
}
