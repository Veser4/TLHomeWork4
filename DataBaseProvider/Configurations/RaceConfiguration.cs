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
    public class RaceConfiguration : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            builder.ToTable("Race").HasKey(b => b.RaceId);
            builder.Property(b => b.RaceId).HasColumnName("RaceId").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
        }
    }
}
