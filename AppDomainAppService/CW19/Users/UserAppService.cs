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
            throw new NotImplementedException();
        }

        public void Delete(int userId)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUser(int userId)
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public User Update(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
