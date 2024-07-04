using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.DBAdmin.Configurations;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;
using System.Diagnostics;

namespace NorthWind.BlazingPizza.EFCore.DataSources.DataSources
{
    internal class BlazingPizzaContext(IOptions<DBOptions> options) :
		DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
            optionsBuilder.UseSqlServer(options.Value.ConnectionString)
          .LogTo(message => Debug.WriteLine(message))
          .EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(
				typeof(PizzaSpecialConfiguration).Assembly );
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<PizzaSpecial> PizzaSpecials { get; set; }
		public DbSet<Topping> Toppings { get; set; }
        public DbSet<CustomPizza> CustomPizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
