using Day20_task.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_task.Configuration_Classes
{
    internal class ProjectConfigurations : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> P)
        {
            P.HasKey(p => p.Id);
            P.Property(p => p.Id)
                .UseIdentityColumn(10, 10);

            P.Property(p => p.Name)
                .IsRequired(true)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .HasDefaultValue("OurProject");

            P.Property(p => p.Cost)
                .HasColumnType("money");

            P.HasCheckConstraint("CK_Project_Cost", "Cost BETWEEN 500000 AND 3500000");
        }
    }
}
