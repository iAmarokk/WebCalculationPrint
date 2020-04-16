using Microsoft.EntityFrameworkCore.Migrations;

namespace WebCalculationPrint.Migrations
{
    public partial class ModelFormatEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ColourfulnessRate",
                table: "Format",
                newName: "FormatRate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FormatRate",
                table: "Format",
                newName: "ColourfulnessRate");
        }
    }
}
