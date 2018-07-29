using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class AddMappingAnticipationItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnticipationItem_antecipacoes_AnticipationId",
                table: "AnticipationItem");

            migrationBuilder.DropForeignKey(
                name: "FK_AnticipationItem_transacoes_TransactionId",
                table: "AnticipationItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnticipationItem",
                table: "AnticipationItem");

            migrationBuilder.RenameTable(
                name: "AnticipationItem",
                newName: "antecipacaoitens");

            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "antecipacaoitens",
                newName: "TransacaoId");

            migrationBuilder.RenameColumn(
                name: "AnticipationId",
                table: "antecipacaoitens",
                newName: "AntecipacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_AnticipationItem_TransactionId",
                table: "antecipacaoitens",
                newName: "IX_antecipacaoitens_TransacaoId");

            migrationBuilder.RenameIndex(
                name: "IX_AnticipationItem_AnticipationId",
                table: "antecipacaoitens",
                newName: "IX_antecipacaoitens_AntecipacaoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_antecipacaoitens",
                table: "antecipacaoitens",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_antecipacaoitens_antecipacoes_AntecipacaoId",
                table: "antecipacaoitens",
                column: "AntecipacaoId",
                principalTable: "antecipacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_antecipacaoitens_transacoes_TransacaoId",
                table: "antecipacaoitens",
                column: "TransacaoId",
                principalTable: "transacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_antecipacaoitens_antecipacoes_AntecipacaoId",
                table: "antecipacaoitens");

            migrationBuilder.DropForeignKey(
                name: "FK_antecipacaoitens_transacoes_TransacaoId",
                table: "antecipacaoitens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_antecipacaoitens",
                table: "antecipacaoitens");

            migrationBuilder.RenameTable(
                name: "antecipacaoitens",
                newName: "AnticipationItem");

            migrationBuilder.RenameColumn(
                name: "TransacaoId",
                table: "AnticipationItem",
                newName: "TransactionId");

            migrationBuilder.RenameColumn(
                name: "AntecipacaoId",
                table: "AnticipationItem",
                newName: "AnticipationId");

            migrationBuilder.RenameIndex(
                name: "IX_antecipacaoitens_TransacaoId",
                table: "AnticipationItem",
                newName: "IX_AnticipationItem_TransactionId");

            migrationBuilder.RenameIndex(
                name: "IX_antecipacaoitens_AntecipacaoId",
                table: "AnticipationItem",
                newName: "IX_AnticipationItem_AnticipationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnticipationItem",
                table: "AnticipationItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnticipationItem_antecipacoes_AnticipationId",
                table: "AnticipationItem",
                column: "AnticipationId",
                principalTable: "antecipacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnticipationItem_transacoes_TransactionId",
                table: "AnticipationItem",
                column: "TransactionId",
                principalTable: "transacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
