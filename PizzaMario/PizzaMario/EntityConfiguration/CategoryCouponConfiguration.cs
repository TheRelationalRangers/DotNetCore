using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaMario.Models;

namespace PizzaMario.EntityConfiguration
{
    public class CategoryCouponConfiguration : IEntityTypeConfiguration<CategoryCoupon>
    {
        public void Configure(EntityTypeBuilder<CategoryCoupon> builder)
        {
            builder.Property(cc => cc.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(cc => cc.Code)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(cc => cc.Description)
                .HasColumnType("nvarchar(max)")
                .IsRequired();

            builder.Property(cc => cc.DiscountValue)
                .HasColumnType("decimal(5,2)");

            builder.Property(cc => cc.StartDate)
                .IsRequired();

            builder.Property(cc => cc.EndDate)
                .IsRequired();
        }
    }
}