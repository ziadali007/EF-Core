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
    internal class DepartmentConfigrations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D=>D.Id);
            builder.Property(D => D.Id).UseIdentityColumn(100, 100);

            builder.Property(D=>D.DeptName).HasColumnName("DeptName")
                                                    .HasColumnType("varchar")
                                                    .HasMaxLength(100);
                                              
        }
    }
}
