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
    public class ChapterMap : IEntityTypeConfiguration<Chapter>
    {
        public void Configure(EntityTypeBuilder<Chapter> builder)
        {
            builder.ToTable("Chapters"); // Veritabanındaki tablo adı

            // Özellik eşlemeleri
            builder.Property(u => u.ChapterId).HasColumnName("Id");
            builder.Property(u => u.Name).HasColumnName("Name");
            builder.Property(u => u.Time).HasColumnName("Time");
            builder.Property(u => u.ChapterCorseId).HasColumnName("CourseId");
            builder.Property(u => u.Url).HasColumnName("Url");
        }
    }
}
