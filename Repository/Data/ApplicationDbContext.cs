using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Class>().HasData(
                new Class
                {
                    Subject = "Math",
                    TeacherId = 1
                },

                new Class
                {
                    Subject = "Science",
                    TeacherId = 2
                },

                new Class
                {
                    Subject = "History",
                    TeacherId = 3,
                }
                );

            builder.Entity<Teacher>().HasData(
                new Teacher
                {
                    Name = "Mike Terrill",
                    PhoneNumber = "111-111-1111",
                    Subject = "Math",
                },

                new Teacher
                {
                    Name = "Nevin Seibel",
                    PhoneNumber = "222-222-2222",
                    Subject = "Science"
                },

                new Teacher
                {
                    Name = "David Lagrange",
                    PhoneNumber = "555-555-5555",
                    Subject = "History"
                });


            builder.Entity<Student>().HasData(
                new Student
                {
                    Name = "Aaron Madison",
                    ParentId = 1
                },

                new Student
                {
                    Name = "Sean Clennan",
                    ParentId = 2
                },

                new Student
                {
                    Name = "Zac Melton",
                    ParentId = 3
                },

                new Student
                {
                    Name = "Marcus Johnson",
                    ParentId = 4
                },

                new Student
                {
                    Name = "Charlie Sather",
                    ParentId = 5
                },

                new Student
                {
                    Name = "Abraham Sanchez",
                    ParentId = 6

                },

                new Student
                {
                    Name = "Jacob Martinez",
                    ParentId = 7
                },

                new Student
                {
                    Name = "Billy Madison",
                    ParentId = 8
                },

                new Student
                {
                    Name = "Phil Collins",
                    ParentId = 9
                },

                new Student
                {
                    Name = "Parker Vogg",
                    ParentId = 10
                });

            builder.Entity<Parent>().HasData(
                new Parent
                {
                    Name = "Kelly Madison",
                },

                new Parent
                {
                    Name = "Kim Clennan"
                },

                new Parent
                {
                    Name = "Steve Melton"
                },

                new Parent
                {
                    Name = "Bill Johnson"
                },

                new Parent
                {
                    Name = "Jeff Sather"
                },

                new Parent
                {
                    Name = "Amy Sanchez"
                },

                new Parent
                {
                    Name = "Samuel Martinez"
                },

                new Parent
                {
                    Name = "Frank Madison"
                },

                new Parent
                {
                    Name = "Max Collins"
                },

                new Parent
                {
                    Name = "Bob Vogg"
                }

                );
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<StudentClassGrade> StudentClassGrades { get; set; }
    }
}
