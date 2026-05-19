using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kybe.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class lastnameuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LAST_NAME",
                table: "USERS",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LAST_NAME",
                table: "USERS");
        }
    }
}
