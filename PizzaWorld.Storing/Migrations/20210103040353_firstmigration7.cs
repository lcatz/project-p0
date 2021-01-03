using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class firstmigration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "OrderEntityID",
                table: "Users",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrderEntityID",
                table: "Users",
                column: "OrderEntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Orders_OrderEntityID",
                table: "Users",
                column: "OrderEntityID",
                principalTable: "Orders",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Orders_OrderEntityID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_OrderEntityID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OrderEntityID",
                table: "Users");
        }
    }
}
