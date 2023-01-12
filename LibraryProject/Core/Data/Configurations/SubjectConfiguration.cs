using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Configurations
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.Property(p => p.SubjectName).IsRequired().HasMaxLength(50);

            builder.HasIndex(p => p.SubjectName).IsUnique();

            builder.HasMany(p => p.Books).WithOne(p => p.Subject)
                .HasForeignKey(p => p.SubjectId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
