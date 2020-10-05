using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaMario.Models;

namespace PizzaMario.EntityConfiguration
{
    public class TownshipConfiguration : IEntityTypeConfiguration<Township>
    {
        public void Configure(EntityTypeBuilder<Township> builder)
        {
            // Relation Configuration
            builder.Property(t => t.Code)
                .IsRequired();

            builder.Property(t => t.Name)
                .IsRequired();
        }
    }
}