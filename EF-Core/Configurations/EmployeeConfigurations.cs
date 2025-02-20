using EF_Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> builder)
        {
            builder.HasKey(e => e.EmpId);

            builder.Property(e => e.Name)
                                           .IsRequired()
                                           .HasColumnType("Varchar")
                                           .HasMaxLength(50)
            .HasColumnName("EmpName");

            builder.Property(e => e.Age).IsRequired(false);
            builder.Property(e => e.Salary).HasColumnType("money");
            builder.Property(e => e.DateOfCreation).HasDefaultValueSql("GetDate()");

        }
    }
}
