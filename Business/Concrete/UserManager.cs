using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User AddUser(User user)
        {
            return _userDal.Add(user);
        }

        public void DeleteUser(User user)
        {
            _userDal.Delete(user);
        }

        public List<User> GetAllUsers()
        {
            return _userDal.GetAll();
        }

        public User GetUserByUserName(string userName)
        {
            return _userDal.Get(u => u.UserName.ToLower().Contains(userName.ToLower()));
        }

        public User GetUserByUserNameAndPassword(string userName, string password)
        {
            return _userDal.Get(u => u.UserName.Equals(userName) && u.UserPassword.Equals(password));
        }
        public User UpdateUser(User user)
        {
            return _userDal.Update(user);
        }
    }
}
