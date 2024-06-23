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
    public class EnrolmentManager : IEnrolmentService
    {
        private IEnrolmentDAL _enrolmentDAL;
        public EnrolmentManager(IEnrolmentDAL enrolmentDAL)
        {
            _enrolmentDAL = enrolmentDAL;
        }
        public Enrolment Add(Enrolment enrolment)
        {
            return _enrolmentDAL.Add(enrolment);
        }

        public void Delete(int id)
        {
            var enrolment = _enrolmentDAL.Get(p => p.EnrolmentId == id);
            if (enrolment != null)
            {
                _enrolmentDAL.Delete(enrolment);
            }
        }

        public List<Enrolment> GetAll()
        {
            return _enrolmentDAL.GetList().ToList();
        }

        public Enrolment GetById(int id)
        {
            return _enrolmentDAL.Get(p => p.EnrolmentId == id);
        }

        public Enrolment Update(Enrolment enrolment)
        {
            return _enrolmentDAL.Update(enrolment);
        }
    }
}
