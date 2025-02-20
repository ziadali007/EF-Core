using EF_Core_Assigment01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assigment01.Configurations
{
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(I => I.Id);

            builder.Property(I => I.Name)
                   .IsRequired()
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(I=>I.HourRate).HasMaxLength(50);

            builder.Property(I=>I.Address).HasMaxLength(50);

            builder.Property(I=>I.Bouns).IsRequired(false);

            builder.Property(I => I.Dept_Id).IsRequired();

        }
    }
}
