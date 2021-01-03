using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class firstmigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UsersEntityID",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "UsersEntityID",
                table: "Orders",
                newName: "UserEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UsersEntityID",
                table: "Orders",
                newName: "IX_Orders_UserEntityID");

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
                name: "FK_Orders_Users_UserEntityID",
                table: "Orders",
                column: "UserEntityID",
                principalTable: "Users",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Orders_Users_UserEntityID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Orders_OrderEntityID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_OrderEntityID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OrderEntityID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserEntityID",
                table: "Orders",
                newName: "UsersEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserEntityID",
                table: "Orders",
                newName: "IX_Orders_UsersEntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UsersEntityID",
                table: "Orders",
                column: "UsersEntityID",
                principalTable: "Users",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
