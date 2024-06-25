using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;

namespace NorthWind.BlazingPizza.DBAdmin.Configurations
{
	public class PizzaSpecialConfiguration : IEntityTypeConfiguration<PizzaSpecial>
	{
		public void Configure(EntityTypeBuilder<PizzaSpecial> builder)
		{
			builder.Property(s => s.BasePrice)
				.HasPrecision(8, 2);

			builder.HasData(
				[

				//Esto se hace, para que se inyecten los datos:
				new PizzaSpecial{
					Id = 1,
					Name = "Pizza clÃ¡sica de queso",
					BasePrice = 89.99m,
					Description = "Es de queso y delicioso. Â¿Por quÃ© no querrÃ­as una?",
					ImageUrl = "cheese.jpg"},

						new PizzaSpecial{
					Id = 2,
					Name = "Tocinator",
					BasePrice = 127.99m,
					Description = "iene TODO tipo de tocino",
					ImageUrl = "bacon.jpg"},

						new PizzaSpecial{
					Id = 3,
					Name = "ClÃ¡sica de pepperoni",
					BasePrice = 99.50m,
					Description = "Es la pizza con la que creciste, Â¡pero ardientemente deliciosa!",
					ImageUrl = "pepperoni.jpg"},

						new PizzaSpecial{
					Id = 4,
					Name = "Pollo bÃºfalo",
					BasePrice = 128.75m,
					Description = "Pollo picante, salsa picante y queso azul, garantizado que entrarÃ¡s en calor",
					ImageUrl = "meaty.jpg"},

						new PizzaSpecial{
					Id = 5,
					Name = "Amantes del champiÃ±Ã³n",
					BasePrice = 109.00m,
					Description = "Tiene champiÃ±ones. Â¿No es obvio?",
					ImageUrl = "mushroom.jpg"},

							new PizzaSpecial{
					Id = 6,
					Name = "Hawaiana",
					BasePrice = 90.25m,
					Description = "TDe piÃ±a, jamÃ³n y queso...",
					ImageUrl = "hawaiian.jpg"},

							new PizzaSpecial{
					Id = 7,
					Name = "Delicia vegetariana",
					BasePrice = 118.50m,
					Description = "Es como una ensalada, pero en una pizza",
					ImageUrl = "salad.jpg"},
				]);//tienes datos
		}
	}
}
