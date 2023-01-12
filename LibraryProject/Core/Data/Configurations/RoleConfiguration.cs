using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(p => p.RoleName).IsRequired().HasMaxLength(50);

            builder.HasIndex(p => p.RoleName).IsUnique();


            builder.HasData(new Role
            {
                ID = -1,
                RoleName = "Administrator"
            });

        }
    }
}
