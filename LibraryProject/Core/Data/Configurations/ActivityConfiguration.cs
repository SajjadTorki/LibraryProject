using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data.Configurations
{
    public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.Property(p => p.ActivityDescription).IsRequired();

            builder.HasIndex(p => p.ActivityName).IsUnique();

            builder.Property(p => p.ID).ValueGeneratedNever();

            List<Activity> activities = new List<Activity>();

            activities.Add(new Activity
            {
                ID=1,
                ActivityName = UserActivity.InformationManagment,
                ActivityDescription = "دسترسی به منوی مدیریت اطلاعات"
            });
            activities.Add(new Activity
            {
                ID = 2,
                ActivityName = UserActivity.BorrowManagment,
                ActivityDescription = "دسترسی به منوی مدیریت امانت"
            });
            activities.Add(new Activity
            {
                ID=3,
                ActivityName = UserActivity.ReportManagment,
                ActivityDescription = "دسترسی به منوی گزارش گیری"
            });
            activities.Add(new Activity
            {
                ID=4,
                ActivityName = UserActivity.SoftwareMangament,
                ActivityDescription = "دسترسی به منوی مدیریت نرم افزار "
            });
            activities.Add(new Activity
            {
                ID=5,
                ActivityName = UserActivity.SecurityManagment,
                ActivityDescription = "دسترسی به منوی مدیریت امنیت"
            });


            builder.HasData(activities);
        }
    }
}
