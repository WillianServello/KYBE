using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kybe.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class adicionandoCpf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "USERS",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "USERS");
        }
    }
}
