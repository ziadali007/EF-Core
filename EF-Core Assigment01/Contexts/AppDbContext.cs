using EF_Core_Assigment01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assigment01.Contexts
{
    internal class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<CourseInstructor>().HasKey(E=> new {E.Crs_Id,E.Ins_Id});
            modelBuilder.Entity<CourseStudent>().HasKey(C=> new {C.Stud_Id,C.Crs_Id});
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server = DESKTOP-IL19IGJ\\SQL2022 ; Database = EF-Assigment01 ; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<CourseStudent> CourseStudents { get; set; }

        public DbSet<CourseInstructor> CourseInstructors { get; set; }

    }
}
