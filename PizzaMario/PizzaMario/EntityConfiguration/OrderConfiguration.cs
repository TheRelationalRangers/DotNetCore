﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaMario.Models;

namespace PizzaMario.EntityConfiguration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(o => o.Tax)
                .HasColumnType("decimal(5,2)");

            builder.Property(o => o.TotalPrice)
                .HasColumnType("decimal(6,2)");
        }
    }
}