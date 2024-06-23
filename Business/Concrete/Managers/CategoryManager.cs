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
    public class CategoryManager : ICategoryService
    {
        private ICategoryDAL _categoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public Category Add(Category category)
        {
            return _categoryDAL.Add(category);
        }

        public void Delete(int id)
        {
            var category = _categoryDAL.Get(p => p.CategoryId == id);
            if (category != null)
            {
                _categoryDAL.Delete(category);
            }
        }

        public List<Category> GetAll()
        {
            return _categoryDAL.GetList();
        }

        public Category GetById(int id)
        {
            return _categoryDAL.Get(p => p.CategoryId== id);
        }

        public Category Update(Category category)
        {
            return _categoryDAL.Update(category);
        }
    }
}
