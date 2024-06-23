using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student"); // Veritabanındaki tablo adı

            // Özellik eşlemeleri
            builder.Property(u => u.StudentId).HasColumnName("Id");
            builder.Property(u => u.StudentUserId).HasColumnName("UserId");
            
        }
    }
}
