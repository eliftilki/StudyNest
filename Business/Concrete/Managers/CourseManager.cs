using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Managers
{
    public class CourseManager : ICourseService
    {
        private ICourseDAL _courseDAL;
        public CourseManager(ICourseDAL courseDAL)
        {
            _courseDAL = courseDAL;
        }
        public Course Add(Course course)
        {
            return _courseDAL.Add(course);
        }

        public void Delete(int id)
        {
            var course = _courseDAL.Get(p => p.CourseId == id);
            if (course != null)
            {
                _courseDAL.Delete(course);
            }
        }

        public List<Course> GetAll()
        {
            return _courseDAL.GetList().ToList();
        }

        public Course GetById(int id)
        {
            return _courseDAL.Get(p => p.CourseId == id);
        }

        public List<Course> GetCoursesByCategoryId(short categoryId)
        {
            return _courseDAL.GetList(p => p.CourseCategoryId == categoryId).ToList();
        }

        public Course Update(Course course)
        {
            return _courseDAL.Update(course);
        }
    }
}
