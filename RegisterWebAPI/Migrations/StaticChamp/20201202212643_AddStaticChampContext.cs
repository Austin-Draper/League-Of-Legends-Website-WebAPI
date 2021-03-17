using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegisterWebAPI.Migrations.StaticChamp
{
    public partial class AddStaticChampContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StaticChamps",
                columns: table => new
                {
                    PMId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChampionName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Assassin = table.Column<bool>(nullable: false),
                    Fighter = table.Column<bool>(nullable: false),
                    Mage = table.Column<bool>(nullable: false),
                    Marksman = table.Column<bool>(nullable: false),
                    Support = table.Column<bool>(nullable: false),
                    Tank = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticChamps", x => x.PMId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaticChamps");
        }
    }
}
