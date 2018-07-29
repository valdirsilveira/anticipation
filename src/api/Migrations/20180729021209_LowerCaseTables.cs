using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class LowerCaseTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Antecipacoes_AntecipacaoStatus_AntecipacaoStatusId",
                table: "Antecipacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Antecipacoes",
                table: "Antecipacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AntecipacaoStatus",
                table: "AntecipacaoStatus");

            migrationBuilder.RenameTable(
                name: "Antecipacoes",
                newName: "antecipacoes");

            migrationBuilder.RenameTable(
                name: "AntecipacaoStatus",
                newName: "antecipacaostatus");

            migrationBuilder.RenameIndex(
                name: "IX_Antecipacoes_AntecipacaoStatusId",
                table: "antecipacoes",
                newName: "IX_antecipacoes_AntecipacaoStatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_antecipacoes",
                table: "antecipacoes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_antecipacaostatus",
                table: "antecipacaostatus",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_antecipacoes_antecipacaostatus_AntecipacaoStatusId",
                table: "antecipacoes",
                column: "AntecipacaoStatusId",
                principalTable: "antecipacaostatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_antecipacoes_antecipacaostatus_AntecipacaoStatusId",
                table: "antecipacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_antecipacoes",
                table: "antecipacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_antecipacaostatus",
                table: "antecipacaostatus");

            migrationBuilder.RenameTable(
                name: "antecipacoes",
                newName: "Antecipacoes");

            migrationBuilder.RenameTable(
                name: "antecipacaostatus",
                newName: "AntecipacaoStatus");

            migrationBuilder.RenameIndex(
                name: "IX_antecipacoes_AntecipacaoStatusId",
                table: "Antecipacoes",
                newName: "IX_Antecipacoes_AntecipacaoStatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Antecipacoes",
                table: "Antecipacoes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AntecipacaoStatus",
                table: "AntecipacaoStatus",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Antecipacoes_AntecipacaoStatus_AntecipacaoStatusId",
                table: "Antecipacoes",
                column: "AntecipacaoStatusId",
                principalTable: "AntecipacaoStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
