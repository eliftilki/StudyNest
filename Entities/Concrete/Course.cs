using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course : IEntity
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public short CourseCategoryId { get; set; }
        public string Information { get; set; }
        public string Photo { get; set; }
     
        public int CourseTeacherId { get; set; }
        public int Price { get; set; }
        
    }
}
