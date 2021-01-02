using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class firstmigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Stores_StoreEntityID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Users_UserEntityID",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Order_OrderEntityID",
                table: "Pizzas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AToppingModel",
                table: "AToppingModel");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "AToppingModel",
                newName: "Toppings");

            migrationBuilder.RenameColumn(
                name: "UserEntityID",
                table: "Orders",
                newName: "UsersEntityID");

            migrationBuilder.RenameColumn(
                name: "StoreEntityID",
                table: "Orders",
                newName: "StoresEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserEntityID",
                table: "Orders",
                newName: "IX_Orders_UsersEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_StoreEntityID",
                table: "Orders",
                newName: "IX_Orders_StoresEntityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "EntityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings",
                column: "EntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoresEntityID",
                table: "Orders",
                column: "StoresEntityID",
                principalTable: "Stores",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UsersEntityID",
                table: "Orders",
                column: "UsersEntityID",
                principalTable: "Users",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Orders_OrderEntityID",
                table: "Pizzas",
                column: "OrderEntityID",
                principalTable: "Orders",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoresEntityID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UsersEntityID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Orders_OrderEntityID",
                table: "Pizzas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Toppings",
                table: "Toppings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Toppings",
                newName: "AToppingModel");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameColumn(
                name: "UsersEntityID",
                table: "Order",
                newName: "UserEntityID");

            migrationBuilder.RenameColumn(
                name: "StoresEntityID",
                table: "Order",
                newName: "StoreEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UsersEntityID",
                table: "Order",
                newName: "IX_Order_UserEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_StoresEntityID",
                table: "Order",
                newName: "IX_Order_StoreEntityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AToppingModel",
                table: "AToppingModel",
                column: "EntityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "EntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Stores_StoreEntityID",
                table: "Order",
                column: "StoreEntityID",
                principalTable: "Stores",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Users_UserEntityID",
                table: "Order",
                column: "UserEntityID",
                principalTable: "Users",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Order_OrderEntityID",
                table: "Pizzas",
                column: "OrderEntityID",
                principalTable: "Order",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
