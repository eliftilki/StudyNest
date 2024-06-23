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
    public class EnrolmentMap : IEntityTypeConfiguration<Enrolment>
    {
        public void Configure(EntityTypeBuilder<Enrolment> builder)
        {
            builder.ToTable("Enrolment"); // Veritabanındaki tablo adı

            // Özellik eşlemeleri
            builder.Property(u => u.EnrolmentId).HasColumnName("Id");
            builder.Property(u => u.EnrolmentStudentId).HasColumnName("StudentId");
            builder.Property(u => u.EnrolmentCourseId).HasColumnName("CourseId");
            builder.Property(u => u.EnrolmentTime).HasColumnName("CompletedDateTime");
           
        }
    }
}
