using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaMario.Migrations
{
    public partial class AddExtraIngredientsShadowTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExtraIngredients",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Ingredient = table.Column<string>(nullable: true),
                    ExtraPrice = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraIngredients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExtraIngredients");
        }
    }
}