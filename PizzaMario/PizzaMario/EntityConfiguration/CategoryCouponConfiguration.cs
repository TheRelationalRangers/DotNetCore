using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaMario.Models;

namespace PizzaMario.EntityConfiguration
{
    public class CategoryCouponConfiguration : IEntityTypeConfiguration<CategoryCoupon>
    {
        public void Configure(EntityTypeBuilder<CategoryCoupon> builder)
        {
            builder.Property(cc => cc.DiscountValue)
                .HasColumnType("decimal(5,2)");
        }
    }
}