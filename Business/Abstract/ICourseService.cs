using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        List<Course> GetAll();
        Course Add(Course course);
        Course Update(Course course);
        Course GetById(int id);
        void Delete(int id);
        List<Course> GetCoursesByCategoryId(short categoryId);
    }
}
