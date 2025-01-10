using AppDomainCore.CW19.Users.Contract.AppService;
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
        private readonly IUserAppService _userAppService;
        public UserAppService(IUserAppService appService)
        {
            _userAppService = appService;
        }
        public User Add(User user)
        {
           return _userAppService.Add(user);
        }

        public void Delete(int userId)
        {
            _userAppService.Delete(userId);
        }

        public List<User> GetAllUser()
        {
            return _userAppService.GetAllUser();
        }

        public User GetUserById(int userId)
        {
            return _userAppService.GetUserById(userId);
        }

        public User Update(int userId)
        {
            return _userAppService.Update(userId);
        }
    }
}
