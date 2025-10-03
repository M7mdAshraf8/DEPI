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
    internal class LoanConfigurations : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.ToTable("Loans", schema: "Library");

            builder.HasKey(l => new { l.BookId, l.BorrowerId, l.LoanDate });

            builder.Property(l => l.LoanDate)
                   .IsRequired();

            builder.HasOne(l => l.Book)
                   .WithMany(b => b.Loans)
                   .HasForeignKey(l => l.BookId);

            builder.HasOne(l => l.Borrower)
                   .WithMany(br => br.Loans)
                   .HasForeignKey(l => l.BorrowerId);
        }
    }
}
