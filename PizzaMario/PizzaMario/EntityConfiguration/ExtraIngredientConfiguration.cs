using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaMario.Models;

namespace PizzaMario.EntityConfiguration
{
    public class ExtraIngredientConfiguration : IEntityTypeConfiguration<ExtraIngredient>
    {
        public void Configure(EntityTypeBuilder<ExtraIngredient> builder)
        {
            builder.Property(e => e.ExtraPrice)
                .HasColumnType("decimal(5,2)");
        }
    }
}