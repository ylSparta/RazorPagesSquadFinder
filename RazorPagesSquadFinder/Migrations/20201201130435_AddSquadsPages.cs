using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesSquadFinder.Migrations
{
    public partial class AddSquadsPages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Squad",
                columns: table => new
                {
                    SquadId = table.Column<string>(nullable: false),
                    SquadLeader = table.Column<string>(nullable: true),
                    NoOfSquadMembers = table.Column<int>(nullable: false),
                    Sport = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squad", x => x.SquadId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Squad");
        }
    }
}
