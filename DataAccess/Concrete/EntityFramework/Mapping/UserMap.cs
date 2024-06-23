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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users"); // Veritabanındaki tablo adı

            // Özellik eşlemeleri
            builder.Property(u => u.UserId).HasColumnName("Id"); 
            builder.Property(u => u.Name).HasColumnName("Name");
            builder.Property(u => u.Email).HasColumnName("Email");
            builder.Property(u => u.Password).HasColumnName("Password");
            builder.Property(u => u.Autho).HasColumnName("Autho");
        }
    }
}
