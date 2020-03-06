using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ThriveAPP.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Name = "Teacher",
                NormalizedName = "TEACHER"
            },

            new IdentityRole
            {
                Name = "Parent",
                NormalizedName = "PARENT"
            },

            new IdentityRole
            {
                Name = "Student",
                NormalizedName = "STUDENT"
            });
        }
    }
}
