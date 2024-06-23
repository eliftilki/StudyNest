using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
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
    public class StudentManager : IStudentService
    {
        private IStudentDAL _studentDAL;
        public StudentManager(IStudentDAL studentDAL)
        {
            _studentDAL = studentDAL;
        }
        public Student Add(Student student)
        {
            return _studentDAL.Add(student);
        }

        public void Delete(int id)
        {
            var student = _studentDAL.Get(p => p.StudentId == id);
            if (student != null)
            {
                _studentDAL.Delete(student);
            }
        }

        public List<Student> GetAll()
        {
            return _studentDAL.GetList().ToList();
        }

        public Student GetById(int id)
        {
            return _studentDAL.Get(p => p.StudentId == id);
        }

        public Student Update(Student student)
        {
            return _studentDAL.Update(student);
        }
    }
}
