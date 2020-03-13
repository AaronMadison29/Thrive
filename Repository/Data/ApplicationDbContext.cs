using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        private readonly string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=StudentDatabase;Trusted_Connection=True;MultipleActiveResultSets=true";

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Class>().HasData(
                new Class
                {
                    ClassId = 1,
                    Subject = "Math",
                },

                new Class
                {
                    ClassId = 2,
                    Subject = "Science",
                },

                new Class
                {
                    ClassId = 3,
                    Subject = "History",
                });

            builder.Entity<Teacher>().HasData(
                new Teacher
                {
                    TeacherId = 1,
                    Name = "Mike Terrill",
                    PhoneNumber = "111-111-1111",
                    Subject = "Math",
                    ClassId = 1,
                },

                new Teacher
                {
                    TeacherId = 2,
                    Name = "Nevin Seibel",
                    PhoneNumber = "222-222-2222",
                    Subject = "Science",
                    ClassId = 2
                },

                new Teacher
                {
                    TeacherId = 3,
                    Name = "David Lagrange",
                    PhoneNumber = "555-555-5555",
                    Subject = "History",
                    ClassId = 3
                });
            var profiles = new List<Profile>();
            for (var i = 1; i <= 10; i++)
            {
                profiles.Add(new Profile { ProfileId = i });
            }
            builder.Entity<Profile>().HasData(profiles);


            builder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    Name = "Aaron Madison",
                    ProfileId = 1

                },

                new Student
                {
                    StudentId = 2,
                    Name = "Sean Clennan",
                    ProfileId = 2
                },

                new Student
                {
                    StudentId = 3,
                    Name = "Zac Melton",
                    ProfileId = 3
                },

                new Student
                {
                    StudentId = 4,
                    Name = "Marcus Johnson",
                    ProfileId = 4
                },

                new Student
                {
                    StudentId = 5,
                    Name = "Charlie Sather",
                    ProfileId = 5
                },

                new Student
                {
                    StudentId = 6,
                    Name = "Abraham Sanchez",
                    ProfileId = 6
                },

                new Student
                {
                    StudentId = 7,
                    Name = "Jacob Martinez",
                    ProfileId = 7

                },

                new Student
                {
                    StudentId = 8,
                    Name = "Billy Madison",
                    ProfileId = 8
                },

                new Student
                {
                    StudentId = 9,
                    Name = "Phil Collins",
                    ProfileId = 9
                },

                new Student
                {
                    StudentId = 10,
                    Name = "Parker Vogg",
                    ProfileId = 10
                });

            builder.Entity<Parent>().HasData(
                new Parent
                {
                    ParentId = 1,
                    Name = "Kelly Madison",
                    StudentId = 1
                },

                new Parent
                {
                    ParentId = 2,
                    Name = "Kim Clennan",
                    StudentId = 2
                },

                new Parent
                {
                    ParentId = 3,
                    Name = "Steve Melton",
                    StudentId = 3
                },

                new Parent
                {
                    ParentId = 4,
                    Name = "Bill Johnson",
                    StudentId = 4
                },

                new Parent
                {
                    ParentId = 5,
                    Name = "Jeff Sather",
                    StudentId = 5
                },

                new Parent
                {
                    ParentId = 6,
                    Name = "Amy Sanchez",
                    StudentId = 6
                },

                new Parent
                {
                    ParentId = 7,
                    Name = "Samuel Martinez",
                    StudentId = 7
                },

                new Parent
                {
                    ParentId = 8,
                    Name = "Frank Madison",
                    StudentId = 8
                },

                new Parent
                {
                    ParentId = 9,
                    Name = "Max Collins",
                    StudentId = 9
                },

                new Parent
                {
                    ParentId = 10,
                    Name = "Bob Vogg",
                    StudentId = 10
                });

            var studentClassGrades1 = new List<StudentClassGrade>();
            var studentClassGrades2 = new List<StudentClassGrade>();
            var studentClassGrades3 = new List<StudentClassGrade>();

            var id = 0;
            for (var i = 1; i <= 10; i++)
            {
                studentClassGrades1.Add(new StudentClassGrade { StudentClassGradeId = ++id, StudentId = i, ClassId = 1, Grade = 100 });
                studentClassGrades2.Add(new StudentClassGrade { StudentClassGradeId = ++id, StudentId = i, ClassId = 2, Grade = 100 });
                studentClassGrades3.Add(new StudentClassGrade { StudentClassGradeId = ++id, StudentId = i, ClassId = 3, Grade = 100 });
            }

            builder.Entity<StudentClassGrade>().HasData(studentClassGrades1);
            builder.Entity<StudentClassGrade>().HasData(studentClassGrades2);
            builder.Entity<StudentClassGrade>().HasData(studentClassGrades3);

        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<StudentClassGrade> StudentClassGrades { get; set; }
    }
}
