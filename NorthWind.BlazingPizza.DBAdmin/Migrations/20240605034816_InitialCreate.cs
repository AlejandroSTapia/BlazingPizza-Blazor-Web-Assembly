using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NorthWind.BlazingPizza.DBAdmin.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PizzaSpecials",
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

            migrationBuilder.InsertData(
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaSpecials");
        }
    }
}
