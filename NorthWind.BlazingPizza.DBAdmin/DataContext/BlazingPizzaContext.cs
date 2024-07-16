using Microsoft.EntityFrameworkCore;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;

//Modelo de datos
namespace NorthWind.BlazingPizza.DBAdmin.DataContext
{
    //el context de EF, es como una tabla temporal
    internal class BlazingPizzaContext: DbContext
	{
		//indicar la bd a crear, motor de bd, sobreeescribiendo  OnConfiguring
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// Se coloco en duro para crear objts nuevo a la base de datos
			optionsBuilder.UseSqlServer(
                "Server=tcp:devst.database.windows.net,1433;Initial Catalog=STDev_DB;Persist Security Info=False;User ID=devst;Password=Alex1122;" +
				"MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			base.OnConfiguring(optionsBuilder);
		}


		//cuando se cree el modelo se configure las entidades
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(
				GetType().Assembly);
			base.OnModelCreating(modelBuilder);
		}

		//Representacion de las tablas
		public DbSet<PizzaSpecial> PizzaSpecials { get; set; }
		public DbSet<Topping> Toppings { get; set; }
		public DbSet<CustomPizza> CustomPizzas { get; set; }
		public DbSet<Order> Orders { get; set; }

	}
}
