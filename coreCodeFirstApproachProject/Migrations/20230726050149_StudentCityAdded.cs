using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coreCodeFirstApproachProject.Migrations
{
    /// <inheritdoc />
    public partial class StudentCityAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Course",
                table: "Students",
                newName: "City");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "Students",
                newName: "Course");
        }
    }
}
