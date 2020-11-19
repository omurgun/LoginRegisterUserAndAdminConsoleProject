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
        List<User> GetAllUsers();
        User GetUserByUserName(string userName);
        User GetUserByUserNameAndPassword(string userName, string password);
        User AddUser(User user);
        User UpdateUser(User user);
        void DeleteUser(User user);
        
    }
}
