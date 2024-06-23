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
    public class ChapterManager : IChapterService
    {
        private IChapterDAL _chapterDAL;
        public ChapterManager(IChapterDAL chapterDAL)
        {
            _chapterDAL = chapterDAL;
        }
        public Chapter Add(Chapter chapter)
        {
            return _chapterDAL.Add(chapter);
        }

        public void Delete(int id)
        {
            var chapter = _chapterDAL.Get(p => p.ChapterId == id);
            if (chapter != null)
            {
                _chapterDAL.Delete(chapter);
            }
        }

        public List<Chapter> GetAll()
        {
            return _chapterDAL.GetList().ToList();
        }

        public Chapter GetById(int id)
        {
            return _chapterDAL.Get(p => p.ChapterId == id);
        }

        public List<Chapter> GetChaptersByCourseId(int courseId)
        {
            return _chapterDAL.GetList(p => p.ChapterCorseId == courseId).ToList();
        }

        public Chapter Update(Chapter chapter)
        {
            return _chapterDAL.Update(chapter);
        }
    }
}
