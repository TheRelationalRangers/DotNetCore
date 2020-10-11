using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaMario.Migrations
{
    public partial class UpdateStoreDataShadowTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "StoreData",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "StoreData");
        }
    }
}
