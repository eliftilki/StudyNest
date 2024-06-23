using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Chapter : IEntity
    {
        public int ChapterId { get; set; }
        public string Name { get; set; }
        public TimeSpan Time { get; set; }
        public int ChapterCorseId { get; set; }
        public string Url { get; set; }
    }
}
