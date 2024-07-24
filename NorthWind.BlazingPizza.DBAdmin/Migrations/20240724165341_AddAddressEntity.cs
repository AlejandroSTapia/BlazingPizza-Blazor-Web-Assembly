using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NorthWind.BlazingPizza.DBAdmin.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "blazingPizza");

            migrationBuilder.CreateTable(
                name: "Address",
                schema: "blazingPizza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PizzaSpecials",
                schema: "blazingPizza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasePrice = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaSpecials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                schema: "blazingPizza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "blazingPizza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DeliveryAddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Address_DeliveryAddressId",
                        column: x => x.DeliveryAddressId,
                        principalSchema: "blazingPizza",
                        principalTable: "Address",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomPizza",
                schema: "blazingPizza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    PizzaSpecialId = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomPizza", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomPizza_Orders_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "blazingPizza",
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomPizza_PizzaSpecials_PizzaSpecialId",
                        column: x => x.PizzaSpecialId,
                        principalSchema: "blazingPizza",
                        principalTable: "PizzaSpecials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomPizzaTopping",
                schema: "blazingPizza",
                columns: table => new
                {
                    CustomPizzaId = table.Column<int>(type: "int", nullable: false),
                    ToppingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomPizzaTopping", x => new { x.CustomPizzaId, x.ToppingId });
                    table.ForeignKey(
                        name: "FK_CustomPizzaTopping_CustomPizza_CustomPizzaId",
                        column: x => x.CustomPizzaId,
                        principalSchema: "blazingPizza",
                        principalTable: "CustomPizza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomPizzaTopping_Toppings_ToppingId",
                        column: x => x.ToppingId,
                        principalSchema: "blazingPizza",
                        principalTable: "Toppings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "blazingPizza",
                table: "PizzaSpecials",
                columns: new[] { "Id", "BasePrice", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 89.99m, "Es de queso y delicioso. Â¿Por quÃ© no querrÃ­as una?", "cheese.jpg", "Pizza clÃ¡sica de queso" },
                    { 2, 127.99m, "iene TODO tipo de tocino", "bacon.jpg", "Tocinator" },
                    { 3, 99.50m, "Es la pizza con la que creciste, Â¡pero ardientemente deliciosa!", "pepperoni.jpg", "ClÃ¡sica de pepperoni" },
                    { 4, 128.75m, "Pollo picante, salsa picante y queso azul, garantizado que entrarÃ¡s en calor", "meaty.jpg", "Pollo bÃºfalo" },
                    { 5, 109.00m, "Tiene champiÃ±ones. Â¿No es obvio?", "mushroom.jpg", "Amantes del champiÃ±Ã³n" },
                    { 6, 90.25m, "TDe piÃ±a, jamÃ³n y queso...", "hawaiian.jpg", "Hawaiana" },
                    { 7, 118.50m, "Es como una ensalada, pero en una pizza", "salad.jpg", "Delicia vegetariana" }
                });

            migrationBuilder.InsertData(
                schema: "blazingPizza",
                table: "Toppings",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Queso extra", 23.50m },
                    { 2, "Tocino de pavo", 28.80m },
                    { 3, "Tocino de jabalÃ­", 28.80m },
                    { 4, "Tocino de ternera", 28.80m },
                    { 5, "TÃ© y bollos", 47.00m },
                    { 6, "Bollos reciÃ©n horneados", 43.50m },
                    { 7, "Pimiento", 9.00m },
                    { 8, "Cebolla", 9.00m },
                    { 9, "ChampiÃ±ones", 9.00m },
                    { 10, "Pepperoni", 9.00m },
                    { 11, "Salchicha de pato", 30.80m },
                    { 12, "AlbÃ³ndigas de venado", 24.50m },
                    { 13, "Cubierta de langosta", 612.50m },
                    { 14, "Caviar de esturiÃ³n", 965.25m },
                    { 15, "Corazones de alcachofa", 32.60m },
                    { 16, "Tomates frescos", 19.00m },
                    { 17, "Albahaca", 19.00m },
                    { 18, "Filete", 80.50m },
                    { 19, "Pimientos picantes", 39.80m },
                    { 20, "Pollo bÃºfalo", 48.00m },
                    { 21, "Queso azul", 24.50m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomPizza_OrderId",
                schema: "blazingPizza",
                table: "CustomPizza",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomPizza_PizzaSpecialId",
                schema: "blazingPizza",
                table: "CustomPizza",
                column: "PizzaSpecialId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomPizzaTopping_ToppingId",
                schema: "blazingPizza",
                table: "CustomPizzaTopping",
                column: "ToppingId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryAddressId",
                schema: "blazingPizza",
                table: "Orders",
                column: "DeliveryAddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomPizzaTopping",
                schema: "blazingPizza");

            migrationBuilder.DropTable(
                name: "CustomPizza",
                schema: "blazingPizza");

            migrationBuilder.DropTable(
                name: "Toppings",
                schema: "blazingPizza");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "blazingPizza");

            migrationBuilder.DropTable(
                name: "PizzaSpecials",
                schema: "blazingPizza");

            migrationBuilder.DropTable(
                name: "Address",
                schema: "blazingPizza");
        }
    }
}
