using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Mapping
{
    public class ItemMapping : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Quantity).IsRequired();
            builder.HasOne(c => c.ItemType).WithMany(c => c.Items).HasForeignKey(c => c.ItemTypeId);
            builder.HasMany(c => c.BrowserInformations).WithOne(c => c.Item).HasForeignKey(c => c.ItemId);
        }
    }
}
