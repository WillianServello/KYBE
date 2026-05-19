using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kybe.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "USERS",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false),
                    CREATE_AT = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UPDATE_AT = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IS_ACTIVE = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NAME = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    PHONE_NUMBER = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    CITY = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    STATE = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    STREET = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    NUMBER = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    ZIPCODE = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    NEIGHBORHOOD = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    COMPLEMENT = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.ID);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "USERS");
        }
    }
}
