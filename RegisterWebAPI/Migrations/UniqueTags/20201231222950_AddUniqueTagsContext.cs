using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisterWebAPI.Migrations.UniqueTags
{
    public partial class AddUniqueTagsContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UniqueTags",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Tag1 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag2 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag3 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag4 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag5 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag6 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag7 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag8 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag9 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag10 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag11 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag12 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag13 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag14 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag15 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag16 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag17 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag18 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag19 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag20 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag21 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag22 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag23 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag24 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag25 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag26 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag27 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag28 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag29 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag30 = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniqueTags", x => x.Email);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniqueTags");
        }
    }
}
