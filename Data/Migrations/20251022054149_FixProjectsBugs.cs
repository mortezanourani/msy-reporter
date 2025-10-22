using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Reporter.Migrations
{
    /// <inheritdoc />
    public partial class FixProjectsBugs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectBudgets_ConstructionProjects_ProjectId1",
                table: "ProjectBudgets");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectProgresses_ConstructionProjects_ProjectId1",
                table: "ProjectProgresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectProgresses",
                table: "ProjectProgresses");

            migrationBuilder.DropIndex(
                name: "IX_ProjectProgresses_ProjectId1",
                table: "ProjectProgresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectBudgets",
                table: "ProjectBudgets");

            migrationBuilder.DropIndex(
                name: "IX_ProjectBudgets_ProjectId1",
                table: "ProjectBudgets");

            migrationBuilder.RenameColumn(
                name: "ProjectId1",
                table: "ProjectProgresses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProjectId1",
                table: "ProjectBudgets",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectProgresses",
                table: "ProjectProgresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectBudgets",
                table: "ProjectBudgets",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProgresses_ProjectId",
                table: "ProjectProgresses",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBudgets_ProjectId",
                table: "ProjectBudgets",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectBudgets_ConstructionProjects_ProjectId",
                table: "ProjectBudgets",
                column: "ProjectId",
                principalTable: "ConstructionProjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectProgresses_ConstructionProjects_ProjectId",
                table: "ProjectProgresses",
                column: "ProjectId",
                principalTable: "ConstructionProjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectBudgets_ConstructionProjects_ProjectId",
                table: "ProjectBudgets");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectProgresses_ConstructionProjects_ProjectId",
                table: "ProjectProgresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectProgresses",
                table: "ProjectProgresses");

            migrationBuilder.DropIndex(
                name: "IX_ProjectProgresses_ProjectId",
                table: "ProjectProgresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectBudgets",
                table: "ProjectBudgets");

            migrationBuilder.DropIndex(
                name: "IX_ProjectBudgets_ProjectId",
                table: "ProjectBudgets");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProjectProgresses",
                newName: "ProjectId1");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ProjectBudgets",
                newName: "ProjectId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectProgresses",
                table: "ProjectProgresses",
                column: "ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectBudgets",
                table: "ProjectBudgets",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectProgresses_ProjectId1",
                table: "ProjectProgresses",
                column: "ProjectId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectBudgets_ProjectId1",
                table: "ProjectBudgets",
                column: "ProjectId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectBudgets_ConstructionProjects_ProjectId1",
                table: "ProjectBudgets",
                column: "ProjectId1",
                principalTable: "ConstructionProjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectProgresses_ConstructionProjects_ProjectId1",
                table: "ProjectProgresses",
                column: "ProjectId1",
                principalTable: "ConstructionProjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
