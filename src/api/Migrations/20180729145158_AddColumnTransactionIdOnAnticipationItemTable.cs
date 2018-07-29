using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class AddColumnTransactionIdOnAnticipationItemTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TransactionId",
                table: "AnticipationItem",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_AnticipationItem_TransactionId",
                table: "AnticipationItem",
                column: "TransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnticipationItem_transacoes_TransactionId",
                table: "AnticipationItem",
                column: "TransactionId",
                principalTable: "transacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnticipationItem_transacoes_TransactionId",
                table: "AnticipationItem");

            migrationBuilder.DropIndex(
                name: "IX_AnticipationItem_TransactionId",
                table: "AnticipationItem");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "AnticipationItem");
        }
    }
}
