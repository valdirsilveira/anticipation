using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "antecipacaostatus",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AntecipacaoStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "transacoes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConfirmacaoAdquirente = table.Column<bool>(nullable: true),
                    DataTransacao = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    parcelas = table.Column<int>(nullable: false),
                    DataRepasse = table.Column<DateTime>(nullable: true),
                    ValorTransacao = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ValorRepasse = table.Column<decimal>(type: "decimal(8,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Antecipacoes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataAnalise = table.Column<DateTime>(nullable: true),
                    AntecipacaoStatusId = table.Column<long>(nullable: false),
                    ResultadoAnalise = table.Column<bool>(nullable: true),
                    DataAntecipacao = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    ValorSolicitado = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ValorRepasse = table.Column<decimal>(type: "decimal(8,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Antecipacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Antecipacoes_AntecipacaoStatus_AntecipacaoStatusId",
                        column: x => x.AntecipacaoStatusId,
                        principalTable: "AntecipacaoStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Antecipacoes_AntecipacaoStatusId",
                table: "Antecipacoes",
                column: "AntecipacaoStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Antecipacoes");

            migrationBuilder.DropTable(
                name: "transacoes");

            migrationBuilder.DropTable(
                name: "AntecipacaoStatus");
        }
    }
}
