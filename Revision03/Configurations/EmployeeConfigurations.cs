using EF_Core_02.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_02.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
             
            builder.HasKey(e => e.EmpId);

            builder.Property(e => e.Name)
                                           .IsRequired()
                                           .HasColumnType("Varchar")
                                           .HasMaxLength(50)
            .HasColumnName("EmpName");

            builder.Property(e => e.Age).IsRequired(false);
            builder.Property(e => e.Salary).HasColumnType("money");
            builder.Property(e => e.HiringDate).HasDefaultValueSql("GetDate()");
            builder.HasOne(E => E.WorkFor)
                   .WithMany(D => D.Employees)
                   .HasForeignKey(E => E.DeptId);
        }
    
    }
}
