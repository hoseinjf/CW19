using AppDomainCore.CW19.Users.Contract.AppService;
using AppDomainCore.CW19.Users.Contract.Service;
using CW19.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainAppService.CW19.Users
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _userService;
        public UserAppService(IUserService appService)
        {
            _userService = appService;
        }
        public User Add(User user)
        {
           return _userService.Add(user);
        }

        public void Delete(int userId)
        {
            _userService.Delete(userId);
        }

        public List<User> GetAllUser()
        {
            return _userService.GetAllUser();
        }

        public User GetUserById(int userId)
        {
            return _userService.GetUserById(userId);
        }

        public User Update(User user)
        {
            return _userService.Update(user);
        }
        public List<User> Search(string name)
        {
            return _userService.Search(name);
        }
    }
}
