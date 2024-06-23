using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student Add(Student student);
        Student Update(Student student);
        Student GetById(int id);
        void Delete(int id);
    }
}
