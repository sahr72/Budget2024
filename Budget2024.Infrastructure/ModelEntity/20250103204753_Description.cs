using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Budget2024.Infrastructure.ModelEntity
{
    /// <inheritdoc />
    public partial class Description : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CorpsPr",
                schema: "statutPartic",
                table: "CorpsPrincipals",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Corps",
                schema: "statutPartic",
                table: "Corps1s",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                schema: "statutPartic",
                table: "CorpsPrincipals",
                newName: "CorpsPr");

            migrationBuilder.RenameColumn(
                name: "Description",
                schema: "statutPartic",
                table: "Corps1s",
                newName: "Corps");
        }
    }
}
