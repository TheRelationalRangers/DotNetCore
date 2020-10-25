using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaMario.Models;

namespace PizzaMario.EntityConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Property Configuration
            builder.Property(p => p.Id)
                .IsRequired();

            builder.Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasColumnType("nvarchar(max)")
                .IsRequired();

            builder.HasMany(p => p.ProductIngredients)
                .WithOne(p => p.Product);

            builder.HasOne(p => p.Pricing);

            builder.HasOne(p => p.Category);

            builder.HasOne(p => p.SubCategory);

            builder.HasOne(p => p.Crust);

            builder.Property(p => p.IsAvailable)
                .IsRequired();
        }
    }
}