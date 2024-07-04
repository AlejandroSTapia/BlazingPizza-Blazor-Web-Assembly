using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;

namespace NorthWind.BlazingPizza.DBAdmin.Configurations
{
    internal class ToppingConfiguration : IEntityTypeConfiguration<Topping>
	{
		public void Configure(EntityTypeBuilder<Topping> builder)
		{
			builder.Property(t => t.Price)
				.HasPrecision(8, 2);

			builder.HasData(
					new Topping { Id = 1, Name = "Queso extra", Price = 23.50m },
			new Topping { Id = 2, Name = "Tocino de pavo", Price = 28.80m },
			new Topping { Id = 3, Name = "Tocino de jabalÃ­", Price = 28.80m },
			new Topping { Id = 4, Name = "Tocino de ternera", Price = 28.80m },
			new Topping { Id = 5, Name = "TÃ© y bollos", Price = 47.00m },
			new Topping { Id = 6, Name = "Bollos reciÃ©n horneados", Price = 43.50m },
			new Topping { Id = 7, Name = "Pimiento", Price = 9.00m },
			new Topping { Id = 8, Name = "Cebolla", Price = 9.00m },
			new Topping { Id = 9, Name = "ChampiÃ±ones", Price = 9.00m },
			new Topping { Id = 10, Name = "Pepperoni", Price = 9.00m },
			new Topping { Id = 11, Name = "Salchicha de pato", Price = 30.80m },
			new Topping { Id = 12, Name = "AlbÃ³ndigas de venado", Price = 24.50m },
			new Topping { Id = 13, Name = "Cubierta de langosta", Price = 612.50m },
			new Topping { Id = 14, Name = "Caviar de esturiÃ³n", Price = 965.25m },
			new Topping { Id = 15, Name = "Corazones de alcachofa", Price = 32.60m },
			new Topping { Id = 16, Name = "Tomates frescos", Price = 19.00m },
			new Topping { Id = 17, Name = "Albahaca", Price = 19.00m },
			new Topping { Id = 18, Name = "Filete", Price = 80.50m },
			new Topping { Id = 19, Name = "Pimientos picantes", Price = 39.80m },
			new Topping { Id = 20, Name = "Pollo bÃºfalo", Price = 48.00m },
			new Topping { Id = 21, Name = "Queso azul", Price = 24.50m }
				);
		}
	}
}
