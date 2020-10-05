using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaMario.Models;

namespace PizzaMario.EntityConfiguration
{
    public class OrderLineConfiguration : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> builder)
        {
            // Property Configuration
            builder.Property(o => o.Amount)
                .IsRequired();

            builder.Property(ol => ol.TotalPrice)
                .HasColumnType("decimal(6,2)");
        }
    }
}