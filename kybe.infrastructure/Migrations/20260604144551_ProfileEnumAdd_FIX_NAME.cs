using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kybe.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProfileEnumAdd_FIX_NAME : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Profile",
                table: "USERS",
                newName: "PROFILE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PROFILE",
                table: "USERS",
                newName: "Profile");
        }
    }
}
