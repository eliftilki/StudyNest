using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Managers
{
    public class UserWithCoursesManager : IUserWithCoursesService
    {
        private readonly IUserWithCoursesDAL _userWithCoursesDAL;
        private readonly StudyNestContext _context;

        public UserWithCoursesManager(IUserWithCoursesDAL userWithCoursesDAL, StudyNestContext context)
        {
            _userWithCoursesDAL = userWithCoursesDAL;
            _context = context;
        }

        public async Task<UserWithCourses> GetUserWithCoursesByEmailAsync(string email) // Ensure return type is Task<UserWithCourses>
        {
            var userWithCourses = await _context.Users
                .Where(u => u.Email == email)
                .Join(_context.Students, // Students ile join yaparak User'ın öğrenci bilgilerini alalım
                      user => user.UserId, // User tablosundaki UserId alanı ile
                      student => student.StudentUserId, // Student tablosundaki StudentUserId alanı eşleşen kayıtları alalım
                      (user, student) => new { User = user, Student = student }) // Her iki tablodan da verileri alalım
                .Join(_context.Enrolments, // Enrolments ile join yaparak öğrencinin kayıtlı olduğu kursları alalım
                      joined => joined.Student.StudentId, // İlk join'dan gelen StudentId ile
                      enrolment => enrolment.EnrolmentStudentId, // Enrolment tablosundaki EnrolmentStudentId alanı eşleşen kayıtları alalım
                      (joined, enrolment) => new { User = joined.User, Enrolment = enrolment }) // Her iki tablodan da verileri alalım
                .Join(_context.Courses, // Courses ile join yaparak kurs bilgilerini alalım
                      joined => joined.Enrolment.EnrolmentCourseId, // İkinci join'dan gelen CourseId ile
                      course => course.CourseId, // Course tablosundaki CourseId alanı eşleşen kayıtları alalım
                      (joined, course) => new UserWithCourses // Sonucu uygun modele dönüştürelim
                      {
                          UserId = joined.User.UserId,
                          Name = joined.User.Name,
                          Email = joined.User.Email,
                          Password = joined.User.Password,
                          Autho = joined.User.Autho,
                          Courses = new List<Course> { course }
                      })
                .FirstOrDefaultAsync();

            return userWithCourses;
        }
    }
}