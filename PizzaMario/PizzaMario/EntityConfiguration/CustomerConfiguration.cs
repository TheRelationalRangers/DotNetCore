using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaMario.Models;

namespace PizzaMario.EntityConfiguration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // Property Configuration
            builder.Property(c => c.Id)
                .IsRequired();

            builder.Property(c => c.Name)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(c => c.Addition)
                .HasMaxLength(10);

            builder.Property(c => c.LastName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(c => c.PhoneNumber)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(c => c.Mail)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Password)
                .HasMaxLength(25);
        }
    }
}