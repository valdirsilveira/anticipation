using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class RenameTableAnticipationItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "AnticipationItem",
                newName: "antecipacaoitens");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "antecipacaoitens",
                newName: "AnticipationItem");
        }
    }
}
