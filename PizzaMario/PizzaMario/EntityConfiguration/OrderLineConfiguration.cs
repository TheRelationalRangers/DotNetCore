using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaMario.Models;

namespace PizzaMario.EntityConfiguration
{
    public class OrderLineConfiguration : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> builder)
        {
            builder.Property(ol => ol.TotalPrice)
                .HasColumnType("decimal(6,2)");
        }
    }
}