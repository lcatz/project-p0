using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storing.Migrations
{
    public partial class newerpizzamodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ToppingEntityID",
                table: "Pizzas",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    EntityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Meat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Veggie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sauce = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.EntityID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_ToppingEntityID",
                table: "Pizzas",
                column: "ToppingEntityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Toppings_ToppingEntityID",
                table: "Pizzas",
                column: "ToppingEntityID",
                principalTable: "Toppings",
                principalColumn: "EntityID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Toppings_ToppingEntityID",
                table: "Pizzas");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_ToppingEntityID",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "ToppingEntityID",
                table: "Pizzas");
        }
    }
}
