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

        User IUserService.AddUser(User user)
        {
            return _userDal.Add(user);
        }

        void IUserService.DeleteUser(User user)
        {
            _userDal.Delete(user);
        }

        List<User> IUserService.GetAllUsers()
        {
            return _userDal.GetAll();
        }

        User IUserService.GetUserByUserName(string userName)
        {
            return _userDal.Get(u => u.UserName.ToLower().Contains(userName.ToLower()));
        }

        User IUserService.UpdateUser(User user)
        {
            return _userDal.Update(user);
        }
    }
}
