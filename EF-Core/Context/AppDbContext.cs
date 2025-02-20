using EF_Core.Configurations;
using EF_Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Context
{
    internal class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfigurations());
            base.OnModelCreating(modelBuilder);
            #region Configurations
            //modelBuilder.Entity<Employees>().HasKey(e => e.EmpId);

            //modelBuilder.Entity<Employees>().Property(e => e.Name)
            //                               .IsRequired()
            //                               .HasColumnType("Varchar")
            //                               .HasMaxLength(50)
            //                               .HasColumnName("EmpName");

            //modelBuilder.Entity<Employees>().Property(e => e.Age).IsRequired(false);

            //modelBuilder.Entity<Employees>().Property(e => e.Salary).HasColumnType("money");

            //modelBuilder.Entity<Employees>().Property(e => e.DateOfCreation).HasDefaultValueSql("GetDate()");

            //base.OnModelCreating(modelBuilder); 
            #endregion
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-IL19IGJ\\SQL2022 ; Database = AppG03 ; Trusted_Connection = True; TrustServerCertificate = True");
        }

        //public DbSet<Employee> Employees { get; set; }
    }
}
