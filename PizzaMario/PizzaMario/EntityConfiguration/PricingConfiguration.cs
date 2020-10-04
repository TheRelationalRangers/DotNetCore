using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaMario.Models;

namespace PizzaMario.EntityConfiguration
{
    public class PricingConfiguration : IEntityTypeConfiguration<Pricing>
    {
        public void Configure(EntityTypeBuilder<Pricing> builder)
        {
            builder.Property(p => p.Tax)
                .HasColumnType("decimal(5,2)");

            builder.Property(o => o.Price)
                .HasColumnType("decimal(5,2)");
        }
    }
}