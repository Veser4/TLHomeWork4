using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProvider.Configurations
{
    public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
    {
        public void Configure(EntityTypeBuilder<Feature> builder)
        {
            builder.ToTable("Feature").HasKey(c => c.FeatureId);
            builder.Property(c => c.FeatureId).HasColumnName("FeatureId").IsRequired();
            builder.Property(c => c.Intelligence).HasColumnName("Intelligence").HasMaxLength(50).IsRequired();
            builder.Property(c => c.Agility).HasColumnName("Agility").HasMaxLength(50).IsRequired();
            builder.Property(c => c.Strength).HasColumnName("Strength").HasMaxLength(50).IsRequired();
        }
    }
}
