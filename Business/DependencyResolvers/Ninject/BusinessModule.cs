using Business.Abstract;
using Business.Concrete.Managers;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDAL>().To<EfUserDAL>();

            Bind<ICourseService>().To<CourseManager>().InSingletonScope();
            Bind<ICourseDAL>().To<EfCourseDAL>();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDAL>().To<EfCategoryDAL>();

          

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<StudyNestContext>();
        }
    }
}
