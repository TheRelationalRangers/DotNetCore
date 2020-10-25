using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaMario.Migrations
{
    public partial class spCrust : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var spCrust = @"CREATE PROCEDURE [dbo].[InsertCrust]
                        @Name varchar(100), @Description varchar(255), @Diameter int,
                        @Availability varchar(3), @Price decimal(4,2), @PriceStartDate date, 
                        @PriceEndDate date, @PriceTax decimal(4,2)                      
                            AS
                            BEGIN        
                                SET NOCOUNT ON;
                                DECLARE @PricingId varchar(max);
                                SET @PricingId = NEWID();

                                INSERT INTO Pricings([Id], [Price], [StartDate], [EndDate], [Tax])
                                VALUES(@PricingId, @Price, @PriceStartDate, @PriceEndDAte, @PriceTax)
                                
                                INSERT INTO Crusts([Id], [Name], [Diameter], [Description], [PricingId], [Availability])
                                VALUES(NEWID(), @Name, @Diameter, @Description, @PricingId, @Availability)
                            END
                            GO";


            migrationBuilder.AddColumn<string>(
                name: "PricingId",
                table: "Sauces",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Availability",
                table: "Crusts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Crusts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sauces_PricingId",
                table: "Sauces",
                column: "PricingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sauces_Pricings_PricingId",
                table: "Sauces",
                column: "PricingId",
                principalTable: "Pricings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.Sql(spCrust);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sauces_Pricings_PricingId",
                table: "Sauces");

            migrationBuilder.DropIndex(
                name: "IX_Sauces_PricingId",
                table: "Sauces");

            migrationBuilder.DropColumn(
                name: "PricingId",
                table: "Sauces");

            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Crusts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Crusts");
        }
    }
}
