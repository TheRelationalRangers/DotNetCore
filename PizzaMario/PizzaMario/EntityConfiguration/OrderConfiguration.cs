using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaMario.Models;

namespace PizzaMario.EntityConfiguration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            // Property Configuration
            builder.Property(o => o.StoreNumber)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(o => o.CustomerName)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(o => o.CustomerZipcode)
                .HasMaxLength(6)
                .IsRequired();

            builder.Property(o => o.CustomerHouseNumber)
                .HasMaxLength(6)
                .IsRequired();

            builder.Property(o => o.OrderDate)
                .IsRequired();

            builder.Property(o => o.Tax)
                .HasColumnType("decimal(5,2)")
                .IsRequired();

            builder.Property(o => o.TotalPrice)
                .HasColumnType("decimal(6,2)")
                .IsRequired();

            builder.Property(o => o.Comment)
                .HasColumnType("nvarchar(max)")
                .IsRequired();
        }
    }
}