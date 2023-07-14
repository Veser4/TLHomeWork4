using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProvider.Configurations
{
    public class HeroConfiguration : IEntityTypeConfiguration<Hero>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Hero> builder)
        {
            builder.ToTable("Hero").HasKey(d => d.HeroId);
            builder.Property(d => d.HeroId).HasColumnName("HeroId").IsRequired();
            builder.Property(d => d.FirstName).HasColumnName("FirstName").HasMaxLength(50).IsRequired();
            builder.Property(d => d.LastName).HasColumnName("LastName").HasMaxLength(50).IsRequired();

            builder.HasOne(d => d.Class).WithMany( k => k.Heroes).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(d => d.Race).WithMany(k => k.Heroes).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(d => d.Feature).WithOne(k => k.Hero).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
