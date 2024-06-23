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
    public class TeacherMap : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teacher"); // Veritabanındaki tablo adı

            // Özellik eşlemeleri
            builder.Property(u => u.TeacherId).HasColumnName("Id");
            builder.Property(u => u.TeacherUserId).HasColumnName("UserId");
        }
    }
}
