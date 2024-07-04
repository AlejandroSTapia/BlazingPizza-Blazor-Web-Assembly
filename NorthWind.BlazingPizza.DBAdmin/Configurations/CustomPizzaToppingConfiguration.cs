using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;

namespace NorthWind.BlazingPizza.DBAdmin.Configurations
{
    public class CustomPizzaToppingConfiguration : IEntityTypeConfiguration<CustomPizzaTopping>
    {
        //archivo de configuracion para definir las relaciones
        public void Configure(EntityTypeBuilder<CustomPizzaTopping> builder)
        {
            builder.HasKey(cpt =>
            new {cpt.CustomPizzaId, cpt.ToppingId});//llave primaria

            builder.HasOne<CustomPizza>()
                .WithMany(cp => cp.Toppings); //relacion 1 a *

            builder.HasOne(cpt => cpt.Topping)
                .WithMany();
        }
    }
}
