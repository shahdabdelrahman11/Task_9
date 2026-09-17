using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_StudentSystem.Data
{
    internal class StudentSystemContext : DbContext
    {

        public DbSet<Student> Students {  get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<HomeworkSubmission> HomeworkSubmissions { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
       
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-7D13UVG2;Initial Catalog=StudentSystem;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;Packet Size=4096;Command Timeout=0");
        

    }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc=> new {sc.CourseId, sc.StudentId});
            modelBuilder.Entity<Student>()
                 .Property(s => s.Name)
                 .IsRequired()
                 .HasMaxLength(100)
                 .IsUnicode(true);
            modelBuilder.Entity<Student>()
                .Property(s => s.PhoneNumber)
                .HasMaxLength(10)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired(false);

            modelBuilder.Entity<Course>()
                .Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(true);

            modelBuilder.Entity<Course>()
                .Property(c=> c.Description)
                .IsRequired(false)
                .IsUnicode (true);

            modelBuilder.Entity<Resource>()
                .Property(r=> r.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(true);

            modelBuilder.Entity<Resource>()
                 .Property(r => r.Url)
                 .IsRequired()
                 .IsUnicode(false);


            modelBuilder.Entity<HomeworkSubmission>()
                
                .Property(h => h.Content)
                .IsRequired()
                .IsUnicode(false);
                
        }
    }
}
