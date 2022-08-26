using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations.Migrations
{
    public partial class RenameAllOrderToOrderNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Order",
                table: "Step",
                newName: "OrderNumber");

            migrationBuilder.RenameColumn(
                name: "Order",
                table: "Ingredient",
                newName: "OrderNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderNumber",
                table: "Step",
                newName: "Order");

            migrationBuilder.RenameColumn(
                name: "OrderNumber",
                table: "Ingredient",
                newName: "Order");
        }
    }
}
