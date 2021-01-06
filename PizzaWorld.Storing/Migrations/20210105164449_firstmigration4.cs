using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class firstmigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Pizzas_PizzaEntityID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PizzaEntityID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PizzaEntityID",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "PizzaEntityID",
                table: "Orders",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PizzaEntityID",
                table: "Orders",
                column: "PizzaEntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Pizzas_PizzaEntityID",
                table: "Orders",
                column: "PizzaEntityID",
                principalTable: "Pizzas",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
