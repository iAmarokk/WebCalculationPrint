using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebCalculationPrint.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                });

            migrationBuilder.CreateTable(
                name: "Colourfulness",
                columns: table => new
                {
                    ColourfulnessID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ColourfulnessRate = table.Column<decimal>(type: "decimal(10, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colourfulness", x => x.ColourfulnessID);
                });

            migrationBuilder.CreateTable(
                name: "Format",
                columns: table => new
                {
                    FormatID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ColourfulnessRate = table.Column<decimal>(type: "decimal(10, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Format", x => x.FormatID);
                });

            migrationBuilder.CreateTable(
                name: "Paper",
                columns: table => new
                {
                    PaperID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Thickness = table.Column<int>(nullable: false),
                    PaperCost = table.Column<decimal>(type: "decimal(10, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paper", x => x.PaperID);
                });

            migrationBuilder.CreateTable(
                name: "Calculation",
                columns: table => new
                {
                    CalculationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormatID = table.Column<int>(nullable: false),
                    PaperID = table.Column<int>(nullable: false),
                    ColourfulnessID = table.Column<int>(nullable: false),
                    TotalPages = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(10, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculation", x => x.CalculationID);
                    table.ForeignKey(
                        name: "FK_Calculation_Colourfulness_ColourfulnessID",
                        column: x => x.ColourfulnessID,
                        principalTable: "Colourfulness",
                        principalColumn: "ColourfulnessID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Calculation_Format_FormatID",
                        column: x => x.FormatID,
                        principalTable: "Format",
                        principalColumn: "FormatID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Calculation_Paper_PaperID",
                        column: x => x.PaperID,
                        principalTable: "Paper",
                        principalColumn: "PaperID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientID = table.Column<int>(nullable: false),
                    CalculationsID = table.Column<int>(nullable: false),
                    CalculationID = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Order_Calculation_CalculationID",
                        column: x => x.CalculationID,
                        principalTable: "Calculation",
                        principalColumn: "CalculationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calculation_ColourfulnessID",
                table: "Calculation",
                column: "ColourfulnessID");

            migrationBuilder.CreateIndex(
                name: "IX_Calculation_FormatID",
                table: "Calculation",
                column: "FormatID");

            migrationBuilder.CreateIndex(
                name: "IX_Calculation_PaperID",
                table: "Calculation",
                column: "PaperID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CalculationID",
                table: "Order",
                column: "CalculationID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientID",
                table: "Order",
                column: "ClientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Calculation");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Colourfulness");

            migrationBuilder.DropTable(
                name: "Format");

            migrationBuilder.DropTable(
                name: "Paper");
        }
    }
}
