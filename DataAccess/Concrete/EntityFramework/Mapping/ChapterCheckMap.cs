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
    public class ChapterCheckMap : IEntityTypeConfiguration<ChapterCheck>
    {
        public void Configure(EntityTypeBuilder<ChapterCheck> builder)
        {
            builder.ToTable("ChapterControl"); // Veritabanındaki tablo adı

            // Özellik eşlemeleri
            builder.Property(u => u.ChapterCheckId).HasColumnName("Id");
            builder.Property(u => u.ChapterCheckChapterId).HasColumnName("ChapterId");
            builder.Property(u => u.ChapterCheckStudentId).HasColumnName("StudentId");
            builder.Property(u => u.ChapterCheckControl).HasColumnName("Control");

        }
    }
}
