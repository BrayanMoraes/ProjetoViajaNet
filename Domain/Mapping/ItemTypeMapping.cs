using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Mapping
{
    public class ItemTypeMapping : IEntityTypeConfiguration<ItemType>
    {
        public void Configure(EntityTypeBuilder<ItemType> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Description).HasMaxLength(50).IsRequired();
            builder.HasMany(c => c.Items).WithOne(c => c.ItemType).HasForeignKey(c => c.ItemTypeId);
        }
    }
}
