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
    public class CourseMap : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses"); // Veritabanındaki tablo adı

            // Özellik eşlemeleri
            builder.Property(u => u.CourseId).HasColumnName("Id");
            builder.Property(u => u.Name).HasColumnName("Name");
            builder.Property(u => u.CourseCategoryId).HasColumnName("CategoryId");
            builder.Property(u => u.Information).HasColumnName("Information");
            builder.Property(u => u.Photo).HasColumnName("Photo");
            builder.Property(u => u.CourseTeacherId).HasColumnName("TeacherId");
            builder.Property(u => u.Price).HasColumnName("Price");
            
        }
    }
}
