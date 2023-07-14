using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProvider.Configurations
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("Class").HasKey(a => a.ClassId);
            builder.Property(a => a.ClassId).HasColumnName("ClassId").IsRequired();
            builder.Property(a => a.Name).HasColumnName("Name").HasMaxLength(50).IsRequired();
        }
    }
}
