using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaMario.Migrations
{
    public partial class AddOrderDataShadowTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderData",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    StoreName = table.Column<string>(nullable: true),
                    CustomerName = table.Column<string>(nullable: true),
                    TelephoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    OrderDate = table.Column<string>(nullable: true),
                    DeliveryType = table.Column<string>(nullable: true),
                    DeliveryDate = table.Column<string>(nullable: true),
                    DeliveryMoment = table.Column<string>(nullable: true),
                    Product = table.Column<string>(nullable: true),
                    Crust = table.Column<string>(nullable: true),
                    Saus = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    DeliveryCost = table.Column<string>(nullable: true),
                    Amount = table.Column<string>(nullable: true),
                    ExtraIngredient = table.Column<string>(nullable: true),
                    ExtraIngredientPrice = table.Column<string>(nullable: true),
                    OrderLinePrice = table.Column<string>(nullable: true),
                    TotalOrderLinePrice = table.Column<string>(nullable: true),
                    UserCoupon = table.Column<string>(nullable: true),
                    CouponDiscount = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderData");
        }
    }
}