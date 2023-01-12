using Core.Data.Configurations;
using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Data
{
    public class LibraryContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer("Data Source=SAJJAD\\SQL2019;Initial Catalog=LibratoryDB;Integrated Security=true;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
     
        
            //modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            //modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            //modelBuilder.ApplyConfiguration(new BookConfiguration());
            //modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            //modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            //modelBuilder.ApplyConfiguration(new SubjectConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookConfiguration).Assembly);
                
            modelBuilder.Ignore<BaseEntity>();
        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<CommunicationType> CommunicationTypes { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Proof> Proofs { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<FormBorrow> FormBorrows { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }


        public DbSet<Activity> Activities { get; set; }

    }
}
