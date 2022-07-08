using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerSide.Migrations
{
    public partial class iniit21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WSKs",
                columns: new[] { "ProductionYearDate", "EngineNumberFrom", "EngineNumberTo", "FrameNumberFrom", "FrameNumberTo", "SupposedEngineNumberFrom", "SupposedEngineNumberTo", "SupposedFrameNumberFrom", "SupposedFrameNumberTo" },
                values: new object[] { 1960, null, null, 132985, 212064, null, null, 122764, 170764 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WSKs",
                keyColumn: "ProductionYearDate",
                keyValue: 1960);
        }
    }
}
