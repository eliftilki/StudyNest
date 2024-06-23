using DataAccess.Concrete.EntityFramework.Mapping;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class StudyNestContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-0LANPAD\SQLEXPRESS; database=StudyNestDB; integrated security=SSPI;TrustServerCertificate=True");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Enrolment> Enrolments { get; set; }
        public DbSet<ChapterCheck> ChapterChecks { get; set; }
        public DbSet<UserWithCourses> UserWithCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new StudentMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CourseMap());
            modelBuilder.ApplyConfiguration(new TeacherMap());
            modelBuilder.ApplyConfiguration(new ChapterMap());
            modelBuilder.ApplyConfiguration(new EnrolmentMap());
            modelBuilder.ApplyConfiguration(new ChapterCheckMap());
            modelBuilder.Entity<UserWithCourses>().HasNoKey();
        }
    }
}
