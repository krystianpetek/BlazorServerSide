using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerSide.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WSKs",
                columns: table => new
                {
                    ProductionYearDate = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FrameNumberFrom = table.Column<int>(type: "INTEGER", nullable: true),
                    FrameNumberTo = table.Column<int>(type: "INTEGER", nullable: true),
                    EngineNumberFrom = table.Column<int>(type: "INTEGER", nullable: true),
                    EngineNumberTo = table.Column<int>(type: "INTEGER", nullable: true),
                    SupposedFrameNumberFrom = table.Column<int>(type: "INTEGER", nullable: true),
                    SupposedFrameNumberTo = table.Column<int>(type: "INTEGER", nullable: true),
                    SupposedEngineNumberFrom = table.Column<int>(type: "INTEGER", nullable: true),
                    SupposedEngineNumberTo = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WSKs", x => x.ProductionYearDate);
                });

            migrationBuilder.InsertData(
                table: "WSKs",
                columns: new[] { "ProductionYearDate", "EngineNumberFrom", "EngineNumberTo", "FrameNumberFrom", "FrameNumberTo", "SupposedEngineNumberFrom", "SupposedEngineNumberTo", "SupposedFrameNumberFrom", "SupposedFrameNumberTo" },
                values: new object[] { 1954, null, null, null, null, null, null, 1, 40 });

            migrationBuilder.InsertData(
                table: "WSKs",
                columns: new[] { "ProductionYearDate", "EngineNumberFrom", "EngineNumberTo", "FrameNumberFrom", "FrameNumberTo", "SupposedEngineNumberFrom", "SupposedEngineNumberTo", "SupposedFrameNumberFrom", "SupposedFrameNumberTo" },
                values: new object[] { 1955, 42515, 57831, 173, 1288, null, null, 40, 3166 });

            migrationBuilder.InsertData(
                table: "WSKs",
                columns: new[] { "ProductionYearDate", "EngineNumberFrom", "EngineNumberTo", "FrameNumberFrom", "FrameNumberTo", "SupposedEngineNumberFrom", "SupposedEngineNumberTo", "SupposedFrameNumberFrom", "SupposedFrameNumberTo" },
                values: new object[] { 1956, 70799, 115144, 2326, 17882, null, null, 3167, 10279 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WSKs");
        }
    }
}
