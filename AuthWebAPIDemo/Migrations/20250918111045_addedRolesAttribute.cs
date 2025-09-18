using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthWebAPIDemo.Migrations
{
    /// <inheritdoc />
    public partial class addedRolesAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Roles",
                table: "WebAPIUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Roles",
                table: "WebAPIUsers");
        }
    }
}
