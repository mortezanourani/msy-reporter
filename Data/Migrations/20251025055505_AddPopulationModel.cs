using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reporter.Migrations
{
    /// <inheritdoc />
    public partial class AddPopulationModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Population",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    UrbanMen = table.Column<int>(type: "int", nullable: false),
                    UrbanWomen = table.Column<int>(type: "int", nullable: false),
                    RuralMen = table.Column<int>(type: "int", nullable: false),
                    RuralWomen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Population", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Population_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Population_CityId",
                table: "Population",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Population");
        }
    }
}
