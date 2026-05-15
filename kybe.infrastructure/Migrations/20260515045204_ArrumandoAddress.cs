using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kybe.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ArrumandoAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "USERS",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "USERS",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "USERS");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "USERS");
        }
    }
}
