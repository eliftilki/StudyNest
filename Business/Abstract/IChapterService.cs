using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IChapterService
    {
        List<Chapter> GetAll();
        Chapter Add(Chapter chapter);
        Chapter Update(Chapter chapter);
        Chapter GetById(int id);
        void Delete(int id);
        List<Chapter> GetChaptersByCourseId(int courseId);
    }
}
