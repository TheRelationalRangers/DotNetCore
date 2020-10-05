using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaMario.Migrations
{
    public partial class fixedIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Townships_TownshipId1",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_AlternateOpeningHours_Stores_StoreId1",
                table: "AlternateOpeningHours");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_AddressId1",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_OpeningHours_Stores_StoreId1",
                table: "OpeningHours");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Orders_OrderId1",
                table: "OrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Addresses_AddressId1",
                table: "Stores");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_DeliveryRanges_DeliveryRangeId1",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_AddressId1",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_DeliveryRangeId1",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_OrderLines_OrderId1",
                table: "OrderLines");

            migrationBuilder.DropIndex(
                name: "IX_OpeningHours_StoreId1",
                table: "OpeningHours");

            migrationBuilder.DropIndex(
                name: "IX_Customers_AddressId1",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_AlternateOpeningHours_StoreId1",
                table: "AlternateOpeningHours");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_TownshipId1",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "AddressId1",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "DeliveryRangeId1",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "OrderId1",
                table: "OrderLines");

            migrationBuilder.DropColumn(
                name: "StoreId1",
                table: "OpeningHours");

            migrationBuilder.DropColumn(
                name: "IsVegy",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "AddressId1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StoreId1",
                table: "AlternateOpeningHours");

            migrationBuilder.DropColumn(
                name: "TownshipId1",
                table: "Addresses");

            migrationBuilder.AlterColumn<string>(
                name: "DeliveryRangeId",
                table: "Stores",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AddressId",
                table: "Stores",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "OrderLines",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "OrderId",
                table: "OrderLines",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "StoreId",
                table: "OpeningHours",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsVeggy",
                table: "Ingredients",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "AddressId",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "StoreId",
                table: "AlternateOpeningHours",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TownshipId",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_AddressId",
                table: "Stores",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_DeliveryRangeId",
                table: "Stores",
                column: "DeliveryRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderId",
                table: "OrderLines",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OpeningHours_StoreId",
                table: "OpeningHours",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressId",
                table: "Customers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_AlternateOpeningHours_StoreId",
                table: "AlternateOpeningHours",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_TownshipId",
                table: "Addresses",
                column: "TownshipId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Townships_TownshipId",
                table: "Addresses",
                column: "TownshipId",
                principalTable: "Townships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AlternateOpeningHours_Stores_StoreId",
                table: "AlternateOpeningHours",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_AddressId",
                table: "Customers",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpeningHours_Stores_StoreId",
                table: "OpeningHours",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Orders_OrderId",
                table: "OrderLines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Addresses_AddressId",
                table: "Stores",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_DeliveryRanges_DeliveryRangeId",
                table: "Stores",
                column: "DeliveryRangeId",
                principalTable: "DeliveryRanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Townships_TownshipId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_AlternateOpeningHours_Stores_StoreId",
                table: "AlternateOpeningHours");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_AddressId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_OpeningHours_Stores_StoreId",
                table: "OpeningHours");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Orders_OrderId",
                table: "OrderLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Addresses_AddressId",
                table: "Stores");

            migrationBuilder.DropForeignKey(
                name: "FK_Stores_DeliveryRanges_DeliveryRangeId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_AddressId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Stores_DeliveryRangeId",
                table: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_OrderLines_OrderId",
                table: "OrderLines");

            migrationBuilder.DropIndex(
                name: "IX_OpeningHours_StoreId",
                table: "OpeningHours");

            migrationBuilder.DropIndex(
                name: "IX_Customers_AddressId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_AlternateOpeningHours_StoreId",
                table: "AlternateOpeningHours");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_TownshipId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "IsVeggy",
                table: "Ingredients");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryRangeId",
                table: "Stores",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Stores",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressId1",
                table: "Stores",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryRangeId1",
                table: "Stores",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "OrderLines",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderLines",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderId1",
                table: "OrderLines",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StoreId",
                table: "OpeningHours",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoreId1",
                table: "OpeningHours",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsVegy",
                table: "Ingredients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressId1",
                table: "Customers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StoreId",
                table: "AlternateOpeningHours",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoreId1",
                table: "AlternateOpeningHours",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TownshipId",
                table: "Addresses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TownshipId1",
                table: "Addresses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stores_AddressId1",
                table: "Stores",
                column: "AddressId1");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_DeliveryRangeId1",
                table: "Stores",
                column: "DeliveryRangeId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderId1",
                table: "OrderLines",
                column: "OrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_OpeningHours_StoreId1",
                table: "OpeningHours",
                column: "StoreId1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressId1",
                table: "Customers",
                column: "AddressId1");

            migrationBuilder.CreateIndex(
                name: "IX_AlternateOpeningHours_StoreId1",
                table: "AlternateOpeningHours",
                column: "StoreId1");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_TownshipId1",
                table: "Addresses",
                column: "TownshipId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Townships_TownshipId1",
                table: "Addresses",
                column: "TownshipId1",
                principalTable: "Townships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AlternateOpeningHours_Stores_StoreId1",
                table: "AlternateOpeningHours",
                column: "StoreId1",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_AddressId1",
                table: "Customers",
                column: "AddressId1",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OpeningHours_Stores_StoreId1",
                table: "OpeningHours",
                column: "StoreId1",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLines_Orders_OrderId1",
                table: "OrderLines",
                column: "OrderId1",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Addresses_AddressId1",
                table: "Stores",
                column: "AddressId1",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_DeliveryRanges_DeliveryRangeId1",
                table: "Stores",
                column: "DeliveryRangeId1",
                principalTable: "DeliveryRanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
