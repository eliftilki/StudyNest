using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Managers
{

    public class UserManager : IUserService
    {
        private IUserDAL _userDAL;
        private IStudentService _studentService;
        private ITeacherService _teacherService;
        public UserManager(IUserDAL userDAL,IStudentService studentService, ITeacherService teacherService)
        {
            _userDAL = userDAL;
            _studentService = studentService;
            _teacherService = teacherService;
        }
        public User Add(User user)
        {
            ValidationTool.FluentValidate(new UserValidator(), user);
            var addedUser = _userDAL.Add(user);

            if (user.Autho == 0)
            {
                var student = new Student { StudentUserId = addedUser.UserId };
                _studentService.Add(student);
            }
            else if (user.Autho == 1)
            {
                var teacher = new Teacher { TeacherUserId = addedUser.UserId};
                _teacherService.Add(teacher);
                var student = new Student { StudentUserId = addedUser.UserId };
                _studentService.Add(student);
            }

            return addedUser;
        }

        public List<User> GetAll()
        {
            return _userDAL.GetList().ToList();
        }

        public User GetById(int id)
        {
            return _userDAL.Get(p => p.UserId == id);
        }

        //[FluentValidate(typeof(UserValidator))]
        public User Update(User user)
        {
            
            return _userDAL.Update(user);
        }

        public void Delete(int id)
        {
            var user = _userDAL.Get(p => p.UserId == id);
            if (user != null)
            {
                _userDAL.Delete(user);
            }
        }

        public User GetByEmail(string email)
        {
           
            return _userDAL.Get(p => p.Email == email);
        }
    }
}
