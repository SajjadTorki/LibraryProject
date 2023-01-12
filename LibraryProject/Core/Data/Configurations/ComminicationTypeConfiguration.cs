using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Configurations
{
    public class CommunicationTypeConfiguration : IEntityTypeConfiguration<CommunicationType>
    {
        public void Configure(EntityTypeBuilder<CommunicationType> builder)
        {
            builder.Property(p => p.CommunicationTypeName).IsRequired().HasMaxLength(50);

            builder.HasIndex(p => p.CommunicationTypeName).IsUnique();

            builder.Property(p => p.ID).ValueGeneratedNever();

          

            List<CommunicationType> communicationTypes = new List<CommunicationType>();
            communicationTypes.Add(new CommunicationType { 
            ID=10,
            CommunicationTypeName="همراه"
            });
            communicationTypes.Add(new CommunicationType
            {
                ID = 20,
                CommunicationTypeName = "تلفن"
            });
            communicationTypes.Add(new CommunicationType
            {
                ID = 30,
                CommunicationTypeName = "پست الکترونیکی"
            });
            communicationTypes.Add(new CommunicationType
            {
                ID = 40,
                CommunicationTypeName = "اینیستاگرام"
            });


            builder.HasData(communicationTypes);
        }
    }
}
