using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.DataBaseLogic.Migrations;

public partial class Initial : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "FindRequest",
            columns: table => new
            {
                Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                LocatorUrl = table.Column<string>(type: "text", nullable: false),
                Locator = table.Column<string>(type: "text", nullable: false),
                RequestName = table.Column<string>(type: "text", nullable: false),
                ModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                ModifiedBy = table.Column<Guid>(type: "uuid", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_FindRequest", x => x.Id);
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "FindRequest");
    }
}
