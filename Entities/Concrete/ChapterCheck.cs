using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ChapterCheck : IEntity
    {
        public int ChapterCheckId { get; set; }
        public int ChapterCheckChapterId { get; set; }
        public int ChapterCheckStudentId { get; set; }
        public byte ChapterCheckControl { get; set; }
    }
}
