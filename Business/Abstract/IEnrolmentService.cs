using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEnrolmentService
    {
        List<Enrolment> GetAll();
        Enrolment Add(Enrolment enrolment);
        Enrolment Update(Enrolment enrolment);
        Enrolment GetById(int id);
        void Delete(int id);
    }
}
