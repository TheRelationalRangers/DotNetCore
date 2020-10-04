using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaMario.Models;

namespace PizzaMario.EntityConfiguration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            // Property Configuration
            builder.Property(a => a.Id)
                .IsRequired();

            builder.Property(a => a.Street)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(a => a.HouseNumber)
                .HasMaxLength(4)
                .IsRequired();

            builder.Property(a => a.Addition)
                .HasMaxLength(10);

            builder.Property(a => a.ZipCode)
                .HasMaxLength(6)
                .IsRequired();

            builder.Property(a => a.City)
                .HasMaxLength(85)
                .IsRequired();
        }
    }
}