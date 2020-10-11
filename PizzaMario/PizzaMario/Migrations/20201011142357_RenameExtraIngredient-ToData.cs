using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaMario.Migrations
{
    public partial class RenameExtraIngredientToData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ExtraIngredients",
                table: "ExtraIngredients");

            migrationBuilder.RenameTable(
                name: "ExtraIngredients",
                newName: "ExtraIngredientsData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExtraIngredientsData",
                table: "ExtraIngredientsData",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ExtraIngredientsData",
                table: "ExtraIngredientsData");

            migrationBuilder.RenameTable(
                name: "ExtraIngredientsData",
                newName: "ExtraIngredients");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExtraIngredients",
                table: "ExtraIngredients",
                column: "Id");
        }
    }
}
