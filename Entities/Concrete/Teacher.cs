using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Teacher : IEntity
    {
        public int TeacherId { get; set; }
        public int TeacherUserId { get; set; }
    }
}
