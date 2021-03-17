using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisterWebAPI.Migrations.Roster
{
    public partial class AddRosterContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RosterChamps",
                columns: table => new
                {
                    PMId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: false),
                    ChampionName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Lane = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Tag1 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag2 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag3 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag4 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag5 = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Tag6 = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RosterChamps", x => x.PMId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RosterChamps");
        }
    }
}
