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
    public class ChapterCheckManager : IChapterCheckService
    {
        private IChapterCheckDAL _chapterCheckDAL;
        public ChapterCheckManager(IChapterCheckDAL chapterCheckDAL)
        {
            _chapterCheckDAL = chapterCheckDAL;
        }

        public ChapterCheck Add(ChapterCheck chapterCheck)
        {
            return _chapterCheckDAL.Add(chapterCheck);
        }

        public void Delete(int id)
        {
            var chapterCheck = _chapterCheckDAL.Get(p => p.ChapterCheckId == id);
            if (chapterCheck != null)
            {
                _chapterCheckDAL.Delete(chapterCheck);
            }
        }

        public List<ChapterCheck> GetAll()
        {
            return _chapterCheckDAL.GetList();
        }

        public ChapterCheck GetById(int id)
        {
            return _chapterCheckDAL.Get(p => p.ChapterCheckId == id);
        }

        public ChapterCheck Update(ChapterCheck chapterCheck)
        {
            return _chapterCheckDAL.Update(chapterCheck);
        }
    }
}
