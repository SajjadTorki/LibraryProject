﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Configurations
{
    public class PersonPictureConfiguration : IEntityTypeConfiguration<PersonPicture>
    {
        public void Configure(EntityTypeBuilder<PersonPicture> builder)
        {
         
        }
    }
}
