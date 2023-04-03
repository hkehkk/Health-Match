using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace HealthMatch.Models
{
    public class DomainContext : DbContext
    {
       
        public DbSet<Clinic> Clinics { get; set; }
        
        public DbSet<User> Users { get; set; }



        public DomainContext(DbContextOptions<DomainContext> options) : base(options)
        {

        }

        public DomainContext(DbSet<Clinic> clinics, DbSet<User> users)
        {
            Clinics = clinics;
            Users = users;
        }

        public DomainContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clinic>().HasData(new Clinic
            {
                ClinicId = 1,
                ClinicName = "Access Care Clinic",
                Address = "1234 Boom dr.",
                City = "Los Angeles",
                State = "California",
                Zipcode = "99999",
                Phone = "555-222-5856",
                IsUrgentOffered = "Not Urgent"
            });

            modelBuilder.Entity<Clinic>().HasData(new Clinic
            {
                ClinicId = 2,
                ClinicName = "Practical Health Care",
                Address = "678 Snooze Dr.",
                City = "Los Angeles",
                State = "California",
                Zipcode = "99999",
                Phone = "555-999-2376",
                IsUrgentOffered = "Not Urgent"
            });

            modelBuilder.Entity<Clinic>().HasData(new Clinic
            {
                ClinicId = 3,
                ClinicName = "Parma Clinic",
                Address = "222 Feel Better Ln",
                City = "Los Angeles",
                State = "California",
                Zipcode = "99998",
                Phone = "555-222-989",
                IsUrgentOffered = "Not Urgent "
            });

            modelBuilder.Entity<Clinic>().HasData(new Clinic
            {
                ClinicId = 4,
                ClinicName = "Med Express",
                Address = "14 W Michigan St.",
                City = "Los Angeles",
                State = "California",
                Zipcode = "99999",
                Phone = "555-888-1111",
                IsUrgentOffered = "Urgent"
            });

            modelBuilder.Entity<Clinic>().HasData(new Clinic
            {
                ClinicId = 5,
                ClinicName = "Rapid Cure Clinic",
                Address = "25 N Michaels Dr.",
                City = "Los Angeles",
                State = "California",
                Zipcode = "99999",
                Phone = "555-888-4545",
                IsUrgentOffered = "Urgent"
            });

            modelBuilder.Entity<Clinic>().HasData(new Clinic
            {
                ClinicId = 6,
                ClinicName = "Midland Health Clinic",
                Address = "177 Merryberry St.",
                City = "Los Angeles",
                State = "California",
                Zipcode = "99998",
                Phone = "555-656-2159",
                IsUrgentOffered = "Urgent"
            });
        }
    }


}
