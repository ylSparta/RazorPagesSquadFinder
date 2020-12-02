using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesSquadFinder.Migrations
{
    public partial class AddSquadMembersPages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SquadMember",
                columns: table => new
                {
                    SquadMemberId = table.Column<string>(nullable: false),
                    SquadId = table.Column<string>(nullable: true),
                    MemberId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SquadMember", x => x.SquadMemberId);
                    table.ForeignKey(
                        name: "FK_SquadMember_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SquadMember_Squad_SquadId",
                        column: x => x.SquadId,
                        principalTable: "Squad",
                        principalColumn: "SquadId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SquadMember_MemberId",
                table: "SquadMember",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_SquadMember_SquadId",
                table: "SquadMember",
                column: "SquadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SquadMember");
        }
    }
}
