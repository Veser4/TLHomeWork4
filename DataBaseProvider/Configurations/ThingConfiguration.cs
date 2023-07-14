using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProvider.Configurations
{
    public class ThingConfiguration : IEntityTypeConfiguration<Thing>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Thing> builder)
        {
            builder.ToTable("Thing").HasKey(m => m.ThingId);
            builder.Property(m => m.ThingId).HasColumnName("ThingId").IsRequired();
            builder.Property(m => m.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();

            builder.HasOne(m => m.Hero).WithOne(n => n.Thing).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
