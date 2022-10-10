using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliveryCart.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shopper",
                columns: table => new
                {
                    ShopperID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ShopperName = table.Column<string>(type: "TEXT", nullable: false),
                    ShopperEmail = table.Column<string>(type: "TEXT", nullable: false),
                    ShopperPhone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shopper", x => x.ShopperID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shopper");
        }
    }
}
