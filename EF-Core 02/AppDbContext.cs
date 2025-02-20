using EF_Core_02.Configurations;
using EF_Core_02.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_02
{
    internal class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new EmployeeConfigurations());

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Employee>().HasOne(E => E.DeptId)
                                           .WithOne(D => D.Manager)
                                           .HasForeignKey<Department>(D => D.EmpId);


            modelBuilder.Entity<Department>().HasMany(D=>D.Employees)
                                           .WithOne(E=>E.WorkFor)
                                           .HasForeignKey(E=>E.WorkForId);


            modelBuilder.Entity<CourseStudent>().HasKey(D =>new {D.StudentId,D.CourseId});
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-IL19IGJ\\SQL2022 ; Database = App02G03 ; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }


        public DbSet<Student> Students { get; set; }



        public DbSet<Course> Courses { get; set; }
    }
}
