using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaMario.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryRanges",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    MaxRange = table.Column<string>(nullable: true),
                    MinRange = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryRanges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pricings",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sauces",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsSpicy = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sauces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Townships",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Code = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Townships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryCoupons",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CategoryId = table.Column<string>(nullable: true),
                    DiscountValue = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryCoupons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryCoupons_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CategoryId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Crusts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Diameter = table.Column<int>(nullable: false),
                    PricingId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crusts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Crusts_Pricings_PricingId",
                        column: x => x.PricingId,
                        principalTable: "Pricings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsSpicy = table.Column<bool>(nullable: false),
                    IsVegy = table.Column<bool>(nullable: false),
                    PricingId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_Pricings_PricingId",
                        column: x => x.PricingId,
                        principalTable: "Pricings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: true),
                    HouseNumber = table.Column<string>(nullable: true),
                    Addition = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    SeriesIndicationStart = table.Column<int>(nullable: false),
                    SeriesIndicationEnd = table.Column<int>(nullable: false),
                    TownshipId1 = table.Column<string>(nullable: true),
                    TownshipId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Townships_TownshipId1",
                        column: x => x.TownshipId1,
                        principalTable: "Townships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Addition = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    AddressId1 = table.Column<string>(nullable: true),
                    AddressId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Addresses_AddressId1",
                        column: x => x.AddressId1,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StoreNumber = table.Column<int>(nullable: false),
                    CountryCode = table.Column<string>(nullable: true),
                    AddressId1 = table.Column<string>(nullable: true),
                    AddressId = table.Column<int>(nullable: false),
                    DeliveryRangeId1 = table.Column<string>(nullable: true),
                    DeliveryRangeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stores_Addresses_AddressId1",
                        column: x => x.AddressId1,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stores_DeliveryRanges_DeliveryRangeId1",
                        column: x => x.DeliveryRangeId1,
                        principalTable: "DeliveryRanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AlternateOpeningHours",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Weekday = table.Column<int>(nullable: false),
                    OpeningTime = table.Column<DateTime>(nullable: false),
                    ClosingTime = table.Column<DateTime>(nullable: false),
                    IsClosed = table.Column<bool>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    StoreId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlternateOpeningHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlternateOpeningHours_Stores_StoreId1",
                        column: x => x.StoreId1,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OpeningHours",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Weekday = table.Column<int>(nullable: false),
                    OpeningTime = table.Column<DateTime>(nullable: false),
                    ClosingTime = table.Column<DateTime>(nullable: false),
                    IsClosed = table.Column<bool>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    StoreId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpeningHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpeningHours_Stores_StoreId1",
                        column: x => x.StoreId1,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsAvailable = table.Column<bool>(nullable: false),
                    SauceId = table.Column<string>(nullable: true),
                    CrustId = table.Column<string>(nullable: true),
                    CategoryId = table.Column<string>(nullable: true),
                    SubCategoryId = table.Column<string>(nullable: true),
                    PricingId = table.Column<string>(nullable: true),
                    OrderLineId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Crusts_CrustId",
                        column: x => x.CrustId,
                        principalTable: "Crusts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Pricings_PricingId",
                        column: x => x.PricingId,
                        principalTable: "Pricings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Sauces_SauceId",
                        column: x => x.SauceId,
                        principalTable: "Sauces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductCoupons",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ProductId = table.Column<string>(nullable: true),
                    DiscountValue = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCoupons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCoupons_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    StoreId = table.Column<string>(nullable: true),
                    CustomerId = table.Column<string>(nullable: true),
                    StatusId = table.Column<string>(nullable: true),
                    PaymentTypeId = table.Column<string>(nullable: true),
                    ProductCouponId = table.Column<string>(nullable: true),
                    CategoryCouponId = table.Column<string>(nullable: true),
                    StoreNumber = table.Column<string>(nullable: true),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerZipcode = table.Column<string>(nullable: true),
                    CustomerHouseNumber = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_CategoryCoupons_CategoryCouponId",
                        column: x => x.CategoryCouponId,
                        principalTable: "CategoryCoupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_ProductCoupons_ProductCouponId",
                        column: x => x.ProductCouponId,
                        principalTable: "ProductCoupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderLines",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    OrderId1 = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderLines_Orders_OrderId1",
                        column: x => x.OrderId1,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_TownshipId1",
                table: "Addresses",
                column: "TownshipId1");

            migrationBuilder.CreateIndex(
                name: "IX_AlternateOpeningHours_StoreId1",
                table: "AlternateOpeningHours",
                column: "StoreId1");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryCoupons_CategoryId",
                table: "CategoryCoupons",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Crusts_PricingId",
                table: "Crusts",
                column: "PricingId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressId1",
                table: "Customers",
                column: "AddressId1");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_PricingId",
                table: "Ingredients",
                column: "PricingId");

            migrationBuilder.CreateIndex(
                name: "IX_OpeningHours_StoreId1",
                table: "OpeningHours",
                column: "StoreId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLines_OrderId1",
                table: "OrderLines",
                column: "OrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CategoryCouponId",
                table: "Orders",
                column: "CategoryCouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentTypeId",
                table: "Orders",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductCouponId",
                table: "Orders",
                column: "ProductCouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusId",
                table: "Orders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreId",
                table: "Orders",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCoupons_ProductId",
                table: "ProductCoupons",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CrustId",
                table: "Products",
                column: "CrustId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderLineId",
                table: "Products",
                column: "OrderLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PricingId",
                table: "Products",
                column: "PricingId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SauceId",
                table: "Products",
                column: "SauceId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_AddressId1",
                table: "Stores",
                column: "AddressId1");

            migrationBuilder.CreateIndex(
                name: "IX_Stores_DeliveryRangeId1",
                table: "Stores",
                column: "DeliveryRangeId1");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OrderLines_OrderLineId",
                table: "Products",
                column: "OrderLineId",
                principalTable: "OrderLines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Townships_TownshipId1",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryCoupons_Categories_CategoryId",
                table: "CategoryCoupons");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_CategoryId",
                table: "SubCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Crusts_Pricings_PricingId",
                table: "Crusts");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Pricings_PricingId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_AddressId1",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderLines_Orders_OrderId1",
                table: "OrderLines");

            migrationBuilder.DropTable(
                name: "AlternateOpeningHours");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "OpeningHours");

            migrationBuilder.DropTable(
                name: "Townships");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "DeliveryRanges");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Pricings");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "CategoryCoupons");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "ProductCoupons");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Crusts");

            migrationBuilder.DropTable(
                name: "OrderLines");

            migrationBuilder.DropTable(
                name: "Sauces");

            migrationBuilder.DropTable(
                name: "SubCategories");
        }
    }
}
