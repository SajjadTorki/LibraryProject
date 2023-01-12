using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(p => p.BookName).IsRequired().HasMaxLength(50);
            builder.HasIndex(p => p.BookName).IsUnique();
            builder.Property(p => p.Stamp).IsRowVersion();

            builder.HasMany(p => p.FormBorrows).WithOne(p => p.Book)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
