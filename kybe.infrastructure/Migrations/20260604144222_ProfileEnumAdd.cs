using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kybe.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProfileEnumAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Profile",
                table: "USERS",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profile",
                table: "USERS");
        }
    }
}
