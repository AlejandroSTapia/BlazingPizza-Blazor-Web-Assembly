using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;

namespace NorthWind.BlazingPizza.DBAdmin.Configurations
{
    public class CustomPizzaConfiguration : IEntityTypeConfiguration<CustomPizza>
    {
        public void Configure(EntityTypeBuilder<CustomPizza> builder)
        {
            builder.Property(cp => cp.TotalPrice)
                .HasPrecision(8, 2);
        }
    }
}
