using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HandAndFoot.Migrations
{
    public partial class ModlesAreStrings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameTables",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameTableID = table.Column<string>(nullable: true),
                    GameDeck = table.Column<string>(nullable: true),
                    DiscardPile = table.Column<string>(nullable: true),
                    PlayersList = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTables", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameTableID = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Hand = table.Column<string>(nullable: true),
                    Foot = table.Column<string>(nullable: true),
                    Books = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameTables");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
