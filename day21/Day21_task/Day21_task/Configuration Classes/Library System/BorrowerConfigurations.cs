using Day21_task.Models.Library_System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_task.Configuration_Classes.Library_System
{
    internal class BorrowerConfigurations : IEntityTypeConfiguration<Borrower>
    {
        public void Configure(EntityTypeBuilder<Borrower> builder)
        {
            builder.ToTable("Borrowers", schema: "Library");

            builder.HasKey(br => br.Id);

            builder.Property(br => br.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(br => br.MembershipDate)
                   .IsRequired();
        }
    }
}
