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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories"); // Veritabanındaki tablo adı

            // Özellik eşlemeleri
            builder.Property(u => u.CategoryId).HasColumnName("Id");
            builder.Property(u => u.Name).HasColumnName("Name");
            builder.Property(u => u.Photo).HasColumnName("Photo");
           
        }
    }
}
