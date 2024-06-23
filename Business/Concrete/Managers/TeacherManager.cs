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
    public class TeacherManager : ITeacherService
    {
        private ITeacherDAL _teacherDAL;
        public TeacherManager(ITeacherDAL teacherDAL)
        {
            _teacherDAL = teacherDAL;
        }
        public Teacher Add(Teacher teacher)
        {
            return _teacherDAL.Add(teacher);
        }

        public void Delete(int id)
        {
            var teacher = _teacherDAL.Get(p => p.TeacherId == id);
            if (teacher != null)
            {
                _teacherDAL.Delete(teacher);
            }
        }

        public List<Teacher> GetAll()
        {
            return _teacherDAL.GetList().ToList();
        }

        public Teacher GetById(int id)
        {
            return _teacherDAL.Get(p => p.TeacherId == id);
        }

        public Teacher Update(Teacher teacher)
        {
            return _teacherDAL.Update(teacher);
        }
    }

        
}
