using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaMario.Models;

namespace PizzaMario.EntityConfiguration
{
    public class ProductCouponConfiguration : IEntityTypeConfiguration<ProductCoupon>
    {
        public void Configure(EntityTypeBuilder<ProductCoupon> builder)
        {
            builder.Property(pc => pc.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(pc => pc.Code)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(pc => pc.Description)
                .HasColumnType("nvarchar(max)")
                .IsRequired();

            builder.Property(pc => pc.DiscountValue)
                .HasColumnType("decimal(5,2)");

            builder.Property(pc => pc.StartDate)
                .IsRequired();

            builder.Property(pc => pc.EndDate)
                .IsRequired();
        }
    }
}