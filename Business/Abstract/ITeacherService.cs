using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITeacherService
    {
        List<Teacher> GetAll();
        Teacher Add(Teacher teacher);
        Teacher Update(Teacher teacher);
        Teacher GetById(int id);
        void Delete(int id);
    }
}
