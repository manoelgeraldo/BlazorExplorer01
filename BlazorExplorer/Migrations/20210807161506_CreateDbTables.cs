using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorExplorer.Migrations
{
    public partial class CreateDbTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Table01s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampoTable01 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table01s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table02s",
                columns: table => new
                {
                    Table01Id = table.Column<int>(type: "int", nullable: false),
                    CampoTable02 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table02s", x => x.Table01Id);
                    table.ForeignKey(
                        name: "FK_Table02s_Table01s_Table01Id",
                        column: x => x.Table01Id,
                        principalTable: "Table01s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table02s");

            migrationBuilder.DropTable(
                name: "Table01s");
        }
    }
}
