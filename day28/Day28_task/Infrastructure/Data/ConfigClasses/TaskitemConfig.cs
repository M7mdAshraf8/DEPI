using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.ConfigClasses
{
    internal class TaskitemConfig : IEntityTypeConfiguration<Taskitem>
    {
        public void Configure(EntityTypeBuilder<Taskitem> builder)
        {
            builder.Property(t => t.Title)
                .HasMaxLength(100);
            builder.Property(t => t.Description)
                .HasMaxLength(500);
            builder.Property(t => t.CreatedAt)
                .HasDefaultValueSql("getDate()");
        }
    }
}
