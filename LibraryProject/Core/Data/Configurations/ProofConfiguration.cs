using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Configurations
{
    public class ProofConfiguration : IEntityTypeConfiguration<Proof>
    {
        public void Configure(EntityTypeBuilder<Proof> builder)
        {
            builder.Property(p => p.ProofName).IsRequired().HasMaxLength(50);

            builder.HasIndex(p => p.ProofName).IsUnique();

            builder.HasMany(p => p.Members).WithOne(p => p.Proof)
                .HasForeignKey(p => p.ProofID).OnDelete(DeleteBehavior.NoAction);

            builder.Property(p => p.ID).ValueGeneratedNever();

            var _list = new List<Proof>();
            _list.Add(new Proof
            {
                ID = -1,
                ProofName = ""
            });

            _list.Add(new Proof
            {
                ID = 10,
                ProofName = "زیر دیپلم"
            });

            _list.Add(new Proof
            {
                ID = 20,
                ProofName = "دیپلم"
            });
            _list.Add(new Proof
            {
                ID = 30,
                ProofName = "کاردانی"
            });
            _list.Add(new Proof
            {
                ID = 40,
                ProofName = "کارشناسی"
            });
            _list.Add(new Proof
            {
                ID = 50,
                ProofName = "کارشناسی ارشد"
            });
            _list.Add(new Proof
            {
                ID = 60,
                ProofName = "دکتری"
            });


            builder.HasData(_list);

        }
    }
}
