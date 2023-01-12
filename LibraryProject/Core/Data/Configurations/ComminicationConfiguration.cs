using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Configurations
{
    public class CommunicationConfiguration : IEntityTypeConfiguration<Communication>
    {
        public void Configure(EntityTypeBuilder<Communication> builder)
        {
            builder.Property(p => p.Value).IsRequired().HasMaxLength(50);
          

        }
    }
}
