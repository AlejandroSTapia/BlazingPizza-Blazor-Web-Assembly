using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
