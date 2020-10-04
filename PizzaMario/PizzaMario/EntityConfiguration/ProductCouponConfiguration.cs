using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaMario.Models;

namespace PizzaMario.EntityConfiguration
{
    public class ProductCouponConfiguration : IEntityTypeConfiguration<ProductCoupon>
    {
        public void Configure(EntityTypeBuilder<ProductCoupon> builder)
        {
            builder.Property(pc => pc.DiscountValue)
                .HasColumnType("decimal(5,2)");
        }
    }
}