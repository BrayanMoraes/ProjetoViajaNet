using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Mapping
{
    public class BrowserInformationMapping : IEntityTypeConfiguration<BrowserInformation>
    {
        public void Configure(EntityTypeBuilder<BrowserInformation> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.BrowserName).HasMaxLength(50).IsRequired();
            builder.Property(c => c.IPAdress).HasMaxLength(15).IsRequired();
            builder.Property(c => c.PageName).HasMaxLength(50).IsRequired();
            builder.HasOne(c => c.Item).WithMany(c => c.BrowserInformations).HasForeignKey(c => c.ItemId);
        }
    }
}
