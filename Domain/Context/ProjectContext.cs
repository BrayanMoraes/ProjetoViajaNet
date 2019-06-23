using Domain.Entities;
using Domain.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemMapping());
            modelBuilder.ApplyConfiguration(new BrowserInformationMapping());
            modelBuilder.ApplyConfiguration(new ItemTypeMapping());
        }

        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<BrowserInformation> BrowserInformation { get; set; }
    }
}
