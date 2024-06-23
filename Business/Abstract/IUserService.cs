using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User Add(User user);
        User Update(User user);
        User GetById(int id);
        User GetByEmail(string email);
        void Delete(int id);

    }
}
