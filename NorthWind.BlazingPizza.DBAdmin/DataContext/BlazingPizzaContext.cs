using Microsoft.EntityFrameworkCore;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
//Modelo de datos
namespace NorthWind.BlazingPizza.DBAdmin.DataContext
{
	//el context de EF, es como una tabla temporal
	internal class BlazingPizzaContext: DbContext
	{
		//indicar la bd, motor de bd, sobreeescribiendo  OnConfiguring
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			
			optionsBuilder.UseSqlServer(
				"Server=(localdb)\\mssqllocaldb;Database=BlazingPizza;");
			base.OnConfiguring(optionsBuilder);
		}

	
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(
				GetType().Assembly);
			base.OnModelCreating(modelBuilder);
		}

		
		public DbSet<PizzaSpecial> PizzaSpecials { get; set; }
		public DbSet<Topping> Topping { get; set; }

	}
}
