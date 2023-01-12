using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Configurations
{
    public class MajorConfiguration : IEntityTypeConfiguration<Major>
    {
        public void Configure(EntityTypeBuilder<Major> builder)
        {
            builder.Property(p => p.MajorName).IsRequired().HasMaxLength(50);

            builder.HasIndex(p => p.MajorName).IsUnique();

            builder.HasMany(p => p.Members).WithOne(p => p.Major)
                .HasForeignKey(p => p.MajorID).OnDelete(DeleteBehavior.NoAction);


            builder.HasData(new Major { 
            ID=-1,
            MajorName=""
            });
        }
    }
}
