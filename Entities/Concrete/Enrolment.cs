using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Enrolment:IEntity
    {
        public int EnrolmentId { get; set; }
        public int EnrolmentStudentId { get; set; }
        public int EnrolmentCourseId { get; set; }
        public DateTime  EnrolmentTime { get; set; }

    }
}
