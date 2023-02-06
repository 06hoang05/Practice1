using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DatabaseContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Exam> Exams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    Name = "Hoang",
                    DateOfBirth = new DateTime(2003, 6, 5),
                    Email = "hoang@gmail.com",
                    Address = "12 hanoi"
                },
                new Student
                {
                    StudentId = 2,
                    Name = "Anh",
                    DateOfBirth = new DateTime(2003, 2, 1),
                    Email = "anh@gmail.com",
                    Address = "32 hanoi"
                },
                new Student
                {
                    StudentId = 3,
                    Name = "Minh",
                    DateOfBirth = new DateTime(2003, 3, 7),
                    Email = "minh@gmail.com",
                    Address = "29 hanoi"
                }
            );

            modelBuilder.Entity<Subject>().HasData(
                new Subject
                {
                    SubjectId = 1,
                    SubjectName = "toan",
                    SubjectCode = "T101",
                    Description = "Nhap mon Toan",
                    StartDate = new DateTime(2023, 1, 1),
                    EndDate = new DateTime(2023, 12, 31)
                },
                new Subject
                {
                    SubjectId = 2,
                    SubjectName = "van",
                    SubjectCode = "V101",
                    Description = "Nhap mon van",
                    StartDate = new DateTime(2023, 1, 1),
                    EndDate = new DateTime(2023, 12, 31)
                },
                new Subject
                {
                    SubjectId = 3,
                    SubjectName = "Anh",
                    SubjectCode = "A101",
                    Description = "Nhap mon Anh",
                    StartDate = new DateTime(2023, 1, 1),
                    EndDate = new DateTime(2023, 12, 31)
                }
            );
        }
    }
}

