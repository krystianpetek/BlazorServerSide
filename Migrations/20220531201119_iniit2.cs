using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerSide.Migrations
{
    public partial class iniit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WSKs",
                columns: new[] { "ProductionYearDate", "EngineNumberFrom", "EngineNumberTo", "FrameNumberFrom", "FrameNumberTo", "SupposedEngineNumberFrom", "SupposedEngineNumberTo", "SupposedFrameNumberFrom", "SupposedFrameNumberTo" },
                values: new object[] { 1957, 113357, 178145, 18103, 45445, null, null, null, null });

            migrationBuilder.InsertData(
                table: "WSKs",
                columns: new[] { "ProductionYearDate", "EngineNumberFrom", "EngineNumberTo", "FrameNumberFrom", "FrameNumberTo", "SupposedEngineNumberFrom", "SupposedEngineNumberTo", "SupposedFrameNumberFrom", "SupposedFrameNumberTo" },
                values: new object[] { 1958, 171137, 236338, 40514, 83532, null, null, 44670, 80671 });

            migrationBuilder.InsertData(
                table: "WSKs",
                columns: new[] { "ProductionYearDate", "EngineNumberFrom", "EngineNumberTo", "FrameNumberFrom", "FrameNumberTo", "SupposedEngineNumberFrom", "SupposedEngineNumberTo", "SupposedFrameNumberFrom", "SupposedFrameNumberTo" },
                values: new object[] { 1959, 192369, 251375, 84194, 126763, 0, 71860, 80672, 122763 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WSKs",
                keyColumn: "ProductionYearDate",
                keyValue: 1957);

            migrationBuilder.DeleteData(
                table: "WSKs",
                keyColumn: "ProductionYearDate",
                keyValue: 1958);

            migrationBuilder.DeleteData(
                table: "WSKs",
                keyColumn: "ProductionYearDate",
                keyValue: 1959);
        }
    }
}
